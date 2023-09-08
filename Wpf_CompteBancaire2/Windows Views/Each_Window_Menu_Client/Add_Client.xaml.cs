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
using Wpf_CompteBancaire2.Views_Models.Each_Model_Menu_Client;

namespace Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client
{
    /// <summary>
    /// Logique d'interaction pour Add_Client.xaml
    /// </summary>
    public partial class Add_Client : Window
    {
        I_Menu_Client_Model mCM = new Menu_Client_Model(); // Je pense qu'il faut le mettre dans le local avec Datacontext

        AjoutOk messageAjoutOk = MessageBoxAjoutOk;

        public Add_Client()
        {
            InitializeComponent();


            this.DataContext = mCM;
        }

       private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            Client p1 = new Client()
            {
               
                Nom = tbxNom.Text,
                Prenom = tbxPrenom.Text,
                Adresse = tbxAdresse.Text,
                CodePostal = Convert.ToInt32(tbxCodePostal.Text),
                Ville = tbxVille.Text,
                Telephone = tbxTelephone.Text
            };

           mCM.AddClientBll(p1, messageAjoutOk);
            

             // C'est mieux de mettre les messageBox dans les methodes services, car au moins on sera rassuré si le programme a fonctionné ou pas.
             

            tbxNom.Clear();
            tbxPrenom.Clear();
            tbxAdresse.Clear();
            tbxCodePostal.Clear();
            tbxVille.Clear();
            tbxTelephone.Clear();
            tbxNom.Focus();

            
            // Name="lvEntries"
            //    InitializeComponent();

            //   I_Menu_Client_Model mCM2 = new Menu_Client_Model();

            //   this.DataContext = mCM2;

            //  mCM.GetAllClientBll();
            // Menu_Client_Window mCW = new Menu_Client_Window();
            // mCW.Activate();
            // this.DataContext = mCW;
            // this.DataContext = mCW;

        }



        /*
         * **********************
         */

        public static void MessageBoxAjoutOk()
        {
            MessageBox.Show("Ajout Ok");
        }




        /*
        * **********************
        */
    }
}
