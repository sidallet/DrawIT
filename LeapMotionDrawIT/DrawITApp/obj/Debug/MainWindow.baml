   M S B A M L   `   `   `  ����D  @DrawITApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DrawITApp	DrawITApp  5   	       DrawITApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DrawITApp     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)   $	��350��65   $	��730��6E   .��5	      �  � ColumnDefinitions 5
      �� 5      $��1* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6    � RowDefinitions 5      �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      $��1* �6   .+�5      �� -   5         ��Name$ textBox1��5      6#   �� 5   
   -   5        $ textBox2��5   !   $��1��6   65   �� 5   
   -   5         ��Name$ button_start��5   \   ���	#FF13AA13$��2��6(   $��Start��69   $��16(�6r   6�   �� 5   
   -   5        $ button_stop��5   Z   
���\\��$��3��6(   $
��Stop��69   $��16(�6o   6�   �� 5   
   -   5        $ button_clear��5   U   $��1��6   $��3��6   $��Effacer��60   ���	#FFDED5D5$��16(�6�   6�   �� 5   
   -   5        $ button_color��5   T   $��1��6   $��2��6   $��Couleur��6/   $��16(�6j   ��5       �� 5!       �� ImageSource$ arc.bmp��6   5#      �� 5$   
   -   5        $ button_save��5$   P   $��1��6   $��Sauvegarder image��6"   ���	#FFDED5D5$��16(�6|   6�   �� 5%   
   -   5        $ button_import��5%   \   $��1��6   $��1��6"   $��Importer image��6/   ���	#FFDED5D5$��16(�6�   6�   �� 5(   
   $��2q�6   
���   �$��3��69   $��4��6F   ._�5)      �� -	   5         ��Name$
 zone��5)      $��3��6#   $��4��60   5*      5+      5,      5-      