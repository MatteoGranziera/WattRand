   M S B A M L   `   `   `  ���� C  ?WattRand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WattRandWattRand  9!clr-namespace:WattRand.ViewModelsWattRand.ViewModels  9!clr-namespace:WattRand.ConvertersWattRand.Converters      WattRand.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:WattRand     8
viewModels!clr-namespace:WattRand.ViewModels     8
converters!clr-namespace:WattRand.Converters     ` \Xceed.Wpf.Toolkit, Version=3.7.18313.20590, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  WattRand��$	��550��$	��750��
���   �
������� � 	Resources  �� MergedDictionaries �� Source3   -WattRand.Converters.BoolToVisibilityConverter   BoolToVisibility   	TrueValue   
FalseValue �� 
TargetType  
NullButton �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value �� ScaleX �� ScaleY  ControlElementTemplate �� DataType1   +WattRand.ViewModels.ControlElementViewModel �� Padding � RowDefinitions � ColumnDefinitions �� Path �� ResourceKey(  "System.Windows.Controls.DatePicker   SelectedDate$  Xceed.Wpf.Toolkit.DoubleUpDown�  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value��  �� $ Images.xaml?�%�  &	        &	 #     &	 S    7  0�� $ 
RemoveIcon��17  0�� $ EditIcon��17  0�� $ EditIcon��1  $ Visible=�$ 	Collapsed=��� " ��.���  � �� �� "	 ��.R��� #��z��._��� ��  �@�Cursor$
 Hand����  � ��$ Center=���  � ��$
 Auto����  � �� �	#01000000��  �@J�RenderTransformOrigin$ 0.5,0.5&�
 P�  �@J�IsMouseOver . . ���  � z� �� $	 1.2Q�$	 1.2Q��� "  .R��� $ 5q�$��Stretch=�._��  �� $��20 ��� $��25 � �� $��15 ��� $��30 ��� $��0 ��� $��30 ��� $��* ��� $��10 ��� $��* ��� $��10 ��� $��* �.+��� $��2��$��1��8��  ���� $ RemoveCommand�.��2 �� $��4��$
��Data��$��Bottom=�
��������� $��6��$��Valore Dentro��$��Bottom=�
��������� $��8��$��Valore Fuori��$��Bottom=�
�������  $��4��$��1�� �� *Date+  $��6��$��1�� �� *	InValue+�� $��6��$��1��8�� $��15��$��15��$��5q�$��Center=�$
��Left=�$
��True������ *OpenSumCommand+.��2   $��8��$��1�� �� *
OutValue+�� $��8��$��1��8�� $��15��$��15��$��5q�$��Center=�$
��Left=�$��False������ *OpenSumCommand+.��2 .��� .+��  K� ZIndex$
 1000��y��� *IsSumPopUpOpen+ �� 	Converter# [  ����  �� Color$ Black�� �� Opacity$ .5Q�.+��� $	��400��$	��220��$ 10q� �� CornerRadius$ 5�����	#FF7C7C7C$��1q�$��Center=�$��Center=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF1F1F1F�� � Offset$ 0Q�� $ 	#FF515151��$ 1Q�._�   WattRand.SumControl  $��Stretch=�$��Stretch=�  � DataContext  �� *ActiveSumControlViewModel+�  �� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $��20 � �� $��10 ��� $��* ��� $��10 �.+��� $��1��$��	0,10,0,10q�$��	Watt Rand��$��20(�! �� TextAlignment$! Center=�$
��Bold"�$��Center=�
��������� $��1��$��1��$
��Left=�" �� Orientation$" 
Horizontal=�$��10q�.+��� #��[ $
��Auto��$��35��$��	10,0,10,0q����� *AddElementCommand+.���� $ 10q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF1A1A1A��$ 0Q�� $ 	#FF2A2A2A��$ 1Q�._��� $" 
Horizontal=�$��15��.+��� $ AddIcon���� $��Aggiungi��
�������$��Center=�$
��Auto��$��5,0,0,0q��� #��[ $
��Auto��$��35��$��	10,0,10,0q����� *SortElementsCommand+.���� $ 10q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF1A1A1A��$ 0Q�� $ 	#FF2A2A2A��$ 1Q�._��� $" 
Horizontal=�$��15��.+��� $ SortIcon���� $��Ordina per data��
�������$��Center=�$
��Auto��$��5,0,0,0q��� $��1��
������ $��2��# �� AlternationCount$# 2��$��Stretch=�#��[ 
������ ���� *
Elements+ ��%C   (��       *SystemColors.ControlBrushKey+)�� $ Transparent������ " ��.���  � ��$ Stretch=���  �@�FocusVisualStyle Z� ��  � |� .  ��  � �� �� "	 ��.R��� $ ��Name$$ Border��$��5q�$ 5��._��� #��[ % �� Triggers% P�  �@��AlternationIndex$ 0��. ��� & �� 
TargetName$& Border�� � �� �	#3300CCD0P�  �@��AlternationIndex$ 1��. ��� $& Border�� � �� �	#33FFFFFF� $��3��$��1�� �� $��* ��� $
��Auto �.+��� $��0������ *	ErrorText+�� $��1��#��[ $
��Auto��$
��Auto��$��Right=����� *ExecuteCommand+.���� $ 	10,5,10,5q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF1A1A1A��$ 0Q�� $ 	#FF2A2A2A��$ 1Q�._��� $" 
Horizontal=�$��35��.+��� $ ExcelExport���� $��Esegui��
�������$��Center=�$
��Auto��$��5,0,0,0q�$��25(�$
��Bold"�