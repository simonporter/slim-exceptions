using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CleanStack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var stack = textBoxIn.Text;

            var cleanStack = new StringBuilder();

            var lines = stack.Split(new string[] { Environment.NewLine, "\r\n" }, StringSplitOptions.None);

            // Copied from something that stripped the lines
            if (lines.Length == 1 || (lines.Length == 2 && lines[1] == string.Empty))
            {
                stack = stack.Replace(" at ", Environment.NewLine + "at ");
                stack = stack.Replace(" --- End of", Environment.NewLine + "--- End of");

                lines = stack.Split(new string[] { Environment.NewLine, "\r\n" }, StringSplitOptions.None);
            }

            foreach (var s in lines)
            {
                var line = s;

                // Remove leading spaces for comparisons 
                line = line.TrimStart();

                // Strip any system ref
                if (checkBoxSystemRefs.IsChecked ?? false)
                {
                    if (line.StartsWith("at System.")) { continue; }
                }

                // Strip Async stuff
                if (checkBoxRemoveAsync.IsChecked ?? false) {
                    if (line == "at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)") { continue; }
                    if (line == "at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)") { continue; }
                    if (line == "at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()") { continue; }
                    if (line == "at System.Runtime.CompilerServices.TaskAwaiter.GetResult()") { continue; }
                    if (line == "at System.Threading.Tasks.Task.ThrowIfExceptional(Boolean includeTaskCanceledExceptions)") { continue; }
                    if (line == "at System.Threading.Tasks.Task.Wait(Int32 millisecondsTimeout, CancellationToken cancellationToken)") { continue; }
                }

                // Strip throws and inner
                if (checkBoxRemoveThrows.IsChecked ?? false)
                {
                    if (line == "--- End of stack trace from previous location where exception was thrown ---") { continue; }
                    if (line == "--- End of inner exception stack trace ---") { continue; }
                }

                cleanStack.AppendLine(s);
            }

            textBoxOut.Text = cleanStack.ToString();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxIn.Clear();
            textBoxOut.Clear();
        }

        private void textBoxIn_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxIn.Text = Clipboard.GetText();
            buttonClean.Focus();
        }
    }
}
