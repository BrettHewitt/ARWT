   M S B A M L   `   `   `  ����?  ;ARWT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ARWT.BehavioursARWT.Behaviours  5   	       ARWT.View.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4
behavioursclr-namespace:ARWT.Behaviours     5   	   $	��480��5   C   $	��640��6P     � WindowState$  	Maximized=�6\    � Title 6	   ��  �� Path$ 	TitleName� �� StringFormat$ ARWT {0}��+   %ARWT.Behaviours.WindowClosingBehavior   Close 5   	   �� $ Close� �� Mode$ TwoWay=�   Closing 5   	   �� $ ClosingCommand�.��5      �  � RowDefinitions 5	   
   �� 5
   
   $
��Auto �6   �� 5   
   $��* �6   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� Command 6(   �� $ 
NewCommand�m� 5      $
��Open��6    6)   �� $ OpenCommand�m� 5      $
��Save��6    6)   �� $ SaveCommand�m� 5      $��Batch Process��6    62   �� $ BatchProcessCommand�5      5      � 5   
   $��1��6   	 � ColumnDefinitions	 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��Center=�61   $��0��6L   ��6\   �� $ Image��� 5       $��0��6A   $��Bottom=�6Q   $
��Left=�6l   $��16(�6�   
���  ����6   �� $ FrameNumberDisplay�6�   � 5"      $��1��6    5#      �� 5$      $��* �6$   �� 5%      $
��Auto �6$   .+�5(      �� $��0��6?   $��5q�6L   ��6   �� $ Events�
 �� View
 5)      �� 5*      .P�5+      �� $��Action��6-    �� Width$	 120��6=    �� DisplayMemberBinding 6I   �� *Name+�� 5,      $��Object��6-   $ 75��6=    6H   �� *BoundaryName+�� 5-      $��Frame��6-   $ 50��6<    6G   �� *FrameNumber+5.      50      �� 51      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   .+�52      �� $��Export Raw Data��6   ��67   �� $ ExportRawDataCommand��� 53      $��Export interactions��6   ��6;   �� $ ExportInteractionsCommand��� 55      $��	Show Data��6   ��61   �� $ ShowDataCommand�56      57      58      �� 5:   
   $��2��6   $��Stretch=�6    � Minimum$ 0Q�6<    �� TickFrequency$ 1Q�6l   $��5q�6�    � Maximum 6H   �� $ 
FrameCount�{�6~   �� $ SliderEnabled� � Value 6�   �� $ CurrentFrame�$ TwoWay=�6�   5=      5>      