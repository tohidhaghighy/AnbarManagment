   M S B A M L   `   `   `  ����M  IAnbarBankManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnbarBankManagmentAnbarBankManagment  5   	        AnbarBankManagment.AddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AnbarBankManagment     5   	   -   5          � Title$  دستگاه جدید��5   	   $	��270��6    � WindowStartupLocation$ CenterScreen=�6*   $	��470��6O    � AllowsTransparency . 
������  � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�    � Icon$ img/anbar.png��6�    � Triggers 5	      :� 5
   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:03D�6   	 �� TargetProperty$	 Opacity�61   .��5      W� 
 W� From$
 0X�6&   	 W� To$ 1X�6/   5      5      5      .��5      � .+�5   
   �� 
�������$
��Left=�6!   $	��380��6<   $��	10,10,0,0q�6I    �� RadiusY$ 10��6\    �� RadiusX$ 10��6i   ���	#FFBCBCBC$	��Top=�6�   $	��450��6�   �� 5   
   $
��Left=�6    J� Opacity$	 0.3Q�6+   $��img/back2.png��69   $	��175��6P   $��	10,56,0,0q�6]   $	��Top=�6p   $	��450��6�   �� 5   
   -   5        $
��Left=�5      $��46��6/   $��	10,10,0,0q�6;   $ 20��6N   $ 10��6[   ���	#FFC7C7C7$	��Top=�6{   $	��450��6�   ��5       �� 5!       �� ImageSource$ img/header2.png��6   5$      �� 5%   
   -   5        $��btnback��5%      $
��Left=�6   $��11��6:    � Cursor$
 Hand��6F   $��img/closeicon.png��6T   $	 0.5Q�6o   $��	53,30,0,0q�6}   $	��Top=�6�   $��13��6�   6�   �� 5&   
   $��افزودن کاربر��6   $
��Left=�6'   $��
317,16,0,0q�6B   $	��Top=�6V   $��	B Nazanin)�6n   $��14(�6�   $
��Bold"�6�   �� 5'   
   -   5        ���	#FFF4F4F4$
��Left=�5'   %   $��56��6@   $��	9,211,0,0q�6L   $ 10��6_   $ 10��6l   ���	#FFC2C2C2$	��Top=�6�   $	��450��6�   6�   �� 5(   
   -   5        $��
btnadduser��5(      $��ثبت��6#    �� 	IsDefault . $��4��6B   $
��Left=�6O   $��345,229,0,0q�6j   $	��Top=�6   $��75��6�   $��25��6�   ���	#FFC0C02D
�������6�   �� 5)   
   $��انصراف��6    �� IsCancel . $��5��62   $
��Left=�6?   $��265,229,0,0q�6Z   $	��Top=�6o   $��75��6�   $��25��6�   �� 5*   
   $*��$ نام و نام خانوادگی *��6   $
��Left=�60   $��RightToLeft=�6K   $��
330,84,0,0q�6g   $	��Top=�6{   $��	B Nazanin)�6�   $��14(�6�   $
��Bold"�6�   �� 5+   
   $��* نام کاربری ��6   $
��Left=�6(   $��330,115,0,0q�6C   $	��Top=�6X   $��	B Nazanin)�6p   $��14(�6�   $
��Bold"�6�   �� 5,   
   $��* پسورد ��6   $
��Left=�6#   $��330,146,0,0q�6>   $	��Top=�6S   $��	B Nazanin)�6k   $��14(�6�   $
��Bold"�6�   �� 5-   
   -   5        $��txtname��5-   D   $
��Left=�6    �� TextAlignment$ Center=�6-   $��0��6S   $��RightToLeft=�6`   $��23��6|   $��
119,86,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��156��6�   �� 5.   
   -   5        $��txtusername��5.   D   $
��Left=�6   $ Center=�6-   $��1��6W   $��RightToLeft=�6d   $��23��6�   $��119,118,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��156��6�   �� 5/   
   -   5        $��txtpassword��5/   D   $
��Left=�6   $ Center=�6-   $��2��6W   $��RightToLeft=�6d   $��23��6�   $��119,149,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��156��6�   �� 50   
   $A��;موارد ستاره دار نباید خالی بماند��6   $
��Left=�6;   $��178,182,0,0q�6V   $	��Top=�6k   $��	B Nazanin)�6�   ���	#FFFF1414$��14(�6�   $
��Bold"�6�   53      54      