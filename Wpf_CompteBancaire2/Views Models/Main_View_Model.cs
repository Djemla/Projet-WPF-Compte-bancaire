using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_CompteBancaire2.Commande;
using Wpf_CompteBancaire2.Windows_Views;

namespace Wpf_CompteBancaire2.Views_Models
{
    public class Main_View_Model
    {

        public ICommand ShowWindowCommandClient { get; set; }
        public ICommand ShowWindowCommandCc { get; set; }
        public ICommand ShowWindowCommandCe { get; set; }

        // Definition du constructeur
        // Le Main view Model est ce qui est rattaché au main vuew Window.
        // Vu que sur notre Main view Window on n'a pas de gridView, pas besoin donc de mettre un liste dans le constructeur. C'est pour celà qu'on n'a pas crée de propriété liste ici.
        // Par contre on mettra la propriété  ShowWindowCommand dans le constructeur, car à chaque fois que cette classe sera instanciée pour faire appel, son rôle sera de relier automatiquement les commandes reliées aux boutons.

        public Main_View_Model()
        {
            ShowWindowCommandClient = new RelayCommand(ShowWindowCli, CanshowWindowCli);

            ShowWindowCommandCc = new RelayCommand(ShowWindowCc, CanshowWindowCc);

            ShowWindowCommandCe = new RelayCommand(ShowWindowCe, CanshowWindowCe);
        }

        private bool CanshowWindowCli(object obj) // Methode demandée par le systeme automatiquement après avoir renseignée les paramètres
        {
            return true; // Modifié: Return true, pour dire oui ça peut montrer une fenêtre.
        }

        private void ShowWindowCli(object obj) // Methode demandée par le systeme automatiquement après avoir renseignée les paramètres
        {
            Menu_Client_Window MenuClientWin = new Menu_Client_Window(); // Definit ici la fenêtre à montrer
            MenuClientWin.Show();

            // On sait de nature qu'une classe peut être typée.
            // Le type utilisée ici est le nom de la classe qu'on veut affichée la fenêtre = Menu_Client_Window
        }

        private bool CanshowWindowCc(object obj)
        {
            return true;
        }

        private void ShowWindowCc(object obj)
        {
            Menu_Cc_Window MenuCcWin = new Menu_Cc_Window();
            MenuCcWin.Show();
        }


        private bool CanshowWindowCe(object obj)
        {
            return true;
        }

        private void ShowWindowCe(object obj)
        {
            Menu_Ce_Window MenuCeWin = new Menu_Ce_Window();
            MenuCeWin.Show();
        }
    }
}
