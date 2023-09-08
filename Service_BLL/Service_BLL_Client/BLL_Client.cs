using Dao_DAL.Dao_DAL_Client;
using Models.Client;
using Service_BLL.Commande;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Service_BLL.Service_BLL_Client
{
    public class BLL_Client : I_BLL_Client // = Main view Model ??? Non, ceci vient après le Main view Model. Correspond au (View Model Client)
    {
        private I_DAL_Client eDal = new DAL_Client(); // Pour faire appel aux méthodes de DAL. Une sorte de connexion BLL et DAL


        // BLL Client ici va definir la fenêtre MenuClient Window, cad fe,être qui apparait après avoir cliqué sur MenuClient.
        // => BLL Client est le Menu client Model (après le Main View Model)
    /*    public ObservableCollection<Client> ListeAllClients { get; set; } // C'est cette propriété qui stocquera notre liste à chaque fois que cette classe (LL_Client) sera instanciée, et qui sera renvoyée à notre gridview.
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

        public BLL_Client() 
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
            /*
             * 

            // On sait de nature qu'une classe peut être typée.
            // Le type utilisée ici est le nom de la classe qu'on veut affichée la fenêtre = Menu_Client_Window

             
        }

        private bool CanshowWindowUpdateCli(object obj)
        {
            return true;
        }

        private void ShowWindowUpdateCli(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanshowWindowDeleteCli(object obj)
        {
            return true;
        }

        private void ShowWindowDeleteCli(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanshowWindowIdCli(object obj)
        {
            return true;
        }

        private void ShowWindowIdCli(object obj)
        {
            throw new NotImplementedException();
        }
    */
       

      

       






        // Methodes

        public int AddClientBll(Client cli)
        {
            return eDal.AddClientDal(cli);
        }

        public int DeleteClientBll(int id)
        {
            return eDal.DeleteClientDal(id);
        }

         public ObservableCollection<Client> GetAllClientBll()
          //  public List<Client> GetAllClientBll()
        {
            return eDal.GetAllClientDal();
        }   //¨Pas besoin ici car on a déjà placer notre liste dans le constructeur pour qu'il affiche la liste automatiquement par l'instanciation de la classe

        public ObservableCollection<Client> GetClientByIdBll(int id)
        {
            return eDal.GetClientByIdDal(id);
        }

        public int UpdateClientBll(Client cli)
        {
            return eDal.UpdateClientDal(cli);
        }
    }
}
