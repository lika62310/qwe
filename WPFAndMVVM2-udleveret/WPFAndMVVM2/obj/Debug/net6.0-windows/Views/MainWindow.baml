   M S B A M L   `   `   `  ����F  BWPFAndMVVM2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFAndMVVM2WPFAndMVVM2  5   	       WPFAndMVVM2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFAndMVVM2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��250 �6   $	��200��6+   �� 5      $��5 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $	��10* �6    �� 5      $��* �6    .+�5      �� $��0��68   ��6   �� *	PersonsVM+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� ��5   "   `� 5   &    �� StringFormat$ {0} {1}��63   .1�5   *   ��  �� Path$ 	FirstName�62   �� 5   *   $ LastName�62   5   '   5      5       5!      5#      �� 5$      $ 
Horizontal=�6   $��1��62   5%      �� 5'   
   $��5��6   $��1��6!   $��Stretch=�61   � 5(   
   $��2��6   .+�5)      �� -   5        $��
First name��5)      $��20��6(   $	��Top=�64   $��170,62,171,0q�6L   6b   �� 5*      $��	Last name��6   $��20��6'   $��170,109,171,0q�63   $	��Top=�6J   �� 5+      $	��Age��6   $��20��6!   $��170,158,171,0q�6-   $	��Top=�6D   �� 5,      $��Phone��6   $��20��6#   $��170,204,171,0q�6/   $	��Top=�6F   �� 5-      $��
FirstName:��6   $
��Left=�6)   $��	67,59,0,0q�6D   $	��Top=�6W   �� 5.      $��	LastName:��6   $
��Left=�6(   $��
67,103,0,0q�6C   $	��Top=�6W   $��66��6o   �� 5/      $
��Age:��6   $
��Left=�6#   $��
67,152,0,0q�6>   $	��Top=�6R   �� 50      $��Phone:��6   $
��Left=�6%   $��
67,204,0,0q�6@   $	��Top=�6T   51      52      53      