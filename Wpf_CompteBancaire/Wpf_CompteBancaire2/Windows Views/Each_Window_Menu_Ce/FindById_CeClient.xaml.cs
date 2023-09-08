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

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Ce
{
    /// <summary>
    /// Logique d'interaction pour FindById_CeClient.xaml
    /// </summary>
    public partial class FindById_CeClient : Window
    {
        MessageError messageErreur = MessageBoxCeErreur;

        I_Menu_Ce_Model mCM = new Menu_Ce_Model();
        public FindById_CeClient()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }



        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            int idClient = Convert.ToInt32(tbxIdClient.Text);

            lvIdClient.ItemsSource = mCM.GetCompteEpargneByClientIdService(idClient, messageErreur); // Avant de stocker le resultat dans la variable pour qu'il affiche dans la liste, il va d'abord executer le programme.
            tbxIdClient.Clear();
            tbxIdClient.Focus();
        }

        public static void MessageBoxCeErreur()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
