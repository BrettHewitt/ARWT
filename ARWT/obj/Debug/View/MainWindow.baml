   M S B A M L   `   `   `  ����  ARWT    ARWT.View.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��640��6)    � WindowState$ 	Maximized=�65   .��5      �  � RowDefinitions 5   
   �� 5   
   $
��Auto �6   �� 5   
   $��* �6   �� 5	   
   $
��Auto �6   �� 5
   
   $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� Command 6(   ��  �� Path$ 
NewCommand�m� 5      $
��Open��6    6)   �� $ OpenCommand�m� 5      $
��Save��6    6)   �� $ SaveCommand�m� 5      $��Batch Process��6    62   �� $ BatchProcessCommand�5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��Center=�61   $��0��6L   ��6\   �� $ Image��� 5      $��0��6A   $��Bottom=�6Q   $
��Left=�6l   $��16(�6�   
���  ����6   �� $ FrameNumberDisplay�6�   � 5      $��1��6    5       �� 5!      $��* �6$   �� 5"      $
��Auto �6$   .+�5%      �� $��0��6?   $��5q�6L   ��6   �� $ Events� �� View 5&      �� 5'      .P�5(      �� $��Action��6-    �� Width$	 120��6=    �� DisplayMemberBinding 6I   �� *Name+�� 5)      $��Object��6-   $ 75��6=    6H   �� *BoundaryName+�� 5*      $��Frame��6-   $ 50��6<    6G   �� *FrameNumber+5+      5-      �� 5.      $��1��6   	 �� Orientation$	 
Horizontal=�6*   $��Center=�6C   .+�5/      �� $��Export Raw Data��6   ��67   �� $ ExportRawDataCommand��� 50      $��Export interactions��6   ��6;   �� $ ExportInteractionsCommand��� 51      $��Whisker Debug��6   ��65   �� $ WhiskerDebugCommand�52      53      54      �� 56   
   $��2��6   $��Stretch=�6   
 � Minimum$
 0Q�6<    �� TickFrequency$ 1Q�6l   $��5q�6�    � Maximum 6H   �� $ 
FrameCount�{�6~   �� $ SliderEnabled� � Value 6�   �� $ CurrentFrame� �� Mode$ TwoWay=�6�   �� 58   
   $��3��6   $	��400��6(   ��65   �� $ ContentToDisplay�59      5:      