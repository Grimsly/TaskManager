   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	       TaskManager.AddTaskWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	     � Title$  AddTaskWindow��5   	   $	��200��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $
��Task��6   $��0��6    $��0��60   $��10q�6=   �� 5   
   $
��Date��6   $��0��6    $��1��60   $��10q�6=   �� 5   
   -   5        $��	TaskInput��5      $��1��6#   $��0��63   $��10q�6@   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
DatePicker��5      $��1��6'   $��1��67   $��10q�6D   � 5   
   $��1��6   $��2��6    $��Right=�6-    5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5        $	��Add��5      $��0��64   $	��100��6D   $��30��6P   $��	10 0 10 0q�6\   �� 5      -   5        $��Close��5      $��1��68   $	��100��6H   $��30��6T   $��	10 0 10 0q�6`   5      5      5       