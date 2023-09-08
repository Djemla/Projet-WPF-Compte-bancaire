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
    /// Logique d'interaction pour Update_Ce.xaml
    /// </summary>
    public partial class Update_Ce : Window
    {
        MessageModification messageModification = MessageBoxUpdate;
        ModificationOk modificationOk = MessageBoxUpdateOk;
        MessageError messageErreur = MessageBoxError;


        I_Menu_Ce_Model mCM = new Menu_Ce_Model();
        public Update_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            CompteEpargne pUpdate = new CompteEpargne()
            {
                Solde = Convert.ToDouble(tbxSoldeCe.Text),
                NumeroCompte = tbxNumeroCe.Text,
                TauxEpargne = Convert.ToDouble(tbxTxEpargne.Text),
                NumClient = Convert.ToInt32(tbxIdClientCe.Text),

            };
            mCM.UpdateCompteEpargneService(pUpdate, messageModification, modificationOk, messageErreur);


            tbxIdClientCe.Clear();
            tbxNumeroCe.Clear();
            tbxSoldeCe.Clear();
            tbxTxEpargne.Clear();
            tbxIdClientCe.Focus();
        }



        /*
        * **********************
        */

        public static bool MessageBoxUpdate()
        {
            MessageBoxResult result = MessageBox.Show($"Vous êtes sur le point d'effectuer une modification. Voulez vous continuer?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public static void MessageBoxUpdateOk()
        {
            MessageBox.Show("Modification Ok");
        }


        public static void MessageBoxError()
        {
            MessageBox.Show("Personne non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /*
         * **********************
         */
    }
}
