   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	    ResourceMonitor    ResourceMonitor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	     � Title$  
MainWindow��5   	   $	��710��6   $	��750��6)   .��5      � ���#242424.+�5   
   �� .+�5      �� -   5         ��Name$ label1��5   i   
����� �$��Current CPU Usage��6&   $��30��6B   $
��Left=�6N   $	��Top=�6y   $	��121��6�    �� Left$ 68��6�   
 �� Top$	 269��6�   �� 5	      -   5        $ label2��5	   m   
����� �$��Current RAM Available��6&   $��30��6F   $
��Left=�6R   $	��Top=�6}   $	��143��6�   $ 68��6�   $	 602��6�   �� 5
      -   5        $ label3��5
   i   
����� �$��Average CPU Usage��6&   $��30��6B   $
��Left=�6N   $	��Top=�6y   $	��121��6�   $	 409��6�   $	 269��6�   �� 5      -   5        $ label4��5   m   
����� �$��Average RAM Available��6&   $��30��6F   $
��Left=�6R   $	��Top=�6}   $	��138��6�   $	 409��6�   $	 603��6�   �� 5      -   5        $��label6��5      $�� ��6   $
��Left=�6-   $	��Top=�6H   ���	#FFCFA7A7$ 68��6w   $	 297��6�   �� 5      -   5        $ label7��5      $�� ��6   $
��Left=�6/   $	��Top=�6J   ���	#FFCFA7A7$ 68��6y   $	 637��6�   �� 5      -   5        $��label8��5      $�� ��6   $
��Left=�6-   $	��Top=�6H   $��30��6`   ���	#FFCFA7A7$	 409��6�   $	 293��6�    J� RenderTransformOrigin$ 
0.6,-0.133&�6�   �� 5      -   5        $ label9��5      $�� ��6   $
��Left=�6/   $	��Top=�6J   $��30��6b   ���	#FFCFA7A7$	 409��6�   $	 633��6�   �� 5      $��Time (Seconds)��6   $
��Left=�6-   $	��Top=�6H   $	��157��6`   $	 262��6l   $	 561��6~   
����� �6�   �� 5      $��CPU (%)��6   $ 20��6&   $	 132��67   $ 0.5,0.5&�6H   
����� �$��11(�6z   $
��Thin"�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -89.419Q�6*   T� 5      5      5      �� 5      $��RAM (MB)��6   $ 17��6'   $	 456��68   $ 0.5,0.5&�6I   
����� �$��11(�6{   $
��Thin"�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       $ -89.419Q�6*   T� 5!      5"      5$      �� 5%      -	   5        $ label10��5%   f   $��CPU Usage above threshold��6   $	 550��68   $ 33��6J   $��30��6Z   ���	#FF2424246w   �� 5&      -
   5        $��slider1��5&        � Value$ 50Q�6   $	 590��6/   $	 269��6A   $	��131��6R    � Maximum$	 100Q�6^    �� AutoToolTipPlacement$ TopLeft=�6l   ���	#FF4608086�   �� 5'      -   5        $��slider2��5'   "   $
 2000Q�6   $	 590��61   $	 602��6C   $	��131��6T   $ 16000Q�6`   $ TopLeft=�6p   5)      >   8System.Windows.Controls.DataVisualization.Charting.Chart  5*   
   -   5        $��cpulineChart��5*   !   	   Title$	 CPU Usage History��65   
���i��$	��Top=�5+      $	��254��6-   $��0q�6:   $	��600��6N   
 � Cursor$

 None��6Z      Series. 5,      C   =System.Windows.Controls.DataVisualization.Charting.LineSeries  ?   9System.Windows.Controls.DataVisualization.Charting.Series   Title$ 	CPU Usage��6*   H   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6<      IndependentValuePath$	 Key��5-         IsSelectionEnabled . $��0q�5.   /      ItemsSource 5-   0   �� ��5/      
� 50       
� Center$ 0.075,0.015&�6*    
� GradientOrigin$ 	-0.1,-0.1&�6?    
� RadiusY$	 0.9Q�6Z    
� RadiusX$
 1.05Q�6h   .��51      �  � Color$ 	#FFB9D6F7��6'   � 52      $ 	#FF8624B4��6'    � Offset$ 1Q�69   53      55      56        57   
   -   5        $��ramlineChart��57   !   $	 RAM Availability History��65   
���i��$	��Top=�58      $	��254��6-   $��	0,322,0,0q�6:   $��0q�6M   $	��600��6a   . 59        $ 	RAM Avail��6*   $ Value��6<   $	 Key��5:       . $��0q�5;   /    5:   0   �� 5;   /   5<      �� 5=   
   $��Time (Seconds)��6   $
��Left=�6)   $��254,236,0,0q�6D   $	��Top=�6Y   $	��157��6q   
����� �6}   �� 5>   
   -   5        $ label11��5>   %   $��
Low Memory��6   $
��Left=�66   $��580,341,0,0q�6Q   $	��Top=�6f   ���	#FF2424246~   �� 5?   
   $��CPU Threshold (%)��6   $
��Left=�6,   $��590,244,0,0q�6G   $	��Top=�6\   $	��127��6t   
���i��6�   �� 5@   
   $��RAM Threshold (MB)��6   $
��Left=�6-   $��590,576,0,0q�6H   $	��Top=�6]   $	��127��6u   
���i��6�   5A      5B      