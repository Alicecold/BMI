   M S B A M L   `   `   `  ���� >  :BMI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BMI.ViewModelBMI.ViewModel      BMI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     1	ViewModelclr-namespace:BMI.ViewModel       � Title$	  BMI�� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ NoResize=�$	��350��$	��160�� � DataContext    BMI.ViewModel.Presenter  .��� 
�������.+��� $	��Top=�$
��Left=�$��4q�.+��� $��Height (in centimeter)���� $	��100��$
��Left=����� *Height+ �� UpdateSourceTrigger$ PropertyChanged=��� $��Weight (in kilogram)���� $	��100��$
��Left=����� *Weight+$ PropertyChanged=��� $��	Calculate��$��0,4,4,0q�$	��100��$
��Left=����� *CalculateBMI+�� $��Result���� $	��100��$
��Left=����� *Result+$ PropertyChanged=��� $
��Left=�$��4q����� *
Analysis+$ PropertyChanged=����� *AnalysisCol+$ PropertyChanged=�