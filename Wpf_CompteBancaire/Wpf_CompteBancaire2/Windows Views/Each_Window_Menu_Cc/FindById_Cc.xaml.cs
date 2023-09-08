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
    /// Logique d'interaction pour FindById_Cc.xaml
    /// </summary>
    public partial class FindById_Cc : Window
    {
        I_Menu_Cc_Model mCM = new Menu_Cc_Model();
        MessageError messageErreur = MessageBoxCcErreur;
        public FindById_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            int idCc = Convert.ToInt32(tbxIdCc.Text);

            lvIdCc.ItemsSource = mCM.GetCompteCourantByIdService(idCc, messageErreur); // Avant d'afficher dans la liste ou non, il va d'abord executer le programme.
            tbxIdCc.Clear();
            tbxIdCc.Focus();

        }
        public static void MessageBoxCcErreur()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
