using Dao_DAL.Dao_DAL_Ce;
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
using Wpf_CompteBancaire2.Windows_Views.Each_Window_Menu_Ce;

namespace Wpf_CompteBancaire2.Views_Models
{
    public class Menu_Ce_Model : I_Menu_Ce_Model
    { 
    public I_DAL_CompteEpargne ceDal = new DAL_CompteEpargne();
    public I_DAL_Client cliDal = new DAL_Client(); // J'aurai besoin de la liste client que le DALClient va me fournir à travers SQL, pour verifier l'attribution d'un nouveau compte ou non



    // Menu_Ce_Model (BLL CompteEpargne) ici va definir la fenêtre MenuClient Window, cad fe,être qui apparait après avoir cliqué sur MenuClient.

    public static ObservableCollection<CompteEpargne>? ListeAllCompteEpargne { get; set; } // C'est cette propriété qui stocquera notre liste à chaque fois que cette classe (Menu_Ce_Model) sera instanciée, et qui sera renvoyée à notre gridview.
                                                                                           // Menu_Ce_Model est l'une de nos classes secondaire que le MainViewModel appelera 'd'où le nom Main view Model)
                                                                                           // Declaration des propriétés commandes (ShowWindowCommand) qui seront executées sur la page Menu_CompteEpargne
    public ICommand? ShowWindowCommandAddCe { get; set; }  // Propriété qui sera executée lorsqu'on va cliquer sur le bouton (Menu client) pour faire appel à une autre fenêtre qui aura le detail du menu.
    public ICommand? ShowWindowCommandUpdateCe { get; set; }
    public ICommand? ShowWindowCommandDeleteCe { get; set; }
    public ICommand? ShowWindowCommandGetCeById { get; set; }
    public ICommand? ShowWindowCommandGetCeByIdClient { get; set; }
    public ICommand? ShowWindowCommandAttribuerCe { get; set; }
    public ICommand? ShowWindowCommandDepotCe { get; set; }
    public ICommand? ShowWindowCommandRetraitCe { get; set; }
    public ICommand? ShowWindowCommandVirementCe { get; set; }

    // public ICommand ShowWindowCommandGetAllClient { get; set; } // Pas besoin ici car on a déjà la liste qui va s'afficher sur la page d'aceeuil, grace à l'instanciation de cette classe BLL Client


    // Creation du constructeur de cette classe 
    // Vu que cette classe est notre model view du Menu client, toutes les données de cette classe correspondra aux dataContext du Menu client window.
    // Et vu que ca correspond au DataContext du Client Window, on veux qu'à chaque fois que cette classe sera appelée pour une methode une autre, la liste soit actualisée pour notre GridView Menu client automatiquement dans la fenêtre Menu Client Window.
    // Et les boutons du Menu Client Window pourront faire appel à chaque fenêtre respective

    public Menu_Ce_Model()
    {
        ListeAllCompteEpargne = ceDal.GetAllCompteEpargneDal(); // Vu que c'est dejà instancier ici, appel de la méthode getAllClient de Dal via le eDal

        ShowWindowCommandAddCe = new RelayCommand(ShowWindowAddCe, CanshowWindowAddCe);
        ShowWindowCommandUpdateCe = new RelayCommand(ShowWindowUpdateCe, CanshowWindowUpdateCe);
        ShowWindowCommandDeleteCe = new RelayCommand(ShowWindowDeleteCe, CanshowWindowDeleteCe);
        ShowWindowCommandGetCeById = new RelayCommand(ShowWindowGetCeById, CanshowWindowGetCeById);
        ShowWindowCommandGetCeByIdClient = new RelayCommand(ShowWindowGetCeByIdClient, CanshowWindowGetCeByIdClient);
        ShowWindowCommandAttribuerCe = new RelayCommand(ShowWindowAttribuerCe, CanshowWindowAttribuerCe);
        ShowWindowCommandDepotCe = new RelayCommand(ShowWindowDepotCe, CanshowWindowDepotCe);
        ShowWindowCommandRetraitCe = new RelayCommand(ShowWindowRetraitCe, CanshowWindowRetraitCe);
        ShowWindowCommandVirementCe = new RelayCommand(ShowWindowVirementCe, CanshowWindowVirementCe);

    }

    private bool CanshowWindowAddCe(object obj)
    {
        return true;
    }

    private void ShowWindowAddCe(object obj)
    {

        Add_Ce AddCeWin = new Add_Ce(); // Definit ici la fenêtre à montrer
        AddCeWin.Show();

        // On sait de nature qu'une classe peut être typée.
        // Le type utilisée ici est le nom de la classe (de la fenêtre) qu'on souhaite affichée. Ca sera rattaché au différents boutons correspondants du Menu_Ce_Window
        // Par exemble sur la fenêtre Menu_Ce (Menu_Ce_Window), nous souhaitons que le bouton de la fenêtre "Ajout CompteEpargne" affiche la fenêtre correspondante "Add_Ce", pour renseigner les paramètres.  
    }

    private bool CanshowWindowUpdateCe(object obj)
    {
        return true;
    }

    private void ShowWindowUpdateCe(object obj)
    {
        Update_Ce UpdateCeWin = new Update_Ce(); // Definit ici la fenêtre à montrer
        UpdateCeWin.Show();
    }

    private bool CanshowWindowDeleteCe(object obj)
    {
        return true;
    }

    private void ShowWindowDeleteCe(object obj)
    {
        Delete_Ce DeleteCeWin = new Delete_Ce(); // Definit ici la fenêtre à montrer
        DeleteCeWin.Show();
    }

    private bool CanshowWindowGetCeById(object obj)
    {
        return true;
    }

    private void ShowWindowGetCeById(object obj)
    {
        FindById_Ce FindByIdCeWin = new FindById_Ce(); // Definit ici la fenêtre à montrer
        FindByIdCeWin.Show();

        // On sait de nature qu'une classe peut être typée.
        // Le type utilisée ici est le nom de la classe (de la fenêtre) qu'on souhaite affichée. Ca sera rattaché au différents boutons correspondants du Menu_Ce_Window
        // Par exemble sur la fenêtre Menu_Ce (Menu_Ce_Window), nous souhaitons que le bouton de la fenêtre "Ajout CompteEpargne" affiche la fenêtre correspondante "Add_Ce", pour renseigner les paramètres.
    }

    private bool CanshowWindowGetCeByIdClient(object obj)
    {
        return true;
    }

    private void ShowWindowGetCeByIdClient(object obj)
    {
        FindById_CeClient FindByIdCeClientWin = new FindById_CeClient(); // Definit ici la fenêtre à montrer
        FindByIdCeClientWin.Show();
    }

    private bool CanshowWindowAttribuerCe(object obj)
    {
        return true;
    }

    private void ShowWindowAttribuerCe(object obj)
    {
        Attribuer_Ce AttribuerCeWin = new Attribuer_Ce(); // Definit ici la fenêtre à montrer
        AttribuerCeWin.Show();
    }

    private bool CanshowWindowDepotCe(object obj)
    {
        return true;
    }

    private void ShowWindowDepotCe(object obj)
    {
        Depot_Ce DepotCeWin = new Depot_Ce(); // Definit ici la fenêtre à montrer
        DepotCeWin.Show();
    }

    private bool CanshowWindowRetraitCe(object obj)
    {
        return true;
    }

    private void ShowWindowRetraitCe(object obj)
    {
        Retrait_Ce RetraitCeWin = new Retrait_Ce(); // Definit ici la fenêtre à montrer
        RetraitCeWin.Show();
    }

    private bool CanshowWindowVirementCe(object obj)
    {
        return true;
    }

    private void ShowWindowVirementCe(object obj)
    {
        Virement_Ce VirementCeWin = new Virement_Ce(); // Definit ici la fenêtre à montrer
        VirementCeWin.Show();
    }


    /*
     * **************
     */

    // Methodes BLL

    public int AddCompteEpargneService(CompteEpargne cli, AjoutOk messageAjoutOk)
    {

        int verif = ceDal.AddCompteEpargneDal(cli);
        if (verif != 0)
        {
            messageAjoutOk();
        }

        return verif;


    }

    public int AttribuerCompte(CompteEpargne ce, MessageCeExistant messageCeExistant, AttributionOk attributionOk, MessageError messageErreur) // Attention liste à changer
    {
        // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table client et dans la table Ce, on ne peut pas attribuer un Ce.
        // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table client mais pas dans la table Ce, alors on attribut le ce à ce id client en ajoutant un ce dans la liste ce(appel de la methode addce de DalCe). 
        // Par contre si l'id client n'est pas trouvé dans la liste des clients, le compte ne peut pas étre attribué et verifAttribut reste 0;


        int clientId = ce.NumClient;

        ObservableCollection<Client> listeClient = new ObservableCollection<Client>();
        ObservableCollection<CompteEpargne> listeCe = new ObservableCollection<CompteEpargne>();

        listeClient = cliDal.GetClientByIdDal(clientId);
        listeCe = ceDal.GetCompteEpargneByClientId(clientId);


        //   listeClient = cliDal.GetAllClientDal();
        //  listeCe = ceDal.GetAllCompteEpargneDal();

        int verifAttribut = 0; // Initialisation de la variable avec 0, qui va changer si le compte est attribué
        if (listeClient.Count != 0 && listeCe.Count != 0)
        {
            messageCeExistant();  // Message pour dire que ce client a déjà un compte Epargne

        }
        else if (listeClient.Count != 0 && listeCe.Count == 0)

        {
            verifAttribut = ceDal.AddCompteEpargneDal(ce);
            attributionOk();  // Message pour dire que l'attribution est Ok
        }
        else
        {
            messageErreur();  // Message pour dire personne non identifiée. Veuillez crée d'abord un compte client.
        }

        return verifAttribut;
    }


    public int DeleteCompteEpargneService(int ClientId, MessageSuppression messageSuppression, SuppressionOk suppressionOk, MessageError messageErreur)
    {
        // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

        int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
        ObservableCollection<CompteEpargne> listeIdCe = new ObservableCollection<CompteEpargne>();
        listeIdCe = ceDal.GetCompteEpargneByClientId(ClientId);
        if (listeIdCe.Count != 0)  // Je prefère utiliser le count ici que le null, car ça ne reconnait pas le null
        {
            bool result = messageSuppression();
            //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the delete ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result) //(si ev1 est true (yes))
            {
                verif = ceDal.DeleteCompteEpargneDal(ClientId); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
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
        CompteEpargne ce = new CompteEpargne();
        ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
        liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
        foreach (CompteEpargne e in liste)
        {
            ce = new(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
        }
        ce.Depot(montant); // J'effectue le depot avec ce compte Epargne

        int verif = ceDal.UpdateCompteEpargneDal(ce);

        if (verif != 0) // Si le depot a bien eu lieu, je verifie le resultat
        {
            messageDepotOk();
        }

        return verif;
    }

    public ObservableCollection<CompteEpargne> GetAllCompteEpargneService()
    //  public List<CompteEpargne> GetAllCompteEpargneService()
    {
        return ceDal.GetAllCompteEpargneDal();
    }

    public ObservableCollection<CompteEpargne> GetCompteEpargneByClientIdService(int clientId, MessageError messageErreur)
    //   public List<CompteEpargne> GetCompteEpargneByClientIdService(int clientId)
    {
        ObservableCollection<CompteEpargne>? listeIdClient = new ObservableCollection<CompteEpargne>();
        listeIdClient = ceDal.GetCompteEpargneByClientId(clientId);

        if (listeIdClient.Count == 0)
        {
            messageErreur();
        }

        return listeIdClient;
    }

    public ObservableCollection<CompteEpargne> GetCompteEpargneByIdService(int id, MessageError messageErreur)
    {
        ObservableCollection<CompteEpargne>? listeIdCe = new ObservableCollection<CompteEpargne>();
        listeIdCe = ceDal.GetCompteEpargneById(id);

        if (listeIdCe.Count == 0)
        {
            messageErreur();
        }

        return listeIdCe;
    }

    public int Retrait(int idClient, double montant, RetraitOk messageRetraitOk, NonRetrait messageNonRetrait)
    {

        CompteEpargne ce = new CompteEpargne();
        ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
        liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
        foreach (CompteEpargne e in liste)
        {
            ce = new(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
        }

        bool verif1 = ce.Retrait(montant); // J'effectue le depot avec ce compte Epargne
        int verif2 = 0;

        if (verif1)
        {
            messageRetraitOk();
            verif2 = ceDal.UpdateCompteEpargneDal(ce);
        }
        else
        {
            messageNonRetrait();   // Solde insuffisant
        }

        return verif2;
    }

    public int UpdateCompteEpargneService(CompteEpargne cli, MessageModification messageModification, ModificationOk modificationOk, MessageError messageErreur)
    {
        // Je vais d'abord faire appel à la méthode recherche ici. S'il le trouve, je place le message. Et si oui, je fait appel à la méthode supprimer, sinon je fait rien. Et s'il ne trouve pas, je fait appel au message d'erreur

        int verif = 0; // J'initialise cette variable à 0, qui va changer si la suppression a bien lieu.
        ObservableCollection<CompteEpargne> listeIdClient = new ObservableCollection<CompteEpargne>();
        listeIdClient = ceDal.GetCompteEpargneByClientId(cli.NumClient);
        if (listeIdClient.Count != 0)
        {
            bool result = messageModification();
            //  ev 1: MessageBoxResult result = MessageBox.Show("Do you agree the update ?", "Avertissement!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result) //(si ev1 est true (yes))
            {
                verif = ceDal.UpdateCompteEpargneDal(cli); // En fait lorsqu'on stocke dans une variable, le compilateur execute d'abord le programme avant de stocker le resultat.
                modificationOk();
            }
        }
        else
        {
            messageErreur();
        }

        return verif;
    }

    public int Virement(int idClient, double montant, CompteEpargne ce2, VirementOk messageVirementOk, NonVirement messageNonVirement)
    {

        CompteEpargne ce = new CompteEpargne();
        ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
        liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
        foreach (CompteEpargne e in liste)
        {
            ce = new(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
        }


        bool verif1 = ce.Virement(montant, ce2);
        int verif2 = 0;

        if (verif1)
        {
            messageVirementOk();
            verif2 = ceDal.UpdateCompteEpargneDal(ce);
        }
        else
        {
            messageNonVirement();   // Solde insuffisant
        }

        return verif2;

    }
}
}
