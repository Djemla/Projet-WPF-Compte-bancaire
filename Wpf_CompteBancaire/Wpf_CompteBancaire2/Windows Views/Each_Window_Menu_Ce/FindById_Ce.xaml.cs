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
    /// Logique d'interaction pour FindById_Ce.xaml
    /// </summary>
    public partial class FindById_Ce : Window
    {
        I_Menu_Ce_Model mCM = new Menu_Ce_Model();
        MessageError messageErreur = MessageBoxCeErreur;
        public FindById_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            int idCe = Convert.ToInt32(tbxIdCe.Text);

            lvIdCe.ItemsSource = mCM.GetCompteEpargneByIdService(idCe, messageErreur); // Avant d'afficher dans la liste ou non, il va d'abord executer le programme.
            tbxIdCe.Clear();
            tbxIdCe.Focus();

        }
        public static void MessageBoxCeErreur()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
