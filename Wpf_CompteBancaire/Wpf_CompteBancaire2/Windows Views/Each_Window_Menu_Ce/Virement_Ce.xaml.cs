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

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Ce
{
    /// <summary>
    /// Logique d'interaction pour Virement_Ce.xaml
    /// </summary>
    public partial class Virement_Ce : Window
    {

        VirementOk messageVirementOk = MessageBoxVirementOk;
        NonVirement messageNonVirement = MessageBoxNonVirement;

        I_Menu_Ce_Model mCM = new Menu_Ce_Model();

        public Virement_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnValiderVirement_Click(object sender, RoutedEventArgs e)
        {

            int IdClient = Convert.ToInt32(tbxIdClientCe.Text);
            double Montant = Convert.ToDouble(tbxMontantVirementCe.Text);
            CompteEpargne ce1 = new CompteEpargne();

            mCM.Virement(IdClient, Montant, ce1, messageVirementOk, messageNonVirement);


            tbxIdClientCe.Clear();
            tbxMontantVirementCe.Clear();
            tbxIdClientCe.Focus();

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
