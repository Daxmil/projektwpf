   M S B A M L   `   `   `  ����  DawidNowak3tc    DawidNowak3tc.TaskWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Zadanie��5   	   $	��300��6   $	��400��6&    � DataContext 5   	   ��  �� RelativeSource �� *Self+ �� Path$ Zadanie�.��5      �� $��10q�6   .+�5   
   �� -   5         ��Name$ Nazwa��5      Nazwa zadania:63   �� 5	   
   -   5        $��NazwaZadaniaTextBox��5	      $��0,0,0,10q�5      ��5
      �� *Nazwa+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   -   5        $
 Opis��5      Opis zadania:61   �� 5   
   -   5        $��OpisZadaniaTextBox��5      $��0,0,0,10q�5       �� AcceptsReturn$
 True��6$   $	��100��69   ��5      �� *Opis+$ TwoWay=�$ PropertyChanged=�5   9   �� 5   
   -   5        $��CzyWykonaneCheckBox��5      $��Wykonane��5      $��0,0,0,10q�5       d� 	IsChecked 5      �� *CzyWykonane+$ TwoWay=�$ PropertyChanged=�5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   $��Right=�6.   .+�5      �� -   5        
 ��Name$
 Zapisz��5   W   $��Zapisz��6   $��75��6A   $��5q�6L   6W   �� 5      -   5        $
 Anuluj��5   W   $��Anuluj��6   $��75��6A   $��5q�6L   6W   5      5      5      