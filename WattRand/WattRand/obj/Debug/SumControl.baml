   M S B A M L   `   `   `  ����C  ?WattRand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WattRand.ConvertersWattRand.Converters  5      #clr-namespace:WattRandWattRand  5          WattRand.SumControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ` \Xceed.Wpf.Toolkit, Version=3.7.18313.20590, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      2
converters!clr-namespace:WattRand.Converters  5      "localclr-namespace:WattRand  5        � 	Resources  5      3   -WattRand.Converters.BoolToVisibilityConverter   BoolToVisibility   	TrueValue   
FalseValue  BoolToVisibilityInvert��%�   &	        &	 ;       5   
   $ Visible=�6H   $ 	Collapsed=�6\   6u     5   
   $ 	Collapsed=�6N   $ Visible=�6d   6{   5      .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��50 �6   6,   �� 5      $��* �6   6+   �� 5      $��15 �6   6,   .+�5   
   �� $��2��6   ._�5      � .+�5      �� $��10,0,0,0q�6    �� Orientation$ 
Horizontal=�6/   .+�5      �� $��Data: ��6    $��20(�6.   $
��Bold"�6<   
�������6c   �� 5       $��20(�6W   
���������6    �� *DateSelected+ �� StringFormat$ 
yyyy/MM/dd��6z   5!      �� 5"      $��Valore Dentro��6   $��20(�5#      $
��Bold"�6*   
�������$��Right=�6O   y�5"   1   �� *	IsInValue+ �� 	Converter# [  5#   m   �� 5$      $��Valore Fuori��6   $��20(�5%      $
��Bold"�6*   
�������$��Right=�6O   y�5$   0   �� *	IsInValue+# [ 5%   m   5&      5'      �� 5(   
   $	��A1:��6   $��1��6   
�������$��17(�6?   $��Center=�6M   $��Right=�6i   6�   �� 5)   
   $	��A2:��6   $��2��6   
�������$��17(�6?   $��Center=�6M   $��Right=�6i   6�   �� 5*   
   $	��A3:��6   $��3��6   
�������$��17(�6?   $��Center=�6M   $��Right=�6i   6�   $  Xceed.Wpf.Toolkit.DoubleUpDown  5,   
   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$	 A3:��6   $��1��6'   $��1��64   $��17(�6D   $��Center=�6R   $��	10,0,10,0q�6m   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Value	 6�   �� *
ValueOne+6�     5-   
   $	 A3:��6   $��2��6'   $��1��64   $��17(�6D   $��Center=�6R   $��	10,0,10,0q�6m   	 6�   �� *
ValueTwo+6�     5.   
   $	 A3:��6   $��3��6'   $��1��64   $��17(�6D   $��Center=�6R   $��	10,0,10,0q�6m   	 6�   �� *
ValueThree+6�   �� 50   
   $��Conferma��6   $��4��6G   $��3��6T   $	��100��6h   $��35��6t   $��	0,10,0,10q�6�   ��6$   �� *ConfirmCommand+6�   51      52      