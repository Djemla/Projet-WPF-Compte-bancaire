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
    /// Logique d'interaction pour Attribuer_Cc.xaml
    /// </summary>
    public partial class Attribuer_Cc : Window
    {
        MessageCcExistant messageCcExistant = MessageBoxCcExistant;
        AttributionOk attributionOk = MessageBoxCcAttributionOk;
        MessageError messageErreur = MessageBoxCcErreur;

        I_Menu_Cc_Model mCM = new Menu_Cc_Model();
        public Attribuer_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnAttribuer_Click(object sender, RoutedEventArgs e)
        {
            CompteCourant p1 = new CompteCourant()
            {
                NumClient = Convert.ToInt32(tbxIdClientCc.Text),
                NumeroCompte = tbxNumeroCc.Text,
                Solde = Convert.ToDouble(tbxSoldeCc.Text),
            };

            mCM.AttribuerCompte(p1, messageCcExistant, attributionOk, messageErreur) ;
         

            // C'est mieux de mettre les messageBox dans les methodes services, car au moins on sera rassuré si le programme a fonctionné ou pas.

            tbxIdClientCc.Clear();
            tbxNumeroCc.Clear();
            tbxSoldeCc.Clear();
            tbxIdClientCc.Focus();
            // tbxDecouvertCc.Clear();
        }

        public static void MessageBoxCcExistant()
        {
            MessageBox.Show("Attribution non réalisable. Ce client a déjà un compte courant", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        public static void MessageBoxCcAttributionOk()
        {
            MessageBox.Show("Attribution Ok");
        }

        public static void MessageBoxCcErreur()
        {
            MessageBox.Show("Client non identifiable. Veuillez creer d'abord un compte client.", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }


    }
}
