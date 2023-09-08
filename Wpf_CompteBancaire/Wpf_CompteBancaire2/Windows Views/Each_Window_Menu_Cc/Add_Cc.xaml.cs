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
    /// Logique d'interaction pour Add_Cc.xaml
    /// </summary>
    public partial class Add_Cc : Window
    {
        AjoutOk messageAjoutOk = MessageBoxAjoutOk;


        I_Menu_Cc_Model mCM = new Menu_Cc_Model();

        public Add_Cc()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {

            CompteCourant p1 = new CompteCourant()
            {

                NumeroCompte = tbxNumeroCc.Text,
                Solde = Convert.ToDouble(tbxSoldeCc.Text),
              //  DecouvertAutorise = Convert.ToInt32(tbxDecouvertCc.Text), // Pas besoin ici car le decouvert par defaut est deja actualisé automatiquement
                NumClient = Convert.ToInt32(tbxIdClientCc.Text)
            };

            mCM.AddCompteCourantService(p1, messageAjoutOk);


            // C'est mieux de mettre les messageBox dans les methodes services, car au moins on sera rassuré si le programme a fonctionné ou pas.

            tbxIdClientCc.Clear();
            tbxNumeroCc.Clear();
            tbxSoldeCc.Clear();
            tbxIdClientCc.Focus();
            // tbxDecouvertCc.Clear();


        }

        public static void MessageBoxAjoutOk()
        {
            MessageBox.Show("Ajout Ok");
        }
    }
}
