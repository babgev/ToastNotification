   M S B A M L   `   `   `  ����D  @ToastThis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToastThis	ToastThis  5   	       ToastThis.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ToastThis     5   	   
���   �  � Title$  Toast Notification��5	   	   $	��150��6$   $	��285��61    � DataContext 5
   	   �� *Main+   Locator �� Source# [  .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��5      $��Right=�5      .+�5      �� -   5         ��Name$ btnOne��5      $��Failed��5      $��Right=�5      $��Center=�5       �� 	IsDefault . 
���  ��$��30��5      $
��10,1q�5       $
��Bold"�5!      $��75��5"      $��0,0,10,0q�5#      ��5      �� *OnErrorClicked+5#      �� 5$      -   5        $ btnTwo��5$      $��Warning��5%      $��Right=�5&      $��Center=�5'       . 
��� ���$��30��5+      $
��10,1q�5,      $
��Bold"�5-      $��75��5.      $��0,0,10,0q�5/      
 � Tag$	 ��50      ��5)      �� *OnWarningClicked+50      �� 51      -   5        $ btnThree��51      $��Success��52      $��Right=�53      $��Center=�54      
������
���   �$
��Bold"�58      $��30��59      $
��10,1q�5:      $��75��5;      ��55      �� *OnSuccessClicked+5;      5<      5=      5>      