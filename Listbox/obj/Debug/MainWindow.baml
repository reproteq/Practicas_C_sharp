   M S B A M L   `   `   `  ����B  >Listbox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ListboxListbox  5   	       Listbox.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Listbox     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��600��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��374* �6   �� 5      $
��104* �6   .+�5   
   �� -   5         ��Name$ ListaPoblaciones��5      $��Stretch=�6,   $��Stretch=�6J   $��1��6f   ��5      �� 5      .R�5      � $	��550��6    � ColumnDefinitions 5      �� 5      $��* �60   6=   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   .+�5      �� $��0��6$   ��64   �� *
Poblacion1+6S   �� 5      $��1��6$   ��64   �� *Temp1+6N   �� 5      $��2��6$   ��64   �� *
Poblacion2+6S   �� 5      $��3��6$   ��64   �� *Temp2+6N   �� 5      $��4��6$   ��64   �� *	TempDif+6P   � 5       $��5��6&    � Minimum$ 0Q�66    � Value 6C   �� *	TempDif+6_   5"      5$      5'      �� 5(   
   -   5        $��Button��5(      $
��Left=�6"   $��
181,45,0,0q�6=   $��2��6Q   $	��Top=�6^   $	��249��6v   $��53��6�   6�   �� 5)   
   $��Ciudad / Temp��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   $	��112��6n   �� 5*   
   $��Ciudad / Temp��6   $
��Left=�6(   $��
196,10,0,0q�6C   $	��Top=�6W   $	��112��6o   �� 5+   
   $.��(TempDiferencia                   Grafico��6   $
��Left=�6C   $��
358,10,0,0q�6^   $	��Top=�6r   $	��224��6�   5-      5.      