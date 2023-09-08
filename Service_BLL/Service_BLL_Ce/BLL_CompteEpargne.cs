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

namespace Service_BLL.Service_BLL_Ce
{
    public class BLL_CompteEpargne : I_BLL_CompteEpargne
    {
        private I_DAL_CompteEpargne ceDal = new DAL_CompteEpargne();
        private I_DAL_Client cliDal = new DAL_Client(); // J'aurai besoin de la liste client que le DALClient va me fournir à travers SQL, pour verifier l'attribution d'un nouveau compte ou non



        public int AddCompteEpargneService(CompteEpargne cli)
        {
            return ceDal.AddCompteEpargneDal(cli);
        }

        public int AttribuerCompte(int clientId, CompteEpargne ce) // Liste à changer
        {
             ObservableCollection<Client> liste = new ObservableCollection<Client>();
          //  List<Client> liste = new List<Client>();
            liste = cliDal.GetAllClientDal();

            int verifAttribut = 0; // Initialisation de la variable avec 0, qui va changer si le compte est attribué

            foreach (Client e in liste)
            {
                // Mettre l'id client qu'on veut attribuer le compte dans une variable
                if (clientId == e.Id)
                {                                                        // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table, alors on attribut le cc à ce id client en ajoutant un cc dans la liste cc(appel de la methode addcc de DalCc). 
                    verifAttribut = ceDal.AddCompteEpargneDal(ce);       // Par contre si l'id client n'est pas trouvé dans la liste des clients, le compte ne peut pas étre attribué et verifAttribut reste 0;
                }

            }

            return verifAttribut;
        }

        public int DeleteCompteEpargneService(int id)
        {
            return ceDal.DeleteCompteEpargneDal(id);
        }

        public int Depot(int idClient, double montant)
        {
            CompteEpargne ce = new CompteEpargne();
            ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
            liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteEpargne e in liste)
            {
                ce = new CompteEpargne(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
            }
            ce.Depot(montant); // J'effectue le depot avec ce compte Epargne

            int verif = ceDal.UpdateCompteEpargneDal(ce);

            if (verif != 0) // Si le depot a bien eu lieu, je verifie le resultat
            {
                Console.WriteLine( "Le depot est ok");
            }

            return verif;
        }

        public ObservableCollection<CompteEpargne> GetAllCompteEpargneService()
          //  public List<CompteEpargne> GetAllCompteEpargneService()
        {
            return ceDal.GetAllCompteEpargneDal();
        }

         public ObservableCollection<CompteEpargne> GetCompteEpargneByClientIdService(int clientId)
         //   public List<CompteEpargne> GetCompteEpargneByClientIdService(int clientId)
        {
            return ceDal.GetCompteEpargneByClientId(clientId);
        }

        public ObservableCollection<CompteEpargne> GetCompteEpargneByIdService(int id)
        {
            return ceDal.GetCompteEpargneById(id);
        }

        public int Retrait(int idClient, double montant)
        {
            CompteEpargne ce = new CompteEpargne();
            ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
            liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteEpargne e in liste)
            {
                ce = new CompteEpargne(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
            }

            bool verif1 = ce.Retrait(montant); // J'effectue le depot avec ce compte Epargne
            int verif2 = 0;

            if (verif1)
            {
                Console.WriteLine( "Le retrait est Ok");
                verif2 = ceDal.UpdateCompteEpargneDal(ce);
            }
            else
            {
                Console.WriteLine( "Retrait KO. Solde insuffisant");
            }

            return verif2;
        }

        public int UpdateCompteEpargneService(CompteEpargne cli)
        {
            return ceDal.UpdateCompteEpargneDal(cli);
        }

        public int Virement(int idClient, double montant, CompteEpargne ce2)
        {
            CompteEpargne ce = new CompteEpargne();
            ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
            liste = ceDal.GetCompteEpargneByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteEpargne e in liste)
            {
                ce = new CompteEpargne(e.Solde, e.NumeroCompte, e.TauxEpargne, e.NumClient); // Je stocque le resultat de cette liste dans un compte Epargne.
            }


            bool verif1 = ce.Virement(montant, ce2);
            int verif2 = 0;

            if (verif1)
            {
                Console.WriteLine( "Le virement est Ok");
                verif2 = ceDal.UpdateCompteEpargneDal(ce);
            }
            else
            {
                Console.WriteLine( "Le virement est KO. Solde insuffisant");
            }

            return verif2;
        }
    }
}
