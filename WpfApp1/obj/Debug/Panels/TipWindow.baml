   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp1.PanelsWpfApp1.Panels  5   	   7 clr-namespace:WpfApp1.ValidationWpfApp1.Validation  5   	       WpfApp1.Panels.TipWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp1.Panels     5   	   0val clr-namespace:WpfApp1.Validation     5   	     � Title$	  Tip��5	   	   $	��400��6   $	��500��6"   .��5
      � $��25,25,25,25q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��320��6*    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6$   Jedinstvena oznaka:6F   �� 5   
   $��0��6   $��1��6$   Naziv:69   �� 5   
   $��0��6   $��2��6$   
Ikonica:6;   �� 5   
   $��0��6   $��3��6$   Opis:68   �� 5   
   -   5        $
��tbId��5      $��1��6   $��0��6/   $��	0,0,220,0q�6=   .��6P   ��5      �� 5       �� Path$ Id�6    �� UpdateSourceTrigger$ PropertyChanged=�6$    �� ValidationRules 5      ,   &WpfApp1.Validation.NoSpecialCharacters  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�62   6V   5!      .��5"       =� ErrorTemplate 5#      �� 5$      .R�5%      �  5&      �� 5'       5)      �� 5*      �� 5+      $
��Auto �6/   .+�5.      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5/      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   50      51      .��52   (   53      �� 54   
   -   5        $��tbNaziv��54      $��1��6!   $��1��61   $��	0,0,220,0q�6?   .��6R   ��55      �� 56      $ Naziv�6   $ PropertyChanged=�6'    57        58      $ RawProposedValue=�62   6V   5:      .��5;       5<      �� 5=      .R�5>      �  5?      �� 5@       5B      �� 5C      �� 5D      $
��Auto �6/   .+�5G      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5H      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   5I      5J      .��5K   (   5L      �� 5N   
   -   5        $��tbOpis��5N      $��1��6!   $��3��61   $��0,0,220,165q�6>   .��6S   ��5O      �� 5P      $
 Opis�6   $ PropertyChanged=�6&    5Q        5R      $ RawProposedValue=�62   6V   5T      .��5U       5V      �� 5W      .R�5X      �  5Y      �� 5Z       5\      �� 5]      �� 5^      $
��Auto �6/   .+�5a      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5b      $��1��6$   $��2��64   
���  ����6A   �� *[0].ErrorContent+6c   5c      5d      .��5e   (   5f      �� 5g   
   -   5        $��Sacuvaj Tip��5g      $��1��6'   $
��Left=�67   $��243,207,0,0q�6R   $��3��6g   $	��Top=�6t   $��84��6�   $��38��6�   6�   �� 5h   
   -   5        $��Izaberite Ikonicu��5h      $��1��6-   $
��Left=�6=   $��2��6X   $	��Top=�6e   $	��117��6}   $��20��6�   	 J� RenderTransformOrigin$	 0.32,0.5&�6�   $��0,3,0,0q�6�   6�   5i      5j      