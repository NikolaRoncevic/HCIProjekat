   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp1.PanelsWpfApp1.Panels  5   	   7 clr-namespace:WpfApp1.ValidationWpfApp1.Validation  5   	   "    WpfApp1.Panels.EtiketaWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp1.Panels     5   	   0val clr-namespace:WpfApp1.Validation     5   	     � Title$  Etiketa��5	   	   $	��450��6   $	��800��6&   .��5
      � $��25,25,25,25q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��160��6*   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6$   Jedinstvena oznaka:6F   �� 5   
   $��0��6   $��1��6$   Opis:68   �� 5   
   $��0��6   $��2��6$   Boja:68   �� 5   
   -   5        $
��tbId��5      $��1��6   $��0��6.   $��	0,0,220,0q�6<   .��6O   ��5      �� 5       �� Path$ Id�6    �� UpdateSourceTrigger$ PropertyChanged=�6$    �� ValidationRules 5      ,   &WpfApp1.Validation.NoSpecialCharacters  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�62   6V   5      .��5        =� ErrorTemplate 5!      �� 5"      .R�5#      �  5$      �� 5%       5'      �� 5(      �� 5)      $
��Auto �6/   .+�5,      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5-      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5.      5/      .��50   (   51      �� 52   
   -   5        $��tbOpis��52      $��1��6    $��1��60   $��	0,0,200,0q�6>   .��6Q   ��53      �� 54      $
 Opis�6   $ PropertyChanged=�6&    55        56      $ RawProposedValue=�62   6V   58      .��59       5:      �� 5;      .R�5<      �  5=      �� 5>       5@      �� 5A      �� 5B      $
��Auto �6/   .+�5E      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5F      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5G      5H      .��5I   (   5J      �� 5K   
   -   5        $��Odabir boje��5K      $��1��6'   $��2��67   $��
0,0,552,26q�6D   6n   �� 5L   
   -   5        $��tbColor��5L      $��1��6"   $
��Left=�62   $��23��6M   $��	176,0,0,0q�6Y   $��2��6l   	 �� TextWrapping$
	 Wrap=�6y   $�� ��6�   $	��Top=�6�   $��59��6�   �� 5M   
   -   5        $��Sacuvaj Etiketu��5M      $��1��6+   $
��Left=�6;   $��512,128,0,-130q�6V   $��2��6n   $	��Top=�6{   $	��115��6�   $��51��6�   6�   5O      5P      