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
    /// Logique d'interaction pour Depot_Cc.xaml
    /// </summary>
    public partial class Depot_Cc : Window
    {
       DepotOk messageDepotOk = MessageBoxDepotOk;

        I_Menu_Cc_Model mCM = new Menu_Cc_Model();

        public Depot_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnValiderDepot_Click(object sender, RoutedEventArgs e)
        {
            int idClient = Convert.ToInt32(tbxIdClientCc.Text);
            double montant = Convert.ToDouble(tbxMontantDepotCc.Text);

            mCM.Depot(idClient, montant, messageDepotOk);

            tbxIdClientCc.Clear();
            tbxMontantDepotCc.Clear();
            tbxIdClientCc.Focus();

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
