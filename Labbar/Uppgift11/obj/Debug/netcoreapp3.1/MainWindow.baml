   M S B A M L   `   `   `  ����D  @Uppgift11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Uppgift11	Uppgift11  5   	       Uppgift11.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Uppgift11     5   	     � Title$  Smörgåsen��5   	   $	��414��6   $	��326��6(   .��5	      � -   5         �Name$ ___No_Name_��5	      $��0,0,0,-6q�6    .+�5
   
   �� $��Oturskalkylkator��6   $
��Left=�6+   $��	33,24,0,0q�6F   $	��Top=�6Y   $
��Bold"�6q   $��22(�6�   �� 5   
   -   5         ��Name$ 
mindreotur��5      $��Mindre
otur��6%   $
��Left=�6D   $��	25,95,0,0q�6_   $	��Top=�6r   $��54��6�   $��40��6�   6�   � 5   
   -   5         �Name$	 bar��5      $
��Left=�6#   $��20��6>   $��
90,105,0,0q�6J   $	��Top=�6^   $	��140��6v    � Minimum$ 0Q�6�    � Maximum$	 100Q�6�    � Value$ 50Q�6�   6�   �� 5   
   -   5        $ merotur��5      $��	Mer
otur��6"   $
��Left=�6>   $��
245,95,0,0q�6Y   $	��Top=�6m   $��40��6�   $��54��6�   6�   �� 5   
   $��Antal försök��6   $
��Left=�6'   $��
31,167,0,0q�6B   $	��Top=�6V   $��22(�6n   $
��Bold"�6|   �� 5   
   -   5         ��Name$ försök��5      $
��Left=�6"   $��
31,211,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   $��Utfall��6   $
��Left=�6!   $��
31,253,0,0q�6<   $	��Top=�6P   $��22(�6h   $
��Bold"�6v   �� 5   
   $��Antal åt fel håll: ��6   $
��Left=�6.   $��
33,297,0,0q�6I   $	��Top=�6]   �� 5   
   $��Antal åt rätt håll:��6   $
��Left=�6.   $��
33,328,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ starta��5      $��Starta��6!   $
��Left=�62   $��202,211,0,0q�6M   $	��Top=�6b   $��60��6z   6�   �� 5   
   -   5        	 ��Name$	 rätthållsiffror��5      $�� ��6)   $
��Left=�64   $��130,297,0,0q�6O   $	��Top=�6d   �� 5   
   -   5        $	 felhållsiffror��5      $�� ��6(   $
��Left=�63   $��130,328,0,0q�6N   $	��Top=�6c   �� 5   
   $
��Left=�6X   $��
196,76,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $��18(�6�   $��Normal"�6�   ��6   �� 
 �� ElementName$	
 bar�� �� Path$ Value� �� StringFormat$ {0:0}%��6�   5      5      