using Models.Client;
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

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client
{
    /// <summary>
    /// Logique d'interaction pour Update_Client.xaml
    /// </summary>
    public partial class Update_Client : Window
    {
       MessageModification messageModification = MessageBoxUpdate;
       ModificationOk modificationOk = MessageBoxUpdateOk;
       MessageError messageErreur = MessageBoxError;


        I_Menu_Client_Model mCM = new Menu_Client_Model(); // Je pense qu'il faut le mettre dans le local avec Datacontext

        public Update_Client()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        { 
            Client pUpdate = new Client()
            {
                Id = Convert.ToInt32(tbxId.Text),
                Nom = tbxNom.Text,
                Prenom = tbxPrenom.Text,
                Adresse = tbxAdresse.Text,
                CodePostal = Convert.ToInt32(tbxCodePostal.Text),
                Ville = tbxVille.Text,
                Telephone = tbxTelephone.Text

            };
            mCM.UpdateClientBll(pUpdate, messageModification, modificationOk, messageErreur);


            tbxId.Clear();
            tbxNom.Clear();
            tbxPrenom.Clear();
            tbxAdresse.Clear();
            tbxCodePostal.Clear();
            tbxVille.Clear();
            tbxTelephone.Clear();
            tbxId.Focus();

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
