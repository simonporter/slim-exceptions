   M S B A M L   `   `   `  ����E  ACleanStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CleanStack
CleanStack  5   	       CleanStack.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CleanStack     5   	     � Title$  Stack Cleaner��5   	   $	��700��6   $
��1000��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ 	textBoxIn��5
      $
��Left=�6%   $��	0,25,0,10q�6@   $	��306��6S   " �� VerticalScrollBarVisibility$
 Auto=�6_   $ �� HorizontalScrollBarVisibility$
 Auto=�6�    �� AcceptsReturn . 6�   �� 5   
   -   5        $ 
textBoxOut��5      $��311,25,10,10q�6&   $
 Auto=�6<   $
 Auto=�6a   �� 5   
   -   5         ��Name$ buttonClean��5      $��Clean��6&   $
��Left=�66   $��20��6Q   $	��Top=�6]   $��55��6u   $��1��6�   �� 5   
   -   5        $ buttonClear��5      $��Clear��6&   $
��Left=�66   $��65,0,0,0q�6Q   $��20��6c   $	��Top=�6o   $��55��6�   6�   �� 5   
   -   5         ��Name$ checkBoxRemoveAsync��5      $��Remove Async��60   $
��Left=�6G   $��20��6b   $��	362,0,0,0q�6n   $	��Top=�6�   $	��131��6�    d� 	IsChecked$
 TrueY�6�   �� 5   
   -   5        $ checkBoxRemoveThrows��5      $��Remove rethrows��61   $
��Left=�6K   $��20��6f   $��	493,0,0,0q�6r   $	��Top=�6�   $	��116��6�   $
 TrueY�6�   �� 5   
   -   5        $ checkBoxSystemRefs��5      $��Any System Ref��6/   $
��Left=�6H   $��20��6c   $��	251,0,0,0q�6o   $	��Top=�6�   $	��111��6�   $
 TrueY�6�   5      5      