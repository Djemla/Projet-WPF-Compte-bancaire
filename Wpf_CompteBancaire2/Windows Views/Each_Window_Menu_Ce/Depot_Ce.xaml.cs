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
    /// Logique d'interaction pour Depot_Ce.xaml
    /// </summary>
    public partial class Depot_Ce : Window
    {
        DepotOk messageDepotOk = MessageBoxDepotOk;

        I_Menu_Ce_Model mCM = new Menu_Ce_Model();

        public Depot_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnValiderDepot_Click(object sender, RoutedEventArgs e)
        {
            int idClient = Convert.ToInt32(tbxIdClientCe.Text);
            double montant = Convert.ToDouble(tbxMontantDepotCe.Text);

            mCM.Depot(idClient, montant, messageDepotOk);

            tbxIdClientCe.Clear();
            tbxMontantDepotCe.Clear();
            tbxIdClientCe.Focus();

        }

        /*
         * *******
         */

        public static void MessageBoxDepotOk()
        {
            MessageBox.Show("Depot Ok");
        }
    }
}
