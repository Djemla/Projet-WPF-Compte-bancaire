   M S B A M L   `   `   `  ����N  JWpf_CompteBancaire2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Gclr-namespace:Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client9Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client  5   	   O    IWpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client.FindById_Client   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   YlocalGclr-namespace:Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client     5   	     � Title$  FindById_Client��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��166* �6   �� 5      $	��51* �6   .+�5   
   �� $
��Left=�6   $��170,130,0,0q�6/   $
��Wrap=�6D   $��	Id Client��6X   $	��Top=�6i   $��14(�6�   $��Arial)�6�   �� 5   
   -   5        $��tbxId��5   ^   $
��Left=�6   $��400,130,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $�� ��6V   $	��Top=�6k   $	��120��6�   $��14(�6�   $��Arial)�6�   �� 5   
   -   5        $��BtnRechercher��5   &   $��
Rechercher��6   $
��Left=�6W   $��460,217,0,0q�6r   $	��Top=�6�   $��14(�6�   $��Arial)�6�   �� 5   
   $
��Left=�6   $��
250,50,0,0q�6/   $
��Wrap=�6C   $ ��Rechercher Client par l'Id��6W   $	��Top=�6y   $��16(�6�   $��Arial Black)�6�   �� 5   
   -   5        $��
lvIdClient��5   >   $��59,283,26,51q�6P   $��2��6f   $
��Left=�6w   $��Center=�6�   $��Center=�6�    �� View 5      �� 5      .P�5      �� $��	IdClient4��6I    �� Width$	 100��6\    �� DisplayMemberBinding 6%   �� *Id+6\   �� 5      $	��Nom��6J   $	 100��6W    6%   �� *Nom+6W   �� 5      $��Prenom��6M   $	 100��6]    6%   �� *Prenom+6]   �� 5      $��Adresse��6N   $	 100��6_    6%   �� *	Adresse+6_   �� 5      $��Code Postal��6Q   $	 100��6f    6%   �� *
CodePostal+6f   �� 5      $��Ville��6L   $	 100��6[    6%   �� *Ville+6[   �� 5      $��	Telephone��6P   $	 100��6c    6%   �� *	Telephone+6c   5      5      5       5!      