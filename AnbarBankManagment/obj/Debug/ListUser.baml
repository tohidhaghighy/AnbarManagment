   M S B A M L   `   `   `  ����M  IAnbarBankManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnbarBankManagmentAnbarBankManagment  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	   !    AnbarBankManagment.ListUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AnbarBankManagment     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	   -   5          � Title$   لیست دستگاه ها��5	   	   $	��500��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�    � Triggers 5
      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:03D�6    �� TargetProperty$ Opacity�61   .��5      W� 	 W� From$	 0X�6&   	
 W� To$
 1X�6/   5      5      5      .��5      � .+�5   
   �� 
�������$
��Left=�6!   $	��480��6<   $��	10,10,0,0q�6I   
���   �$	��Top=�6k   $	��780��6�    �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   �� 5   
   $
��Left=�6   $��img/Background.png��6+   $	��429��6G   $��	10,61,0,0q�6T   $	��Top=�6g   $	��780��6   �� 5   
   $
��Left=�6   $��41��6/   $��
327,52,0,0q�6;   $ 10��6O   $ 10��6\   ���	#FF4D82B1$	��Top=�6|   $	��185��6�   ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      �  � Color$ 	#FFEDF8FF��6#    � Offset$ 1Q�65   � 5#      $ White��6#   5$      5&      �� 5'   
   -   5        $��Header��5'   �   $
��Left=�6   $��51��6/   $��	10,10,0,0q�6;   $ 10��6N   $ 10��6[   ���	#FFB1B1B1$	��Top=�6{   $	��780��6�   ��5)      �� 5*       �� ImageSource$ img/HeaderBack.png��6   5.      �� 5/   
   -   5        $��btnback��5/      $
��Left=�6   $��img/closeicon.png��6:    J� Opacity$	 0.5Q�6U   $��11��6c   $��	57,33,0,0q�6o   $	��Top=�6�   $��13��6�    � Cursor$
 Hand��6�   �� 50   
   $(��"دستگاه های دریافتی��6   $
��Left=�6-   $��
594,19,0,0q�6H   $	��Top=�6\   $	��134��6t   $��B Yekan)�6�   $��16(�6�   �� 51   
   $
��Left=�6   $��35��6/   $��
24,104,0,0q�6;   $ 15��6O   $ 15��6\   ���	#FFB7B7B7$	��Top=�6|   $	��753��6�   ��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�67   .��54      � $ 	#FFEFEFEF��6#   $ 1Q�65   � 55      $ White��6#   56      58      �� 59   
   -   5        $��
btnadduser��59      $
��Left=�6&   $
 Hand��6A   $��35��6O   $��608,104,0,0q�6[   ���	#FFB7B7B7$	��Top=�6�   $	��100��6�   ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ 	#FFEFEFEF��6#   $ 1Q�65   � 5=      $ White��6#   5>      5@      �� 5A   
   $��جدید��6   $
��Left=�6   $
 Hand��6:   $��632,109,0,0q�6H   $	��Top=�6]    J� RenderTransformOrigin$ 3.121,0.596&�6u   $��36��6�   �� 5B   
   $
��Left=�6   $
 Hand��6+   $��img/add-icon.png��69   $��15��6S   $��674,116,0,0q�6_   $	��Top=�6t   $��17��6�   �� 5C   
   $%�� : تعداد کاربر ها  ��6   $
��Left=�6.   $��
401,61,0,0q�6I   $	��Top=�6]   �� 5D   
   $��120000  ��6   $
��Left=�6#   $��
351,62,0,0q�6>   $	��Top=�6R   &   System.Windows.Controls.DataGrid  5F   
   -   5        $��userlist��5F      $
��Left=�6#   $��RightToLeft=�6>   $	��333��6Z   $��
24,144,0,0q�6g   $	��Top=�6{   $	��753��6�   ��5G      �� 5H      $ 0.5,1&�6&   $ 0.5,0&�67   .��5I      � $ 	#FFE6EEE3��6#   $ 0Q�65   � 5J      $ 	#FF9BF182��6#   $ 1Q�65   � 5K      $ 	#99C7FBB7��6#   $ 0.909Q�65   5L         Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ 
شماره��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Id+6K     5P      $ نام��6%   $	 200 6K    62   �� *Name+6K     5Q      $ نام کاربری��6%   $	 200 6V    69   �� *
Username+6V     5R      $ 
پسورد��6%   $	 200 6Q    64   �� *
Password+6Q   5T      5X      5Y      