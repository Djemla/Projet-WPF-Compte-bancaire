   M S B A M L   `   `   `  ����N  JWpf_CompteBancaire2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Wpf_CompteBancaire2.Windows_Views!Wpf_CompteBancaire2.Windows_Views  5   	   6    0Wpf_CompteBancaire2.Windows_Views.Menu_Ce_Window   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Wpf_CompteBancaire2.Windows_Views     5   	     � Title$  Menu_Ce_Window��5   	   $	��450��6    $	��800��6-   .��5	      �  J� OpacityMask 5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FFC0A2A2��6    � Offset$ 1Q�61   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ Black��6   � 5      $ 	#FFD8D88B��6   $ 1Q�61   5      .+�5   
   �� $��Ajout Compte Epargne��6   $
��Left=�6[   $��	39,78,0,0q�6v   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��60   �� *ShowWindowCommandAddCe+6�   �� 5   
   $��Modifier Compte Epargne��6   $
��Left=�6a   $��
39,132,0,0q�6|   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��63   �� *ShowWindowCommandUpdateCe+6�   �� 5   
   $��Supprimer Compte Epargne��6   $
��Left=�6b   $��
39,182,0,0q�6}   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��64   �� *ShowWindowCommandDeleteCe+6�   �� 5   
   $(��"Rechercher Compte Epargne IdCompte��6   $
��Left=�6m   $��
293,88,0,0q�6�   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��6>   �� *ShowWindowCommandGetCeById+6�   �� 5   
   $(��"Rechercher Compte Epargne IdClient��6   $
��Left=�6s   $��294,138,0,0q�6�   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��6>   �� *" ShowWindowCommandGetCeByIdClient+6�   �� 5   
   $��Attribuer Compte Epargne��6   $
��Left=�6e   $��296,192,0,0q�6�   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��64   �� *ShowWindowCommandAttribuerCe+6�   �� 5   
   $��Depot Compte Epargne��6   $
��Left=�6]   $��
598,92,0,0q�6x   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��60   �� *ShowWindowCommandDepotCe+6�   �� 5   
   $��Retrait Compte Epargne��6   $
��Left=�6a   $��594,144,0,0q�6|   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��62   �� *ShowWindowCommandRetraitCe+6�   �� 5   
   $��Virement Compte Epargne��6   $
��Left=�6c   $��590,191,0,0q�6~   $	��Top=�6�   $��Arial)�6�   $��14(�6�   ���	#FFBC3232$
��Bold"�6�   ��63   �� *ShowWindowCommandVirementCe+6�   �� 5   
   -   5        $��BtnActualiser��5   &   $��
Actualiser��6   $
��Left=�6X   $��691,237,0,0q�6s   $	��Top=�6�   $��Arial)�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��gdView��5!   �      AutoGenerateColumns$ False��6A   $
��Left=�6]   $��95,243,0,10q�6x   $	��557��6�   $��5��6�   ��6   �� *ListeAllCompteEpargne+   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Id Compte��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 5* 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *
IdCompte+6V     5$      $ Numero Compte��6%   $	 5* 6^   
 6=   �� *NumeroCompte+6^     5%      $ Solde��6%   $	 5* 6O   
 65   �� *Solde+6O     5&      $ Taux d'epargne��6%   $	 5* 6^   
 6>   �� *TauxEpargne+6^     5'      $ 	Id Client��6%   $	 5* 6W   
 69   �� *	NumClient+6W   5*      �� 5+   
   $
��Left=�6   $��
307,36,0,0q�6/   $
��Wrap=�6C   $��Menu Compte Epargne��6W   $	��Top=�6r   $��Arial Black)�6�   $��16(�6�   ���	#FFDAB3886�   5.      5/      