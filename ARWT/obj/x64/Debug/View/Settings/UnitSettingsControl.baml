   M S B A M L   `   `   `  ����?  ;ARWT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ARWT.BehavioursARWT.Behaviours  5      <    6RobynsWhiskerTracker.View.Settings.UnitSettingsControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4
behavioursclr-namespace:ARWT.Behaviours     5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%�  '��       '�� o     '��     �� 5
   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�64   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5!   
   �� 5"      $��* �6   �� 5#      $��* �6   .+�5&   
   �� $��0��6   $��0��6   $��Unit Name: ��6-   �� 5'   
   $��0��6   $��1��6   $	��200��6O   ��6/   ��  �� Path$ 	UnitsName�{�6[   �� $ Enabled��� 5)   
   $��1��6   $��0��6   $��Unit length: ��6-   �� 5*   
   $��1��6   $��1��6   $	��200��6�   ��6/   �� $ UnitsDistance� �� Mode$ TwoWay=�,   &ARWT.Behaviours.DoubleTextBoxBehaviour   MVVMHasError 6`   �� $ UnitsDistanceHasError�{�6�   �� $ Enabled��� 5,   
   $��2��6   $��0��6   $��Pixel Distance: ��6-   �� 5-   
   $��2��6   $��1��6!   {�.  ��61   �� $ PixelDistance�6U   �� 5/   
   $��3��6   $��0��6   $��Units Per Pixel: ��6-   �� 50   
   $��3��6   $��1��6!   {�.  ��61   �� $ UnitsPerPixel�6U   �� 52   
   $��4��6   $��0��6"   $��2��62   $��Center=�6F   	 �� Orientation$	 
Horizontal=�6c   .+�53      �� $��Browse for unit video��6   $	��150��65   $��30��6A   $��5q�6M   ��6X   �� $ BrowseForUnitVideoCommand��� 54      $��Revert to default��6   $	��150��61   $��30��6=   $��5q�6I   ��6T   �� $ RevertToDefaultCommand�55      57      58      