   M S B A M L   `   `   `  ����M  IAnbarBankManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnbarBankManagmentAnbarBankManagment  5   	       AnbarBankManagment.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AnbarBankManagment     5   	   -   5          � Title$  Login��5   	   $��260.105��6    � WindowStartupLocation$ CenterScreen=�6(   $	��470��6M    � AllowsTransparency . 
������  � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�    � Triggers 5	      :� 5
   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:03D�6    �� TargetProperty$ Opacity�61   .��5      W� 	 W� From$	 0X�6&   	
 W� To$
 1X�6/   5      5      5      .��5      � .+�5   
   �� 
�������$
��Left=�6!   $	��249��6<   $��	10,10,0,0q�6I    �� RadiusY$ 10��6\    �� RadiusX$ 10��6i   ���	#FFBCBCBC$	��Top=�6�   $	��450��6�   �� 5   
   $
��Left=�6    J� Opacity$	 0.3Q�6+   $��img/back2.png��69   $	��191��6P   $��	10,56,0,0q�6]   $	��Top=�6p   $	��450��6�   �� 5   
   -   5        $
��Left=�5      $��60��6/   $��	10,10,0,0q�6;   $ 10��6N   $ 10��6[   ���	#FFC7C7C7$	��Top=�6{   $	��450��6�   ��5       �� 5!       �� ImageSource$ img/header2.png��6   5$      �� 5%   
   -   5        $��btnback��5%      $
��Left=�6   $��23��6:    � Cursor$
 Hand��6F   $��img/closeicon.png��6T   $	 0.5Q�6o   $��	45,25,0,0q�6}   $	��Top=�6�   $��21��6�   6�   �� 5&   
   $��صفحه ورود��6   $
��Left=�6$   $��
323,25,0,0q�6?   $	��Top=�6S   $��B Yekan)�6k   $��14(�6�   �� 5'   
   ���	#FFF4F4F4$
��Left=�6%   $��48��6@   $��
10,211,0,0q�6L   $ 10��6`   $ 10��6m   ���	#FFC2C2C2$	��Top=�6�   $	��450��6�   �� 5(   
   -   5        $��LoginBtn��5(   �   $��ورود��6    �� 	IsDefault . $
��Left=�61   $��235,217,0,0q�6L   $	��Top=�6a   $��90��6y   $��35��6�   ���	#FFC0C02D
�������$��16(�6�   $��	B nazanin)�6�   $��3��6  �� 5)   
   -   5        $��
BtnEnseraf��5)   "   $��انصراف��6   $��4��6M    �� IsCancel . $
��Left=�6j   $��131,217,0,0q�6�   $	��Top=�6�   $��90��6�   $��35��6�   $��16(�6�   $��	B nazanin)�6�   �� 5*   
   $��نام کاربری:��6   $��16(�6&   $��	B nazanin)�64   $
��Left=�6K   $��RightToLeft=�6f   $��330,109,0,0q�6�   $	��Top=�6�   $
��Bold"�6�   �� 5+   
   $��رمز ورود:��6   $��16(�6$   $��	B nazanin)�62   $
��Left=�6I   $��RightToLeft=�6d   $��330,151,0,0q�6�   $	��Top=�6�   $
��Bold"�6�   �� 5,   
   -   5        $��txtUser��5,   -   $
��Left=�6   $��1��6<   $��RightToLeft=�6I   $��35��6e   $��119,108,0,0q�6q    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��187��6�   $��18(�6�    �� TextAlignment$ Center=�6�   G� 5-   
   -   5        $��txtpass��5-   �   $��RightToLeft=�6   $��35��62   $��2��6>   $��119,155,164,70q�6K   $	��187��6c   $��18(�6o   $��Center=�6}   6�   50      51      