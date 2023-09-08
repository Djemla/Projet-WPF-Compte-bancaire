using Dao_DAL.Dao_DAL_Client;
using Models.Client;
// using Service_BLL.Service_BLL_Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_CompteBancaire2.Commande;
using Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Client;

namespace Wpf_CompteBancaire2.Views_Models
{
    public class Menu_Client_Model :  I_Menu_Client_Model // Remplace ici la classe BLL Service Client. Correspond au (View Model Client). Voir explication ci-dessous.
    {
         public I_DAL_Client eDal = new DAL_Client(); // Pour faire appel aux méthodes de DAL. Une sorte de connexion BLL et DAL


        // Menu_Client_Model (BLL Client) ici va definir la fenêtre MenuClient Window, cad fe,être qui apparait après avoir cliqué sur MenuClient.
        // => BLL Client est le Menu client Model (après le Main View Model)
        public static ObservableCollection<Client> ? ListeAllClients { get; set; } // C'est cette propriété qui stocquera notre liste à chaque fois que cette classe (LL_Client) sera instanciée, et qui sera renvoyée à notre gridview.
                                                                          // BLL_Client est l'une de nos classes secondaire que le MainViewModel appelera 'd'où le nom Main view Model)
                                                                          // Declaration des propitétés commandes (ShowWindowCommand) qui seront executées sur la page Menu Client
        public ICommand ShowWindowCommandAdd { get; set; }  // Propriété qui sera executée lorsqu'on va cliquer sur le bouton (Menu client) pour faire appel à une autre fenêtre qui aura le detail du menu.
        public ICommand ShowWindowCommandUpdate { get; set; }
        public ICommand ShowWindowCommandDelete { get; set; }
        public ICommand ShowWindowCommandGetClientById { get; set; }
        // public ICommand ShowWindowCommandGetAllClient { get; set; } // Pas besoin ici car on a déjà la liste qui va s'afficher sur la page d'acceuil, grace à l'instanciation de cette classe BLL Client


        // Creation du constructeur de cette classe 
        // Vu que cette classe est notre model view du Menu client, toutes les données de cette classe correspondra aux dataContext du Menu client window.
        // Et vu que ca correspond au DataContext du Client Window, on veux qu'à chaque fois que cette classe sera appelée pour une methode une autre, la liste soit actualisée pour notre GridView Menu client automatiquement dans la fenêtre Menu Client Window.
        // Et les boutons du Menu Client Window pourront faire appel à chaque fenêtre respective

        public Menu_Client_Model()
        {
            ListeAllClients = eDal.GetAllClientDal(); // Vu que c'est dejà instancier ici, appel de la méthode getAllClient de Dal via le eDal

            ShowWindowCommandAdd = new RelayCommand(ShowWindowAddCli, CanshowWindowAddCli);

            ShowWindowCommandUpdate = new RelayCommand(ShowWindowUpdateCli, CanshowWindowUpdateCli);

            ShowWindowCommandDelete = new RelayCommand(ShowWindowDeleteCli, CanshowWindowDeleteCli);

            ShowWindowCommandGetClientById = new RelayCommand(ShowWindowIdCli, CanshowWindowIdCli);
        }


        private bool CanshowWindowAddCli(object obj)
        {
            return true;
        }

        private void ShowWindowAddCli(object obj)
        {
            Add_Client AddClientWin = new Add_Client(); // Definit ici la fenêtre à montrer
            AddClientWin.Show();

            // On sait de nature qu'une classe peut être typée.
            // Le type utilisée ici est le nom de la classe (de la fenêtre) qu'on souhaite affichée. Ca sera rattaché au différents boutons correspondants du Menu_Cc_Window
            // Par exemble sur la fenêtre Menu_Client (Menu_Client_Window), nous souhaitons que le bouton de la fenêtre "Ajout Client" affiche la fenêtre correspondante "Add_Client", pour renseigner les paramètres.


        }

        private bool CanshowWindowUpdateCli(object obj)
        {
            return true;
            
        }

        private void ShowWindowUpdateCli(object obj)
        {
            Update_Client UpdateClienWin = new Update_Client();
            UpdateClienWin.Show();
        }

        private bool CanshowWindowDeleteCli(object obj)
        {
            return true;
        }

        private void ShowWindowDeleteCli(object obj)
        {
            Delete_Client DeleteClientWin = new Delete_Client();
            DeleteClientWin.Show();
        }

        private bool CanshowWindowIdCli(object obj)
        {
            return true;
        }

        private void ShowWindowIdCli(object obj)
        {
            FindById_Client FindByIdClientWin = new FindById_Client();
            FindByIdClientWin.Show();
        }





        // Methodes

        public int AddClientBll(Client cli, AjoutOk messageAjoutOk)
        {
            int verif = eDal.AddClientDal(cli);
            if (verif != 0)
            {
                messageAjoutOk();
                //ListeAllClients = eDal.GetAllClientDal();
            }

            return verif;
           

        }

        public int DeleteClientBll(int id, MessageSuppression messageSuppression, SuppressionOk suppressionOk, MessageError messageErreur)
        {
            // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

            int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
            ObservableCollection<Client> listeIdClient = new ObservableCollection<Client>();
            listeIdClient = eDal.GetClientByIdDal(id);
            if(listeIdClient.Count != 0)    // Je prefère utiliser le count ici que le null, car ça ne reconnait pas le null
            {
                bool result = messageSuppression();
                //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the delete ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result) //(si ev1 est true (yes))
                {
                    verif = eDal.DeleteClientDal(id); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
                    suppressionOk();
                }
            }
            else
            {
                messageErreur();
            }

            return verif;
        }

          public ObservableCollection<Client> GetAllClientBll()
         {
             return eDal.GetAllClientDal();
         }   //¨Pas besoin ici car on a déjà placer notre liste dans le constructeur pour qu'il affiche la liste automatiquement par l'instanciation de la classe

       
        public ObservableCollection<Client> GetClientByIdBll(int id, MessageError messageErreur)
        {
            ObservableCollection<Client> listeIdClient = new ObservableCollection<Client>();
            listeIdClient = eDal.GetClientByIdDal(id);

            if (listeIdClient.Count == 0)
            {
                messageErreur();
            }
            

                return listeIdClient;
        }

       
        public int UpdateClientBll(Client cli, MessageModification messageModification, ModificationOk modificationOk, MessageError messageErreur)
        { 
            // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

            int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
            ObservableCollection<Client> listeIdClient = new ObservableCollection<Client>();
            listeIdClient = eDal.GetClientByIdDal(cli.Id);
            if (listeIdClient.Count != 0)
            {
                bool result = messageModification();
                //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the update ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result) //(si ev1 est true (yes))
                {
                    verif = eDal.UpdateClientDal(cli); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
                    modificationOk();
                }
            }
            else
            {
                messageErreur();
            }

            return verif;
        } 
    } 
}





// Pourquoi Menu Clien Model remplace le BLL Service, sachant que le projet peut directement appeler BLL Service?
// Comme constaté, BLL Service a besoin des window menu (Add client window, update client window, ... ici).
// Or ces window se trouvent dans le projet, et ne peuvent pas être crées par la biblio BLL. Seul le projet peut crée des window.
// Et BLL ne peut pas être lié au projé (par reference), seul le projet peut être lié aux bibliothèque.
// Vu que l'accès est impossible, il a été préférable de decaler les BLL vers le projet, et de relier le projet au DAL et non plus au BLL qui se trouve déjà à l'interieur, vu que BLL a besoin du Dal.
// Le projet a été aussi relier à Model, vu que BLL était relié à Model pour avoir la liste des Clients