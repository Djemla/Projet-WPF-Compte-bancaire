﻿using System;
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
    /// Logique d'interaction pour Delete_Client.xaml
    /// </summary>
    public partial class Delete_Client : Window
    {

        I_Menu_Client_Model mCM = new Menu_Client_Model(); // Je pense qu'il faut le mettre dans le local avec Datacontext

          MessageSuppression messageSuppression = MessageBoxDelete;
          SuppressionOk suppressionOk = MessageBoxDeleteOk;
        MessageError messageErreur = MessageBoxError;
        public Delete_Client()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            int IdClient = Convert.ToInt32(tbxIdClient.Text);
            mCM.DeleteClientBll(IdClient, messageSuppression, suppressionOk, messageErreur);
            
            tbxIdClient.Clear();
            tbxIdClient.Focus();


        }


        /*
         * **********************
         */

        public static bool MessageBoxDelete()
        {
            MessageBoxResult result = MessageBox.Show($"Vous êtes sur le point d'effectuer une suppression. Voulez vous continuer?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Stop);
            if (result == MessageBoxResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public static void MessageBoxDeleteOk()
        {
            MessageBox.Show("Suppression Ok");
        }

        public static void MessageBoxError()
        {
            MessageBox.Show("Client non identifiable", "ERREUR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /*
         * **********************
         */

    }
}
