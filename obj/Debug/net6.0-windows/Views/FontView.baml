   M S B A M L   `   `   `  ����D  @Notepadcs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Notepadcs.ViewsNotepadcs.Views  5          Notepadcs.Views.FontView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Notepadcs.Views     5      .��5	      � ���#EEE  � ColumnDefinitions  5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��3* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0��6   $��
40 20 0 20q�6,    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $
��Font��6%   �� 5      $��1��6    �� AcceptsReturn$
 True��6b   ��6#   �� *
FontName+ �� UpdateSourceTrigger$ PropertyChanged=�6b   �� 5      -   5        $��AvailableFonts��5   #   $��2��6   $	��170��6�    �� SelectedItem 69   �� *
FontName+$ PropertyChanged=���6�   �� *FontFamilyNames+5      5       � 5!   
   $��1��6   $��0��6   $��
10 20 0 20q�6,    5"      �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    .+�5'      �� $��0��6   $��
Font style��6%   �� 5(      $��1��6   $
 True��6e   ��6#   �� *FontStyling+$ PropertyChanged=�6e   �� 5)      -   5        $��AvailableFontStyles��5)   #   $��2��6    6>   �� *FontStyling+$ PropertyChanged=�.@�5*      �� $��Normal��6   �� 5+      $��Italic��6   $��Italic$�6/   �� 5,      $
��Bold��6   $
��Bold"�6-   �� 5-      $��Bold Italic��6   $
��Bold"�64   $��Italic$�6F   5.      5/      � 50   
   $��2��6   $��0��6   $��10 20 40 20q�6,    51      �� 52      $
��auto �6    �� 53      $
��auto �6    �� 54      $
��auto �6    .+�56      �� $��0��6   $��	Font size��6%   �� 57      $��1��6   $
 True��6b   ��6#   �� *
FontSize+$ PropertyChanged=�6b   �� 58      -   5        $��AvailableFontSizes��58   #   $��2��6   $	��170��6�    6=   �� *
FontSize+$ PropertyChanged=���6�   �� *	FontSizes+��59      �� 5:       �� 
TargetType" ��6   .�5;      ��  �� Property � �� �� Value$ Stretch=�6G   5<      5>      5?      � 5@   
   $��1��6   $��2��6   $��1��63   $��
20 0 40 20q�6@    5A      �� 5B      $
��auto �6    �� 5C      $��* �6    .+�5E      �� $��0��6   $��Sample��6%   �� 5F      $��1��6   ���#FFF
���   �$��1q�6H   ._�5G      �� $��
AaBbCcYyZz��5H       �� TextAlignment$ Center=�5I      $��Center=�5J      ��5K      �� *
FontSize+$ PropertyChanged=���5L      �� *
FontWeight+$ PropertyChanged=���5M      �� *	FontStyle+$ PropertyChanged=���5N      �� *
FontName+$ PropertyChanged=�5O      5P      � 5R   
   $��2��6   $��1��6     5S      �� 5T      �� 5U      .+�5W      �� -   5        $��OKButton��5Y      $��0��5X      $��OK��5Z      $��
10 20 0 20q�5[      $��	10 5 10 5q�5\      $	��100��5]      ��5^      �� *	OkCommand+�� 5_      -   5        $��CancelButton��5a      $��1��5`      $��Cancel��5b      $��
0 20 20 20q�5c      $��	10 5 10 5q�5d      $	��100��5e      ��5f      �� *CancelCommand+5g      5h      5i      