   M S B A M L   `   `   `  ���� D  @G_Absence, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:G_Absence	G_Absence      G_Absence.login   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:G_Absence     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  login��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources    rect �� TargetProperty �� 
TargetName g� RepeatBehavior9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value
 R� KeyTime  System.Windows.Visibility   Hidden R� Value   Visible  Storyboard1  Storyboard2��%%
  &	        &	 c    &	 h    �� .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�$ image��$ Forever��.\�  $ 0��$	 0Q�  $ 0:0:1.9��$	 175.298Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image1��$ Forever��.\�  $ 0��$	 0Q�  $ 0:0:0.95��$
	 -0.8Q�  $ 0:0:1.9��$	 0Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ image1��$ Forever��.\�  $ 0��$	 0Q�  $ 0:0:0.95��$	 -32.8Q�  $ 0:0:1.9��$	 0Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image2��$ Forever��.\�  $ 0��$	 0Q�  $ 0:0:0.41��$	 -58.4Q�  $ 0:0:0.8��$	 0Q�  $ 0:0:1.1��$	 0Q�  $ 0:0:1.4��$	 -58.4Q�  $ 0:0:1.9��$	 0Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ image2��$ Forever��.\�  $ 0��$	 0Q�  $ 0:0:0.41��$	 -20.8Q�  $ 0:0:0.8��$	 0Q�  $ 0:0:1.1��$	 0Q�  $ 0:0:1.4��$	 -20.8Q�  $ 0:0:1.9��$	 0Q�T� $ (UIElement.Visibility)�$ 	textBlock��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ packIcon��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ txtUserName��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ 	packIcon1��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ txtPassword��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ BtnLogin��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z T� $ (UIElement.Visibility)�$ BtnExit��..�i� $
 0:0:2.3��# Z i� $
 0:0:2.6��# Z �� �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image3��.\�  $ 0:0:1.9��$	 0Q�  $ 0:0:2.5��$	 -165.6Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image2��.\�  $ 0:0:1.9��$	 0Q�  $ 0:0:2.5��$	 -165.6Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image1��.\�  $ 0:0:1.9��$	 0Q�  $ 0:0:2.5��$	 -165.6Q�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ image��.\�  $ 0:0:1.9��$	 0Q�  $ 0:0:2.5��$	 -165.6Q� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� #��[  �� #��[ �� #��[ .��� -   ����  �� EndPoint$ 0.9,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.1,0&�.���  � Color$ Black��� $ 	#FF0F1C73�� � Offset$ 1Q�� $ 	#FF17415A��$ 0.775Q�.+��� -   $	��390��$	��Top=� �� CornerRadius$ 	0 0 180 0�����	#FF0F2351�� -    ��Name$ image3��$��Assets/login-man.png��$��227.092,0,193.308,81.985q�$
��Auto��$	��286��$��Bottom=� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� �� -   $ image2��$��Assets/blue.png��$��209.092,0,494.495,116.545q�$
��Auto��$��72.64��$��Bottom=�$ 0.5,0.5&�z�V� .~��� �� �� T� �� -   $ image1��$��Assets/pink.png��$��458.692,0,228.619,308.003q�$
��Auto��$��84.903��$��Bottom=�$ 0.5,0.5&�z�V� .~��� �� �� T� �� $��Assets/YOUCODE_LOGO1.png ��$	��100��$��25.069,0,674.931,10q�$��Bottom=��� -   $ image��$��Assets/rect.png��$��209.092,0,263.666,81.985q�$
��Auto��$��246.553��$��Bottom=�$ 0.5,0.5&�z�V� .~��� �� �� T� �� -    ��Name$ 	textBlock��$��Users Login��$"��526.482,95.894,110.231,316.6q�
������� �� TextAlignment$ Center=�$��26(�$��Corbel)�$y�Hidden=��� -   $ 	incorrect��$�� ��
���  ��$ Center=�$y�Hidden=�'  !MaterialDesignThemes.Wpf.PackIcon  -	     Name$ packIcon��   Kind$
 User=�$��25��$��25��
�������$��485.9,173.141,0,0q�$y�Hidden=��� -
    ��Name$ txtUserName��$#��526.482,167.847,86.68,256.659q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Email��
�������
������� �� 
CaretBrush
 ����� �� SelectionBrush
 �����$y�Hidden=�  -   $ 	packIcon1��$
 Lock=�$��25��$��25��
�������$ 0.492,0.528&�$��485.9,230.064,0,0q�$y�Hidden=�G� -     G�Name$  txtPassword��$"��526.482,222.45,86.68,194.936q�$ 
**********��
�������
�������! G� 
CaretBrush
! �����" G� SelectionBrush
" �����$y�Hidden=��� -   # ��Name$# BtnLogin��$
��100 ��$��40��  MaterialDesignRaisedButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist$   CornerRadius$$ 10��$��2q����	#FF283DB4
�������% � ToolTip$% login��$��Login��$%��563.258,298.015,136.741,111.985q�$y�Hidden=����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF0A0E2C��� $ 	#FF0F1C73��$ 1Q��� -   $# BtnExit��$��713.6,35.493,30.4,358.506q� & "MaterialDesignFloatingActionButton#��[ $% Close��$y�Hidden=���Z� .��  $ Close=�
�������$��30��$��30��$��	11,11,0,0q�