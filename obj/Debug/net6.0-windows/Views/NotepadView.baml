   M S B A M L   `   `   `  ����D  @Notepadcs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Notepadcs.ViewsNotepadcs.Views  5      ;"clr-namespace:Notepadcs.ViewModelsNotepadcs.ViewModels  6:   !    Notepadcs.Views.NotepadView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Notepadcs.Views     5      9
viewmodels"clr-namespace:Notepadcs.ViewModels     6:     J� InputBindings  5	      �� 5
   
   
 �� Key$ S��6    �� 	Modifiers$
 Ctrlf�6    �� Command 6.   �� *SaveFileCommand+�� 5   
   $ S��6   $ 
Ctrl+Shiftf�6    64   �� *SaveFileAsCommand+�� 5   
   $ O��6   $
 Ctrlf�6    6.   �� *OpenFileCommand+�� 5   
   $ N��6   $
 Ctrlf�6    6.   �� *NewFileCommand+.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ]� $��0��6   $	��Top=�6!   .+�5      o� .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� InputGestureText$ Ctrl+N��6,    m� Command 6F   �� *NewFileCommand+m� 5      $
��Open��6   $ Ctrl+O��6-    6G   �� *OpenFileCommand+m� 5      $
��Save��6   $ Ctrl+S��6-    6G   �� *SaveFileCommand+m� 5      $��SaveAs��6   $ Ctrl+Shift+S��6/    6O   �� *SaveFileAsCommand+�� 5      m� 5      $
��Exit��6    6-   �� *ExitAppCommand+5      m� 5!      $
��Edit��6   .@�5"      m� $
��Undo��6   $ ApplicationCommands.Undo��6-   m� 5#      $
��Redo��6   $ ApplicationCommands.Redo��6-   m� 5$      $	��Cut��6   $ ApplicationCommands.Cut��6,   m� 5%      $
��Copy��6   $ ApplicationCommands.Copy��6-   m� 5&      $��Paste��6   $ ApplicationCommands.Paste��6.   m� 5'      $��Delete��6   $  ApplicationCommands.Delete��6/   5(      m� 5*      $��Format��6   .@�5+      m� -   5        $��WordWrapMenuItem��5+      $��	Word wrap��68    m� IsCheckable$
 True��6K    m� 	IsChecked 6^   �� *WordWrapBool+m� 5,      $
��Font��6    6-   �� *ToFontCommand+5-      m� 5/      $
��View��6   .@�50      m� $��	StatusBar��6   51      m� 53      $
��Help��6   54      55      56      �� 57   
   -   5        $��NotepadPage��58      $��1��59      	 �� AcceptsReturn$
	 True��5:      $��5 5 0 0q�5;      
 �� TextWrapping
 5<      �� *
WordWrap+ �� UpdateSourceTrigger$ PropertyChanged=���5=      �� *
FontSize+��5>      �� *
FontWeight+��5?      �� *
FontName+��5@      �� *	FontStyle+��5A      �� *Text+$ PropertyChanged=��� 5D   
   $��2��5E      $
��auto��5F      5H      5I      