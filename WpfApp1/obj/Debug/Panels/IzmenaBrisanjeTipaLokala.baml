   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp1.PanelsWpfApp1.Panels  5   	   7 clr-namespace:WpfApp1.ValidationWpfApp1.Validation  5   	   -    'WpfApp1.Panels.IzmenaBrisanjeTipaLokala   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp1.Panels     5   	   0val clr-namespace:WpfApp1.Validation     5   	     � Title$  IzmenaBrisanjeTipaLokala��5	   	   $	��400��6*   $	��500��67   .��5
      � $��25,25,25,25q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   $��22��6*   �� 5      $
��Auto �6   $��18��6*   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��320��6*    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6$   Jedinstvena oznaka:6F   �� 5   
   $��0��6   $��1��6$   Naziv:69   �� 5   
   $��0��6   $��2��6$   
Ikonica:6;   �� 5   
   $��0��6   $��3��6$   Opis:68   �� 5   
   -   5        $��tbNaziv��5      $��1��6!   $��1��61   $��	0,0,220,0q�6?   .��6R   ��5      �� 5       �� Path$ Naziv�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 5      ,   &WpfApp1.Validation.NoSpecialCharacters  5       ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�62   6V   5"      .��5#       =� ErrorTemplate 5$      �� 5%      .R�5&      �  5'      �� 5(       5*      �� 5+      �� 5,      $
��Auto �6/   .+�5/      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 50      $��1��6$   $��0��64   
���  ����6A   �� *[0].ErrorContent+6c   51      52      .��53   (   54      �� 56   
   -   5        $��tbOpis��56      $��1��6!   $��3��61   $��0,0,220,165q�6>   .��6S   ��57      �� 58      $
 Opis�6   $ PropertyChanged=�6&    59        5:      $ RawProposedValue=�62   6V   5<      .��5=       5>      �� 5?      .R�5@      �  5A      �� 5B       5D      �� 5E      �� 5F      $
��Auto �6/   .+�5I      �� $ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5J      $��1��6$   $��2��64   
���  ����6A   �� *[0].ErrorContent+6c   5K      5L      .��5M   (   5N      �� 5O   
   -   5        $��Sacuvaj izmene��5O      $��1��6*   $
��Left=�6:   $��243,207,0,0q�6U   $��3��6j   $	��Top=�6w   $��84��6�   $��38��6�   6�   �� 5P   
   -   5        $��Izaberite Ikonicu��5P      $��1��6-   $
��Left=�6=   $��2��6X   $	��Top=�6e   $	��117��6}   $��20��6�   	 J� RenderTransformOrigin$	 0.32,0.5&�6�   $��0,3,0,0q�6�   6�   �� 5Q   
   -   5        $
��cbId��5Q      $
��Left=�6   $��	102,0,0,0q�6:   $	��Top=�6M   $	��120��6e   $��2��6q   $��22��6�   6�   �� 5R   
   -   5        $��Obrisi��5R      $��1��6"   $
��Left=�62   $��163,207,0,0q�6M   $��3��6b   $	��Top=�6o   $��75��6�   $��38��6�   6�   5S      5T      