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
    /// Logique d'interaction pour Retrait_Cc.xaml
    /// </summary>
    public partial class Retrait_Cc : Window
    {
       RetraitOk messageRetraitOk = MessageBoxRetraitOk;
       NonRetrait messageNonRetrait = MessageBoxNonRetrait;

        I_Menu_Cc_Model mCM = new Menu_Cc_Model();
        public Retrait_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnValiderRetrait_Click(object sender, RoutedEventArgs e)
        {
            int IdClient = Convert.ToInt32(tbxIdClientCc.Text);
            double Montant = Convert.ToDouble(tbxMontantRetraitCc.Text);

            mCM.Retrait(IdClient, Montant, messageRetraitOk, messageNonRetrait);
            

            tbxIdClientCc.Clear();
            tbxMontantRetraitCc.Clear();
            tbxIdClientCc.Focus();

        }

        /*
         * *******
         */

        public static void MessageBoxRetraitOk()
        {
            MessageBox.Show("Retrait Ok");
        }

        public static void MessageBoxNonRetrait()
        {
            MessageBox.Show("Retrait impossible, solde insufisant");
        }

       

    }
}
