   M S B A M L   `   `   `  ����   MVVM_Template1$    MVVM_Template1.View.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��480��$	��640�� � WindowState$ 	Maximized=�.���  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto �.+�o� $��0��.@�m� $
��File��.@�m� $	��New�� m� Command ��  �� Path$ 
NewCommand�m� $
��Open�� �� $ OpenCommand�m� $
��Save�� �� $ SaveCommand�� $��1�� � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��Center=�$��Center=�$��0������ $ Image��� $��0��$��Bottom=�$
��Left=�$��16(�
���  ������ $ FrameNumberDisplay�� $��1�� �� $��* ��� $
��Auto �.+��� $��0��$��5q����� $ Events� �� View �� .P��� $��Action�� �� Width$	 120�� �� DisplayMemberBinding �� *Name+�� $��Object��$ 75�� �� *BoundaryName+�� $��Frame��$ 50�� �� *FrameNumber+�� $��1��	 �� Orientation$	 
Horizontal=�$��Center=�.+��� $��Export Raw Data������ $ ExportRawDataCommand��� $��Export interactions������ $ ExportInteractionsCommand��� $��Whisker Debug������ $ WhiskerDebugCommand��� $��2��$��Stretch=�
 � Minimum$
 0Q� �� TickFrequency$ 1Q�$��5q� � Maximum �� $ 
FrameCount�{��� $ SliderEnabled� � Value �� $ CurrentFrame� �� Mode$ TwoWay=�