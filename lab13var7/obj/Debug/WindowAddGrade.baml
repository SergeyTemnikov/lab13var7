   M S B A M L   `   `   `  ����D  @lab13var7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:lab13var7	lab13var7  5   	       lab13var7.WindowAddGrade   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:lab13var7     5   	     � Title$#  Добавить оценку��5   	   $	��350��6!   $	��300��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6!   $#��Добавить оценку��61   $��Center=�6H   $��Center=�6e   $��5q�6�   �� 5   
   $��1��6   $��0��6!   $(��"Выбрать учащегося:��61   $��Center=�6K   $��Center=�6h   $��5q�6�   �� 5   
   -   5        $��
cmbStudent��5      $��1��6%   $��1��62   $��Stretch=�6C   $��Center=�6a   $��5q�6|    �� DisplayMemberPath$
 Name��6�   �� 5   
   $��2��6   $��0��6!   $$��Выбрать предмет:��61   $��Center=�6I   $��Center=�6f   $��5q�6�   �� 5   
   -   5        $��
cmbSubject��5      $��2��6%   $��1��62   $��Stretch=�6C   $��Center=�6a   $��5q�6|   $
 Name��6�   �� 5   
   $��3��6   $��0��6!   $"��Выбрать оценку:��61   $��Center=�6H   $��Center=�6e   $��5q�6�   �� 5   
   -   5        $��cmbGrade��5      $��3��6#   $��1��60   $��Stretch=�6A   $��Center=�6_   $��5q�6z   �� 5    
   -   5        $��btnSave��5       $��4��6    $��0��6-   $��Stretch=�6=   $��Center=�6[   $��5q�6v   $��Сохранить��6�   6�   �� 5!   
   -   5        $��	btnCancel��5!      $��4��6"   $��1��6/   $��Stretch=�6?   $��Center=�6]   $��5q�6x   $��Отменить��6�   6�   5"      5#      