using Models.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_CompteBancaire2.Windows_Views
{
    /// <summary>
    /// Logique d'interaction pour Menu_Client_Window.xaml
    /// </summary>
    public partial class Menu_Client_Window : Window
    {
        I_Menu_Client_Model mCM = new Menu_Client_Model();
        public Menu_Client_Window()
        {
            InitializeComponent();            

            this.DataContext = mCM; // Pour dire que toutes les interactions qui aura lieu sur lrs differentes fenêtre MenuClient (add, update, ...) sont liées à la classe MenuClientModel (seront actualisées sur la fenêtre principale MenuClientWindow)
        }

        private void btnActualiser_Click(object sender, RoutedEventArgs e)
        {
           
            
            gdView.ItemsSource = mCM.GetAllClientBll();

            // J'ai crée ce bouton actualisé pour qu'il actualise la liste après l'ajout la liste après la realisation d'une commande (add, update, ...).
            //Vu que ça ne peut pas s'actualiser automatiquement, car il faut faire appel à la base SQL à chaque fois.

        }
    }
}

