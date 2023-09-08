using Dao_DAL.Dao_DAL_Cc;
using Dao_DAL.Dao_DAL_Client;
using Models.Client;
using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_CompteBancaire2.Commande;
using Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Cc;

namespace Wpf_CompteBancaire2.Views_Models
{
    public class Menu_Cc_Model : I_Menu_Cc_Model
    {
    public I_DAL_CompteCourant ccDal = new DAL_CompteCourant();
    public I_DAL_Client cliDal = new DAL_Client(); // J'aurai besoin de la liste client que le DALClient va me fournir à travers SQL, pour verifier l'attribution d'un nouveau compte ou non



        // Menu_Cc_Model (BLL CompteCourant) ici va definir la fenêtre MenuClient Window, cad fe,être qui apparait après avoir cliqué sur MenuClient.

           public static ObservableCollection<CompteCourant> ? ListeAllCompteCourant { get; set; } // C'est cette propriété qui stocquera notre liste à chaque fois que cette classe (Menu_Cc_Model) sera instanciée, et qui sera renvoyée à notre gridview.
                                                                             // Menu_Cc_Model est l'une de nos classes secondaire que le MainViewModel appelera 'd'où le nom Main view Model)
                                                                             // Declaration des propriétés commandes (ShowWindowCommand) qui seront executées sur la page Menu_CompteCourant
           public ICommand? ShowWindowCommandAddCc { get; set; }  // Propriété qui sera executée lorsqu'on va cliquer sur le bouton (Menu client) pour faire appel à une autre fenêtre qui aura le detail du menu.
           public ICommand? ShowWindowCommandUpdateCc { get; set; }
           public ICommand? ShowWindowCommandDeleteCc { get; set; }
           public ICommand? ShowWindowCommandGetCcById { get; set; }
           public ICommand? ShowWindowCommandGetCcByIdClient { get; set; }
        public ICommand? ShowWindowCommandAttribuerCc { get; set; }
        public ICommand? ShowWindowCommandDepotCc { get; set; }
        public ICommand? ShowWindowCommandRetraitCc { get; set; }
        public ICommand? ShowWindowCommandVirementCc { get; set; }

        // public ICommand ShowWindowCommandGetAllClient { get; set; } // Pas besoin ici car on a déjà la liste qui va s'afficher sur la page d'acceuil, grace à l'instanciation de cette classe BLL Client


             // Creation du constructeur de cette classe 
             // Vu que cette classe est notre model view du Menu client, toutes les données de cette classe correspondra aux dataContext du Menu client window.
             // Et vu que ca correspond au DataContext du Client Window, on veux qu'à chaque fois que cette classe sera appelée pour une methode une autre, la liste soit actualisée pour notre GridView Menu client automatiquement dans la fenêtre Menu Client Window.
             // Et les boutons du Menu Client Window pourront faire appel à chaque fenêtre respective

             public Menu_Cc_Model()
             {
            ListeAllCompteCourant = ccDal.GetAllCompteCourantDal(); // Vu que c'est dejà instancier ici, appel de la méthode getAllClient de Dal via le eDal
                
            ShowWindowCommandAddCc = new RelayCommand(ShowWindowAddCc, CanshowWindowAddCc);
            ShowWindowCommandUpdateCc = new RelayCommand(ShowWindowUpdateCc, CanshowWindowUpdateCc);
            ShowWindowCommandDeleteCc = new RelayCommand(ShowWindowDeleteCc, CanshowWindowDeleteCc);
            ShowWindowCommandGetCcById = new RelayCommand(ShowWindowGetCcById, CanshowWindowGetCcById);
            ShowWindowCommandGetCcByIdClient = new RelayCommand(ShowWindowGetCcByIdClient, CanshowWindowGetCcByIdClient);
            ShowWindowCommandAttribuerCc = new RelayCommand(ShowWindowAttribuerCc, CanshowWindowAttribuerCc);
            ShowWindowCommandDepotCc = new RelayCommand(ShowWindowDepotCc, CanshowWindowDepotCc);
            ShowWindowCommandRetraitCc = new RelayCommand(ShowWindowRetraitCc, CanshowWindowRetraitCc);
            ShowWindowCommandVirementCc = new RelayCommand(ShowWindowVirementCc, CanshowWindowVirementCc);

        }

        private bool CanshowWindowAddCc(object obj)
        {
            return true;
        }

        private void ShowWindowAddCc(object obj)
        {
            
            Add_Cc AddCcWin = new Add_Cc(); // Definit ici la fenêtre à montrer
            AddCcWin.Show();

           // On sait de nature qu'une classe peut être typée.
           // Le type utilisée ici est le nom de la classe (de la fenêtre) qu'on souhaite affichée. Ca sera rattaché au différents boutons correspondants du Menu_Cc_Window
          // Par exemble sur la fenêtre Menu_Cc (Menu_Cc_Window), nous souhaitons que le bouton de la fenêtre "Ajout CompteCourant" affiche la fenêtre correspondante "Add_Cc", pour renseigner les paramètres.  
        }

        private bool CanshowWindowUpdateCc(object obj)
        {
            return true;
        }

        private void ShowWindowUpdateCc(object obj)
        {
            Update_Cc UpdateCcWin = new Update_Cc(); // Definit ici la fenêtre à montrer
            UpdateCcWin.Show();
        }

        private bool CanshowWindowDeleteCc(object obj)
        {
            return true;
        }

        private void ShowWindowDeleteCc(object obj)
        {
            Delete_Cc DeleteCcWin = new Delete_Cc(); // Definit ici la fenêtre à montrer
            DeleteCcWin.Show();            
        }

        private bool CanshowWindowGetCcById(object obj)
        {
            return true;
        }

        private void ShowWindowGetCcById(object obj)
        {
            FindById_Cc FindByIdCcWin = new FindById_Cc(); // Definit ici la fenêtre à montrer
            FindByIdCcWin.Show();

            // On sait de nature qu'une classe peut être typée.
            // Le type utilisée ici est le nom de la classe (de la fenêtre) qu'on souhaite affichée. Ca sera rattaché au différents boutons correspondants du Menu_Cc_Window
            // Par exemble sur la fenêtre Menu_Cc (Menu_Cc_Window), nous souhaitons que le bouton de la fenêtre "Ajout CompteCourant" affiche la fenêtre correspondante "Add_Cc", pour renseigner les paramètres.
        }

        private bool CanshowWindowGetCcByIdClient(object obj)
        {
            return true;
        }

        private void ShowWindowGetCcByIdClient(object obj)
        {
            FindById_CcClient FindByIdCcClientWin = new FindById_CcClient(); // Definit ici la fenêtre à montrer
            FindByIdCcClientWin.Show();
        }

        private bool CanshowWindowAttribuerCc(object obj)
        {
            return true;
        }

        private void ShowWindowAttribuerCc(object obj)
        {
            Attribuer_Cc AttribuerCcWin = new Attribuer_Cc(); // Definit ici la fenêtre à montrer
            AttribuerCcWin.Show();
        }

        private bool CanshowWindowDepotCc(object obj)
        {
            return true;
        }

        private void ShowWindowDepotCc(object obj)
        {
            Depot_Cc DepotCcWin = new Depot_Cc(); // Definit ici la fenêtre à montrer
            DepotCcWin.Show();
        }

        private bool CanshowWindowRetraitCc(object obj)
        {
            return true;
        }

        private void ShowWindowRetraitCc(object obj)
        {
            Retrait_Cc RetraitCcWin = new Retrait_Cc(); // Definit ici la fenêtre à montrer
            RetraitCcWin.Show();
        }

        private bool CanshowWindowVirementCc(object obj)
        {
            return true;
        }

        private void ShowWindowVirementCc(object obj)
        {
            Virement_Cc VirementCcWin = new Virement_Cc(); // Definit ici la fenêtre à montrer
            VirementCcWin.Show();
        }


        /*
         * **************
         */

            // Methodes BLL
 
        public int AddCompteCourantService(CompteCourant cli, AjoutOk messageAjoutOk)
    {

            int verif = ccDal.AddCompteCourantDal(cli);
            if (verif != 0)
            {
                messageAjoutOk();
            }

            return verif;
             
           
    }

    public int AttribuerCompte(CompteCourant cc, MessageCcExistant messageCcExistant, AttributionOk attributionOk, MessageError messageErreur) // Attention liste à changer
    {
            // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table client et dans la table Cc, on ne peut pas attribuer un Cc.
            // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table client mais pas dans la table Cc, alors on attribut le cc à ce id client en ajoutant un cc dans la liste cc(appel de la methode addcc de DalCc). 
            // Par contre si l'id client n'est pas trouvé dans la liste des clients, le compte ne peut pas étre attribué et verifAttribut reste 0;


            int clientId = cc.NumClient;

        ObservableCollection<Client> listeClient = new ObservableCollection<Client>();
       ObservableCollection<CompteCourant> listeCc = new ObservableCollection<CompteCourant>();

            listeClient = cliDal.GetClientByIdDal(clientId);
            listeCc = ccDal.GetCompteCourantByClientId(clientId);


         //   listeClient = cliDal.GetAllClientDal();
          //  listeCc = ccDal.GetAllCompteCourantDal();

        int verifAttribut = 0; // Initialisation de la variable avec 0, qui va changer si le compte est attribué
            if (listeClient.Count != 0 && listeCc.Count != 0)
            {
                messageCcExistant();  // Message pour dire que ce client a déjà un compte courant

            }
            else if (listeClient.Count != 0 && listeCc.Count == 0)

            {
                verifAttribut = ccDal.AddCompteCourantDal(cc);
                attributionOk();  // Message pour dire que l'attribution est Ok
            }
            else
            {
                messageErreur();  // Message pour dire personne non identifiée. Veuillez crée d'abord un compte client.
            }

            return verifAttribut;
    }


    public int DeleteCompteCourantService(int ClientId, MessageSuppression messageSuppression, SuppressionOk suppressionOk, MessageError messageErreur)
    {
            // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

            int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
            ObservableCollection<CompteCourant> listeIdCc = new ObservableCollection<CompteCourant>();
            listeIdCc = ccDal.GetCompteCourantByClientId(ClientId);
            if (listeIdCc.Count != 0)  // Je prefère utiliser le count ici que le null, car ça ne reconnait pas le null
            {
                bool result = messageSuppression();
                //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the delete ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result) //(si ev1 est true (yes))
                {
                    verif = ccDal.DeleteCompteCourantDal(ClientId); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
                    suppressionOk();
                }
            }
            else
            {
                messageErreur();
            }

            return verif;
        }

    public int Depot(int idClient, double montant, DepotOk messageDepotOk) // Je suis obligée de faire cette méthode ici, car on ne peut pas associer 2 méthodes ensembles dans le DAL. Lorsque le SQL reader est en execution, c'est obligée de close la connexion pour executer un autre query.
    {
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach(CompteCourant e in liste) 
            {
                cc = new (e.Solde,e.NumeroCompte, e.DecouvertAutorise ,e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }
            cc.Depot(montant); // J'effectue le depot avec ce compte courant
            
            int verif = ccDal.UpdateCompteCourantDal(cc);

            if (verif != 0) // Si le depot a bien eu lieu, je verifie le resultat
            {
                messageDepotOk();
            }

            return verif;
        }

    public ObservableCollection<CompteCourant> GetAllCompteCourantService()
    //  public List<CompteCourant> GetAllCompteCourantService()
    {
        return ccDal.GetAllCompteCourantDal();
    }

    public ObservableCollection<CompteCourant> GetCompteCourantByClientIdService(int clientId, MessageError messageErreur)
    //   public List<CompteCourant> GetCompteCourantByClientIdService(int clientId)
    {
            ObservableCollection<CompteCourant> ? listeIdClient = new ObservableCollection<CompteCourant>();
            listeIdClient = ccDal.GetCompteCourantByClientId(clientId);

            if (listeIdClient.Count == 0)
            {
                messageErreur();
            }

            return listeIdClient;
    }

    public ObservableCollection<CompteCourant> GetCompteCourantByIdService(int id, MessageError messageErreur)
    {
            ObservableCollection<CompteCourant>? listeIdCc = new ObservableCollection<CompteCourant>();
            listeIdCc = ccDal.GetCompteCourantById(id);

            if (listeIdCc.Count == 0)
            {
                messageErreur();
            }

            return listeIdCc;
        }

    public int Retrait(int idClient, double montant, RetraitOk messageRetraitOk, NonRetrait messageNonRetrait)
    {
      
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteCourant e in liste)
            {
                cc = new(e.Solde, e.NumeroCompte, e.DecouvertAutorise, e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }
            
            bool verif1 = cc.Retrait(montant); // J'effectue le depot avec ce compte courant
            int verif2 = 0;

            if (verif1)
            {
                messageRetraitOk();
                verif2 = ccDal.UpdateCompteCourantDal(cc);
            }
            else
            {
                messageNonRetrait();   // Solde insuffisant
            }
            
            return verif2;
        }

    public int UpdateCompteCourantService(CompteCourant cli, MessageModification messageModification, ModificationOk modificationOk, MessageError messageErreur)
    {
            // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

            int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
            ObservableCollection<CompteCourant> listeIdClient = new ObservableCollection<CompteCourant>();
            listeIdClient = ccDal.GetCompteCourantByClientId(cli.NumClient);
            if (listeIdClient.Count != 0)
            {
                bool result = messageModification();
                //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the update ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result) //(si ev1 est true (yes))
                {
                    verif = ccDal.UpdateCompteCourantDal(cli); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
                    modificationOk();
                }
            }
            else
            {
                messageErreur();
            }

            return verif;
        }

    public int Virement(int idClient, double montant, CompteCourant cc2, VirementOk messageVirementOk, NonVirement messageNonVirement)
    {
            
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteCourant e in liste)
            {
                cc = new(e.Solde, e.NumeroCompte, e.DecouvertAutorise, e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }


            bool verif1 = cc.Virement(montant, cc2);
            int verif2 = 0;

            if (verif1)
            {
                messageVirementOk();
                verif2 = ccDal.UpdateCompteCourantDal(cc);
            }
            else
            {
                messageNonVirement();   // Solde insuffisant
            }

            return verif2;

        }
}
}
