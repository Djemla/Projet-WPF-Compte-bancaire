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
    /// Logique d'interaction pour Attribuer_Ce.xaml
    /// </summary>
    public partial class Attribuer_Ce : Window
    {
        MessageCeExistant messageCeExistant = MessageBoxCeExistant;
        AttributionOk attributionOk = MessageBoxCeAttributionOk;
        MessageError messageErreur = MessageBoxCeErreur;

        I_Menu_Ce_Model mCM = new Menu_Ce_Model();
        public Attribuer_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnAttribuer_Click(object sender, RoutedEventArgs e)
        {
            CompteEpargne p1 = new CompteEpargne()
            {
                NumClient = Convert.ToInt32(tbxIdClientCe.Text),
                NumeroCompte = tbxNumeroCe.Text,
                Solde = Convert.ToDouble(tbxSoldeCe.Text),
            };

            mCM.AttribuerCompte(p1, messageCeExistant, attributionOk, messageErreur);


            // C'est mieux de mettre les messageBox dans les methodes services, car au moins on sera rassuré si le programme a fonctionné ou pas.

            tbxIdClientCe.Clear();
            tbxNumeroCe.Clear();
            tbxSoldeCe.Clear();
            tbxIdClientCe.Focus();
            // tbxDecouvertCe.Clear();
        }

        public static void MessageBoxCeExistant()
        {
            MessageBox.Show("Attribution non réalisable. Ce client a déjà un compte courant", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        public static void MessageBoxCeAttributionOk()
        {
            MessageBox.Show("Attribution Ok");
        }

        public static void MessageBoxCeErreur()
        {
            MessageBox.Show("Client non identifiable. Veuillez creer d'abord un compte client.", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
