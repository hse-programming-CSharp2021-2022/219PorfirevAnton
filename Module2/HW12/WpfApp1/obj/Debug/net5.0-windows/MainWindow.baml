   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��Center=�6   
����ح�$��Center=�5
       � ShowGridLines$
 True��6&   $	��333��6;   $	��396��6H    � RowDefinitions 5   
   �� 5      $	��295 �6   �� 5      $��38 �6    � ColumnDefinitions 5   
   �� 5      $��38 �6   �� 5      �� 5      $	��357 �6   .+�5   
   �� -   5        $��sliderV��5   .   $��0��6   $��0��6    � Minimum$ 0Q�6=    � Maximum$	 200Q�5       �� Orientation$ Vertical=�6   $��10,10,10,10q�67   6L   �� 5   
   -   5        $��canvas��5   .   $��0��6   $��1��6   
�������$��2��5   *   .+�5      � -   5        $	��pol��5      
����  �$��3��60   6G   5      �� 5   
   -   5        $��sliderH��5   .   $��1��6   $��2��6   $ 0Q�6=   $	 200Q�5      $ 
Horizontal=�6   $��
9,10,10,10q�68   6L   �� 5   
   -   5        $��button��5      $��Clear��6   $��1��5   	   $��0��6   5      5       