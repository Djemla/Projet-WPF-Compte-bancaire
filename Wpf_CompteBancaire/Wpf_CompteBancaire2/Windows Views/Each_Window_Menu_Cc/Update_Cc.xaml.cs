using Models.Client;
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
    /// Logique d'interaction pour Update_Cc.xaml
    /// </summary>
    public partial class Update_Cc : Window
    {
        MessageModification messageModification = MessageBoxUpdate;
        ModificationOk modificationOk = MessageBoxUpdateOk;
        MessageError messageErreur = MessageBoxError;


        I_Menu_Cc_Model mCM = new Menu_Cc_Model();
        public Update_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            CompteCourant pUpdate = new CompteCourant()
            {
                Solde = Convert.ToDouble(tbxSoldeCc.Text),
                NumeroCompte = tbxNumeroCc.Text,
                DecouvertAutorise = Convert.ToInt32(tbxDecouvert.Text),
                NumClient = Convert.ToInt32( tbxIdClientCc.Text),

            };
            mCM.UpdateCompteCourantService(pUpdate, messageModification, modificationOk, messageErreur);
            

            tbxIdClientCc.Clear();
            tbxNumeroCc.Clear();
            tbxSoldeCc.Clear();
            tbxDecouvert.Clear();
            tbxIdClientCc.Focus();
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
