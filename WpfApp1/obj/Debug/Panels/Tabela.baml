   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.Panels.Tabela   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��TabelaLokala��5   1     � Title$  Tabela��6	   $	��450��6   $	��636��6%   .��5      � $��25,25,25,25q�6    � RowDefinitions 5   
   �� 5      $	��96* �6   �� 5      $
��323* �6    � ColumnDefinitions 5
   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6v   ��6$   ��  �� Path$ Lokali�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Ime��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToCells 66      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *Ime+5      5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $	 Id��6%   $
 SizeToCells 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Id+6^     5      $
	 Opis��6%   $
 SizeToCells 63    6G   �� *Opis+6b    �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         HeaderTemplate 5      �� 5      .R�5       �� $ 
Horizontal=�6)   .+�5!   "   �� $��Ime: ��6,   6;   �� 5"   "   $
��Bold"�6A   ��6,   �� *Ime+6A   5#      5$      5&      5(      � 5)   
   $��0��6   $��1��6    � DataContext 6,   ��  �� ElementName$ dgrMain��$ SelectedItem� 5*      �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    $��50��6.   �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6     56      �� 57      $
��Auto �6#   �� 58      $
��Auto �6#   �� 59      $
��Auto �6#   .+�5;      �� $��0��6   $��0��6(   Id:6:   �� 5<      $��0��6   $��1��6(   Ime:6;   �� 5=      $��0��6   $��2��6(   Opis:6<   �� 5>      $��0��6   $��3��6(   DostupnoZaHendikepirane:6O   �� 5?      $��0��6   $��4��6(   DozvoljenoPusenje:6I   �� 5@      $��0��6   $��5��6(   KategorijaCena:6F   �� 5A      $��0��6   $��6��6(   SluzenjeAlkohola:6H   �� 5B      $��0��6   $��7��6(   
Kapacitet:6A   �� 5C      $��0��6   $��8��6(   DatumOtvaranja:6F   �� 5D      $��0��6   $��9��6(   Rezervacije:6C   �� 5F      $��1��6   $��0��6(   $��2��6N   ��65   �� $ Id�6d   �� 5G      $��1��6   $��1��6(   $��2��6O   ��65   �� $	 Ime�6e   �� 5H      $��1��6   $��2��6(   $��2��6P   ��65   �� $
 Opis�6f   �� 5I      $��1��6   $��3��6'   $��2��6c   {�.   d� 	IsChecked 64   �� $ DostupnoZaHendikepe�6w   �� 5J      $��1��6   $��4��6'   $��2��6a   {�.   64   �� $ DozvoljenoPusenje�6u   �� 5K      $��1��6   $��5��6(   $��2��6Z   ��65   �� $ KategorijaCena�6p   �� 5L      $��1��6   $��6��6(   $��2��6\   ��65   �� $ SluzenjeAlkohola�6r   �� 5M      $��1��6   $��7��6(   $��2��6U   ��65   �� $ 	Kapacitet�6k   �� 5N      $��1��6   $��8��6(   $��2��6Z   ��65   �� $ DatumOtvaranja�6p   �� 5O      $��1��6   $��9��6'   $��2��6[   {�.   64   �� $ Rezervacije�6o   �� 5P      $��Obrisi��6   $��2��6&   $
��Left=�66   $��344,67,-404,-48q�6Q   $��9��6j   $	��Top=�6w   $��75��6�   �� 5Q      $��Izmeni��6   $��2��6&   $
��Left=�66   $��238,67,-293,-8q�6Q   $��9��6i   $	��Top=�6v   $��75��6�   $��20��6�   5R      5S      5T      