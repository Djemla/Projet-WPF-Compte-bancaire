using Models.Compte;
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
    /// Logique d'interaction pour Virement_Cc.xaml
    /// </summary>
    public partial class Virement_Cc : Window

    {
         VirementOk messageVirementOk = MessageBoxVirementOk;
         NonVirement messageNonVirement = MessageBoxNonVirement;

        I_Menu_Cc_Model mCM = new Menu_Cc_Model();

        public Virement_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnValiderVirement_Click(object sender, RoutedEventArgs e)
        {

            int IdClient = Convert.ToInt32(tbxIdClientCc.Text);
            double Montant = Convert.ToDouble(tbxMontantVirementCc.Text);
            CompteCourant cc1 = new CompteCourant();

            mCM.Virement(IdClient, Montant, cc1, messageVirementOk, messageNonVirement);


            tbxIdClientCc.Clear();
            tbxMontantVirementCc.Clear();
            tbxIdClientCc.Focus();

        }

        /*
         * *******
         */

        public static void MessageBoxVirementOk()
        {
            MessageBox.Show("Virement Ok");
        }

        public static void MessageBoxNonVirement()
        {
            MessageBox.Show("Virement impossible, solde insufisant");
        }
    }
}
