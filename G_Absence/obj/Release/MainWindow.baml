   M S B A M L   `   `   `  ���� D  @G_Absence, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:G_Absence	G_Absence      G_Absence.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:G_Absence     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  
MainWindow��$	��800��$
��1300�� � WindowState$ 	Maximized=� � 	Resources    MenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius � ColumnDefinitions
	 � Tag
 �� Triggers P� Property P� Value  Storyboard1 �� TargetProperty �� 
TargetName R� KeyTime  System.Windows.Visibility   Visible R� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value�� %�  &	        7F�&	 �    �� " d�.���  � ��
 ���� ��  � ��
 �������  � ��$ Center=���  � ��$ 60����  � ��$ 17(���  � ��$ 	20,0,-2,0q���  � �� �� " d�.R��� $ 	10,0,0,10��#��z��#��z��._��  �� $��55 ��� .+�F� $��21��#��z	 #��z��8��  �� $��1��$
��Left=�$��Center=�#��z��
 P�  �@d�	IsChecked$
 TrueY�. ���  � �� �#EBEFF3��  � �� �#0184EF��  � ��$ SemiBold"��� .��T� $ (UIElement.Visibility)�$
 grid��..�i� $ 0:0:0.1��# Z U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ 	rectangle��.\�  $ 0:0:0.1��$ -60.8Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	rectangle��.\�  $ 0:0:0.1��$	 6.4Q�U� $ (UIElement.Opacity)�$ 
rectangle2��.\�  $ 0:0:0.1��$ 0Q�  $ 0:0:0.3��$ 1Q�U� $ (UIElement.Opacity)�$ 	textBlock��.\�  $ 0:0:0.1��$ 0Q�  $ 0:0:0.3��$ 1Q�U� $ (UIElement.Opacity)�$ path1��.\�  $ 0:0:0.1��$ 0Q�  $ 0:0:0.3��$ 1Q� � Triggers :�  :� RoutedEvent$ UIElement.MouseDown�� :� 
SourceName$ 	rectangle��.[��� -    ��Name$! Storyboard1_BeginStoryboard��#��[ :� $ UIElement.MouseDown��$ 
rectangle1��.[���  �� BeginStoryboardName$! Storyboard1_BeginStoryboard��.��� .+��  �� $	��240��$��* ��� $��4* �.+�� ���#0B132B � RowDefinitions �� $	��150 ��� .+��� $��65��$ ��.\Assets\YOUCODE_LOGO1.png���� $��Bottom=�$	��200��
��������� -    ��Name$ 	menuStack��$��1��$
��0,70q�.+�	� -    	�Name$ HomeBtn��#��[  $
��HOME�� 
 screen#	 [ 	� #��[  $��OPTIONS��  settings#	 [ 	� -   $ AddBtn��#��[  $��AJOUTER��  plus#	 [ $y�Hidden=�	� -   $ users��#��[  $��Utilisateurs�� 	 users#	 [ $y�Hidden=�� $��1�����#EBEFF3 �� $��70 ��� .+�� 
������� K� ZIndex$	 100��.+���  �� Orientation$ 
Horizontal=�$��Right=�$
��40,0q�.+�F�   bell#��[ ���#0B132B$��25��� $	 100��.+��� $��DemiBold"�$��Salah eddib��$��Center=����#0B132B$��18(�$��	40,0,30,0q�F� -    F�Name$
 path��  
arrow_down#��[ ���#0B132B$��20��$��Right=�$��Center=�� -    �Name$
 grid��$��40,50,0,-52q�$y�Hidden=�$	 100��.+��� -     ��Name$  
rectangle2��
�������$
��Left=�$
��60.6��$	��Top=�$��130.527��! �� RadiusY$! 7.627��" �� RadiusX$" 7.627���� -	   # ��Name$# 	textBlock��$��DemiBold"�$��30��$�� Logout��$��10,5,0,0q�$��Center=����#0B132B$��18(�F� -
   $ path1�� 
 logout#��[ ���#0B132B$��20��$��Right=�$��Center=�$��0,0,10,0q��� -   $  
rectangle1��
������ $
��Left=�$��30��$��	35,22,0,0q�$! 7.627��$" 7.627��$	��Top=�$��130.527���� -   $  	rectangle��
������ $
��Left=�$��30��$��	35,22,0,0q�$! 7.627��$" 7.627��$	��Top=�$��130.527��$ J� RenderTransformOrigin$$ 0.5,0.5&�z�V� .~��� �� �� T�  � -   %  �Name$% frame��$��1��&  � NavigationUIVisibility$& Hidden=�