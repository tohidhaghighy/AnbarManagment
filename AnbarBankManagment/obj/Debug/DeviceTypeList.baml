   M S B A M L   `   `   `  ����M  IAnbarBankManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnbarBankManagmentAnbarBankManagment  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	   '    !AnbarBankManagment.DeviceTypeList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AnbarBankManagment     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	   -   5          � Title$   لیست دستگاه ها��5	   	   $	��500��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
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
��Left=�6   $��img/Background.png��6+   $	��429��6G   $��	10,62,0,0q�6T   $	��Top=�6g   $	��780��6   �� 5   
   $
��Left=�6   $��41��6/   $��
327,52,0,0q�6;   $ 10��6O   $ 10��6\   ���	#FF4D82B1$	��Top=�6|   $	��185��6�   ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      �  � Color$ 	#FFEDF8FF��6#    � Offset$ 1Q�65   � 5#      $ White��6#   5$      5&      �� 5'   
   -   5        $��Header��5'   �   $
��Left=�6   $��51��6/   $��	10,10,0,0q�6;   $ 10��6N   $ 10��6[   ���	#FFB1B1B1$	��Top=�6{   $	��780��6�   ��5)      �� 5*       �� ImageSource$ img/HeaderBack.png��6   5.      �� 5/   
   -   5        $��btnback��5/      $
��Left=�6   $��img/closeicon.png��6:    J� Opacity$	 0.5Q�6U   $��11��6c   $��	57,33,0,0q�6o   $	��Top=�6�   $��13��6�    � Cursor$
 Hand��6�   �� 50   
   $��نوع دستگاه ها��6   $
��Left=�6(   $��
594,19,0,0q�6C   $	��Top=�6W   $	��134��6o   $��B Yekan)�6{   $��16(�6�   �� 51   
   $
��Left=�6   $��35��6/   $��
24,104,0,0q�6;   $ 15��6O   $ 15��6\   ���	#FFB7B7B7$	��Top=�6|   $	��753��6�   ��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�67   .��54      � $ 	#FFEFEFEF��6#   $ 1Q�65   � 55      $ White��6#   56      58      �� 59   
   -   5        $��btnadddevicetype��59      $
��Left=�6,   $
 Hand��6G   $��35��6U   $��635,104,0,0q�6a   ���	#FFB7B7B7$	��Top=�6�   $��93��6�   ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ 	#FFEFEFEF��6#   $ 1Q�65   � 5=      $ White��6#   5>      5@      �� 5A   
   $��جدید��6   $
��Left=�6   $
 Hand��6:   $��655,108,0,0q�6H   $	��Top=�6]   �� 5B   
   $
��Left=�6   $
 Hand��6+   $��img/add-icon.png��69   $��15��6S   $��693,115,0,0q�6_   $	��Top=�6t   $��15��6�   �� 5C   
   $)��# : تعداد نوع دستگاه  ��6   $
��Left=�60   $��
401,61,0,0q�6K   $	��Top=�6_   �� 5D   
   $��120000  ��6   $
��Left=�6#   $��
351,62,0,0q�6>   $	��Top=�6R   &   System.Windows.Controls.DataGrid  5F   
   -   5        $��devicetypelist��5F      $
��Left=�6)   $��RightToLeft=�6D   $	��333��6`   $��
24,144,0,0q�6m   $	��Top=�6�   $	��753��6�   ��5G      �� 5H      $ 0.5,1&�6&   $ 0.5,0&�67   .��5I      � $ 	#FFE6EEE3��6#   $ 0Q�65   � 5J      $ 	#FF9BF182��6#   $ 1Q�65   � 5K      $ 	#99C7FBB7��6#   $ 0.909Q�65   5L         Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ 
شماره��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *ID+6K     5P      $ نام��6%   $	 200 6K    62   �� *Name+6K   5R      5V      5W      