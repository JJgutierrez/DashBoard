   M S B A M L   `   `   `  ����$   Coding4Fun.Obd.InstrumentCluster7    1Coding4Fun.Obd.InstrumentCluster.Controls.Blinker   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          >�Name$  UserControl��5      ��5	      �� 5
       � 	Resources 5   	      
uxSB_Blink �� TargetProperty �� 
TargetName g� RepeatBehavior R� KeyTime  System.Windows.Visibility   Hidden R� Value   Visible��%�   &	        �� 5   
   .��5      T� $ (UIElement.Visibility)�6)   $ uxBorder��6\   $ Forever��6}   ..�5      i� $ 0:0:0.4��6#   # Z 65   i� 5      $ 0:0:0.8��6#   # Z 65   5      5      5   
   .R�5      �� 	 ��Name$	 uxBorder��6   ._�5      �� #��z��6   5      
 �� Triggers
 5   	   :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      5   	   5      