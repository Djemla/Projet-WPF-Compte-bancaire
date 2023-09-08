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
    /// Logique d'interaction pour Add_Ce.xaml
    /// </summary>
    public partial class Add_Ce : Window
    {
        AjoutOk messageAjoutOk = MessageBoxAjoutOk;


        I_Menu_Ce_Model mCM = new Menu_Ce_Model();

        public Add_Ce()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {

            CompteEpargne p1 = new CompteEpargne()
            {

                NumeroCompte = tbxNumeroCe.Text,
                Solde = Convert.ToDouble(tbxSoldeCe.Text),
                //  DecouvertAutorise = Convert.ToInt32(tbxDecouvertCe.Text), // Pas besoin ici car le decouvert par defaut est deja actualisé automatiquement
                NumClient = Convert.ToInt32(tbxIdClientCe.Text)
            };

            mCM.AddCompteEpargneService(p1, messageAjoutOk);


            // C'est mieux de mettre les messageBox dans les methodes services, car au moins on sera rassuré si le programme a fonctionné ou pas.

            tbxIdClientCe.Clear();
            tbxNumeroCe.Clear();
            tbxSoldeCe.Clear();
            tbxIdClientCe.Focus();
            // tbxDecouvertCe.Clear();


        }

        public static void MessageBoxAjoutOk()
        {
            MessageBox.Show("Ajout Ok");
        }
    }
}
