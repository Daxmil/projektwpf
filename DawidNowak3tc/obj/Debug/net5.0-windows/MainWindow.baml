   M S B A M L   `   `   `  ����  DawidNowak3tc    DawidNowak3tc.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Zarządzanie Zadaniami��5   	   $	��450��6'   $	��800��64   .��5      ]� -   5         ]�Name$ MainDockPanel��5      .+�5   
   o� -   5        $
��Menu��5   $   $	��Top=�6   .@�5      m� -   5         m�Name$
 Plik��5   %   $
��Plik��6   .@�5      m� -   5        $ Menu1��5   @   $��Zrób zrzut��6   6@   m� 5	      -   5        $ Menu2��5	   H   $��
Ustawienia��6   6H   �� 5
      m� 5      -   5        $ Menu3��5   F   $��Zakończ��6   6F   5      5      c� 5   
   -   5        $
��Tool��5   '   $	��Top=�6   .@�5      �� -   5         ��Name$ Dodaj��5   G   $��Dodaj Zadanie��6   6G   �� 5      -	   5        $ Reset��5   9   $��Reset��6   69   5      �� 5   
   -
   5        $��	StatusBar��5   ,   $��Bottom=�6   .@�5      �� -   5        $��
StatusText��5      $��Gotowy��6*   5      � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� -   5        $��
ListaZadan��5      $��0��6)   ��66   �� *	Zadania+ �� View 5      �� 5       .P�5!      �� $��Zadanie��6)    �� Width$	 200��6a   -   5        Zadanie�� �� DisplayMemberBinding 5!   :   �� *Nazwa+6m   �� 5"      $
��Opis��6)   $	 400��6]   -   5        Opis�� 5"   7   �� *Opis+6i   �� 5#      $��Wykonane��6)   $	 100��6k   -   5        Wykonane�� 5#   ;   �� *EmojiWykonania+6w   5$      5&      �� 5(       �� Orientation$ 
Horizontal=�6   $��1��62   .+�5)      �� -   5        $ Edytuj��5)   Y   $��Edytuj Zadanie��6   $��5q�6N   6Y   �� 5*      -   5        $
 Usun��5*   U   $��Usuń Zadanie��6   $��5q�6J   6U   5+      5,      5-      5.      