using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf_CompteBancaire2.Views_Models;

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Cc
{
    /// <summary>
    /// Logique d'interaction pour FindById_CcClient.xaml
    /// </summary>
    public partial class FindById_CcClient : Window
    {
        MessageError messageErreur = MessageBoxCcErreur;

        I_Menu_Cc_Model mCM = new Menu_Cc_Model();
        public FindById_CcClient()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        

        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            int idClient = Convert.ToInt32(tbxIdClient.Text);

            lvIdClient.ItemsSource = mCM.GetCompteCourantByClientIdService(idClient, messageErreur); // Avant de stocker le resultat dans la variable pour qu'il affiche dans la liste, il va d'abord executer le programme.
            tbxIdClient.Clear();
            tbxIdClient.Focus();
        }

        public static void MessageBoxCcErreur()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        
    }
}
