   M S B A M L   `   `   `  ����N  JWpf_CompteBancaire2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Wpf_CompteBancaire2.Windows_Views!Wpf_CompteBancaire2.Windows_Views  5   	   :    4Wpf_CompteBancaire2.Windows_Views.Menu_Client_Window   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Wpf_CompteBancaire2.Windows_Views     5   	     � Title$  Menu_Client_Window��5   	   $	��450��6$   $	��800��61   .��5
      � $��-81,2,-79,-2q�6   $	��NaN��6!    J� OpacityMask �	#FF07F6D1���	#FFACF4B8 � ColumnDefinitions 5   
   �� 5      $
��246* �6   �� 5      $	��80* �6   �� 5      $	��77* �6   �� 5      $	��46* �6   �� 5      $
��432* �6   .+�5   
   �� $��Ajout��6   $
��Left=�6J   $��121,107,0,0q�6e   $	��Top=�6z    J� RenderTransformOrigin$ 0.856,4.075&�6�   $��33��6�   $��51��6�   $��Arial)�6�   $
��Bold"�6�   ���	#FFEDB8E4��6!   �� *ShowWindowCommandAdd+6�   �� 5   
   $��Modifier��6   $
��Left=�6P   $��268,109,0,0q�6k   $	��Top=�6�   $��2��6�   $��31��6�   $��62��6�   $��Arial)�6�   $
��Bold"�6�   ���	#FFEDB8E4��6$   �� *ShowWindowCommandUpdate+6�   �� 5   
   $��	Supprimer��6   $
��Left=�6Q   $��
81,108,0,0q�6l   $	��Top=�6�   $��2��6�   $ 1.512,-2.378&�6�   $��3��6�   $��31��6�   $��84��6�   $��Arial)�6�   $
��Bold"�6  ���	#FFEDB8E4��6%   �� *ShowWindowCommandDelete+6  �� 5   
   $��Rechercher ClientId��6   $
��Left=�6b   $��111,108,0,0q�6}   $	��Top=�6�   $��4��6�   $��31��6�   $	��125��6�   $��Arial)�6�   $
��Bold"�6�   ���	#FFEDB8E4��6/   �� * ShowWindowCommandGetClientById+6�   �� 5   
   -   5        $��btnActualiser��5   6   $��4��6   $��
Actualiser��6!   $
��Left=�6g   $��271,186,0,0q�6�   $	��Top=�6�   $��31��6�   $��77��6�   $��Arial)�6�   $
��Bold"�6�   ���	#FFEDB8E46�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��gdView��5   �      AutoGenerateColumns$ False��6;   $
��Left=�6W   $��134,241,0,10q�6r   $	��688��6�   $��5��6�   ��6   �� *ListeAllClients+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+6I     5      $	 Nom��6%   $ 5* 6K    63   �� *Nom+6K     5      $ Prenom��6%   $ 5* 6Q    66   �� *Prenom+6Q     5      $ Adresse��6%   $ 5* 6S    67   �� *	Adresse+6S     5      $ Ville��6%   $ 5* 6O    65   �� *Ville+6O     5      $ 
CodePostal��6%   $ 5* 6Y    6:   �� *
CodePostal+6Y     5      $ 	Telephone��6%   $ 5* 6W    69   �� *	Telephone+6W   5"      �� 5#   
   $��2��6   $
��Left=�6$   $��	67,33,0,0q�6?   $
��Wrap=�6R   $��Menu Client��6f   $	��Top=�6y   $��3��6�   $	��134��6�   $��16(�6�   $��Arial Black)�6�   5%      5&      