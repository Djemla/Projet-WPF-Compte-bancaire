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

namespace Wpf_CompteBancaire2.Windows_Views
{
    /// <summary>
    /// Logique d'interaction pour Menu_Ce_Window.xaml
    /// </summary>
    public partial class Menu_Ce_Window : Window
    {
        I_Menu_Ce_Model mCM = new Menu_Ce_Model();
        public Menu_Ce_Window()
        {
            InitializeComponent();
            this.DataContext = mCM;
        }

        private void BtnActualiser_Click(object sender, RoutedEventArgs e)
        {
            gdView.ItemsSource = mCM.GetAllCompteEpargneService();
        }
    }
}
