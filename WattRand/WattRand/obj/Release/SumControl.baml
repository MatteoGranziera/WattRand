   M S B A M L   `   `   `  ���� C  ?WattRand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WattRand.ConvertersWattRand.Converters  #clr-namespace:WattRandWattRand      WattRand.SumControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ` \Xceed.Wpf.Toolkit, Version=3.7.18313.20590, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  2
converters!clr-namespace:WattRand.Converters  "localclr-namespace:WattRand    � 	Resources  3   -WattRand.Converters.BoolToVisibilityConverter   BoolToVisibility   	TrueValue   
FalseValue  BoolToVisibilityInvert��%Z   &	        &	 #       $ Visible=�$ 	Collapsed=�  $ 	Collapsed=�$ Visible=�.���  � RowDefinitions �� $��35 ��� $��35 ��� $��35 ��� $��35 ��� $��* � � ColumnDefinitions �� $��50 ��� $��* ��� $��15 �.+��� $��2��._�� .+��� $��10,0,0,0q� �� Orientation$ 
Horizontal=�.+��� $��Data: ��$��20(�$
��Bold"�
��������� $��20(�
����������� *DateSelected+ �� StringFormat$ 
yyyy/MM/dd���� $��Valore Dentro��$��20(�$
��Bold"�
�������$��Right=�y��� *	IsInValue+ �� 	Converter# [  �� $��Valore Fuori��$��20(�$
��Bold"�
�������$��Right=�y��� *	IsInValue+# [ �� $	��A1:��$��1��
�������$��17(�$��Center=�$��Right=��� $	��A2:��$��2��
�������$��17(�$��Center=�$��Right=��� $	��A3:��$��3��
�������$��17(�$��Center=�$��Right=�$  Xceed.Wpf.Toolkit.DoubleUpDown  ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$	 A3:��$��1��$��1��$��17(�$��Center=�$��	10,0,10,0q��  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Value	 �� *
ValueOne+  $	 A3:��$��2��$��1��$��17(�$��Center=�$��	10,0,10,0q�	 �� *
ValueTwo+  $	 A3:��$��3��$��1��$��17(�$��Center=�$��	10,0,10,0q�	 �� *
ValueThree+�� $��Conferma��$��4��$��3��$	��100��$��35��$��	0,10,0,10q����� *ConfirmCommand+