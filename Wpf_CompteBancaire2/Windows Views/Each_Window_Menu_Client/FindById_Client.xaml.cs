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

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client
{
    
    /// <summary>
    /// Logique d'interaction pour FindById_Client.xaml
    /// </summary>
    public partial class FindById_Client : Window
    {
        MessageError messageErreur = MessageBoxError;

        I_Menu_Client_Model mCM = new Menu_Client_Model(); // Je pense qu'il faut le mettre dans le local avec Datacontext

        public FindById_Client()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            int idClient = Convert.ToInt32(tbxId.Text);
            mCM.GetClientByIdBll(idClient, messageErreur);

             lvIdClient.ItemsSource = mCM.GetClientByIdBll(idClient, messageErreur);

            tbxId.Clear();
            tbxId.Focus();
        }



        public static void MessageBoxError()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
