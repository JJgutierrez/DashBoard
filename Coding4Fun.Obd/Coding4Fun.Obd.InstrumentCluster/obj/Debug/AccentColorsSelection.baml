   M S B A M L   `   `   `  ����$   Coding4Fun.Obd.InstrumentCluster<    6Coding4Fun.Obd.InstrumentCluster.AccentColorsSelection   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          >�Name$  UserControl��5      .��5
      �� -   5         ��Name$ 
LayoutRoot��5
   	   
���   �'  !System.Windows.VisualStateManager   VisualStateGroups 5   
   %  System.Windows.VisualStateGroup  5      -   5        OpenCloseStates��   Transitions 5      %  System.Windows.VisualTransition  5         GeneratedDuration$ 0:0:0.3D�6'      GeneratedEasingFunction 5      .  (System.Windows.Media.Animation.CubicEase  5      7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ 	EaseInOut=�6(   5         States. 5         System.Windows.VisualState  -   5        Open��5        5      -   5        
Closed��   
Storyboard. 5      �� .��5      �� 	 �� TargetProperty$0	 *(Panel.Background).(SolidColorBrush.Color)�67   
 �� 
TargetName$
 
LayoutRoot��6~   .g�5      8  2System.Windows.Media.Animation.EasingColorKeyFrame   �� KeyTime$ 0��62    �� Value$ 	#00000000��6>   5      U� 5      $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�68   $
 uxInterface��6�   .\�5      9  3System.Windows.Media.Animation.EasingDoubleKeyFrame   O� KeyTime$ 0��63    O� Value$	 0.8Q�6?   5      U� 5      $V	 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�68   $
 uxInterface��6�   .\�5        $ 0��63   $	 0.8Q�6?   5      T� 5       $	 (UIElement.Visibility)�68   $
 
LayoutRoot��6k   ..�5!      i�  R� KeyTime$ 0��65   	  System.Windows.Visibility 	  Visible R� Value# Z 6A   5"      �� 5#      $"	 (UIElement.IsHitTestVisible)�69   $
 
LayoutRoot��6r   .p�5$      s�  �� KeyTime$ 0��66    �� Value .  6B   5%      U� 5&      $	 (UIElement.Opacity)�68   $
 uxInterface��6h   .\�5'        $ 0��60   $ 0Q�6<   5(      5)      5*      5+      ._�5.      � -   5         �Name$ uxInterface��5.   	    J� RenderTransformOrigin$ 0.5,0.5&�6   z�5/      V� 50      .~�51      ��  �� ScaleX$ 1Q�6    �� ScaleY$ 1Q�6!   �� 52      �� 53      T� 54      55       � RowDefinitions 57      �� 58      $��50 �6   �� 59       � ColumnDefinitions 5;      �� 5<      $	��110 �6   �� 5=      .+�5?      �� $��1��6   $��1��6   .+�5@      ��  �� Orientation$ 
Horizontal=�6   $��	-64,0,0,0q�6*   .+�5A      �� -   5         ��Name$ uxClose��5A         ButtonStyle_Back#���   6   $
��Left=�6J   $	��Top=�6e   $��	0,20,24,0q�6}   $ 0.5,0.5&�6�   �� 5B      $
��Wrap=�6   $��Segoe UI Light)�6%   $��73.333(�6A   
�������$��
0,-20,0,87q�6f   $
��Left=�6z   $	��Top=�6�   �� 6�   $�Accent Color��6�   6�   5C      �� 5D      $ 
Horizontal=�6     ColorTileRowMargin#���  6*   .+�5E      	� -   5         	�Name$ uxThemeColor_Green��5E      $��green��6/     ThemeColor_Green#���  6?    ' #RadioButtonStyle_ColorSelectionTile#���  6o   	� 5F      -	   5        $ uxThemeColor_Red��5F      $	��red��6-     ThemeColor_Red#���  6;   #���  6i   	� 5G      -
   5        $ uxThemeColor_Blue��5G      $
��blue��6.     ThemeColor_Blue#���  6=   #���  6l    d� 	IsChecked$
 TrueY�6�   	� 5H      -   5        $ uxThemeColor_Yellow��5H      $��yellow��60     ThemeColor_Yellow#���  6A   #���  6r   	� 5I      -   5        $ uxThemeColor_Pink��5I      $
��pink��6.     ThemeColor_Pink#���  6=   #���  6l   	� 5J      -   5        $ uxThemeColor_Brown��5J      $��brown��6/     ThemeColor_brown#���  6?   #���  6o   	� 5K      -   5        $ uxThemeColor_Lime��5K      $
��lime��6.    	 ThemeColor_Lime#��� 	 6=   #���  6l   	� 5L      -   5        $ uxThemeColor_Teal��5L      $
��teal��6.    
 ThemeColor_Teal#��� 
 6=   #���  6l   	� 5M      -   5        $ uxThemeColor_Purple��5M      $��purple��60     ThemeColor_Purple#���  6A   #���  6r   	� 5N      -   5        $ uxThemeColor_Magenta��5N      $��magenta��61     ThemeColor_Magenta#���  6C   #���  6u   5O      5P      5Q      5S      5T      