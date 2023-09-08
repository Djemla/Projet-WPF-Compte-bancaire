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

namespace Service_BLL.Service_BLL_Cc
{
    public class BLL_CompteCourant : I_BLL_CompteCourant
    {
        private I_DAL_CompteCourant ccDal = new DAL_CompteCourant();
        private I_DAL_Client cliDal = new DAL_Client(); // J'aurai besoin de la liste client que le DALClient va me fournir à travers SQL, pour verifier l'attribution d'un nouveau compte ou non

        

        public int AddCompteCourantService(CompteCourant cli)
        {
            return ccDal.AddCompteCourantDal(cli);
        }

        public int AttribuerCompte(int clientId, CompteCourant cc) // Attention liste à changer
        {
            ObservableCollection<Client> liste = new ObservableCollection<Client>();
           // List<Client> liste = new List<Client>();
            liste = cliDal.GetAllClientDal();

            int verifAttribut = 0; // Initialisation de la variable avec 0, qui va changer si le compte est attribué

            foreach (Client e in liste)
            {
                 // Mettre l'id client qu'on veut attribuer le compte dans une variable
                if (clientId == e.Id)
                {                                                        // Si l'id client qu'on veut attribuer le compte fait partir d'un id client renseigné dans la table, alors on attribut le cc à ce id client en ajoutant un cc dans la liste cc(appel de la methode addcc de DalCc). 
                    verifAttribut = ccDal.AddCompteCourantDal(cc);       // Par contre si l'id client n'est pas trouvé dans la liste des clients, le compte ne peut pas étre attribué et verifAttribut reste 0;
                }
               
            }

            return verifAttribut;
        }

        public int DeleteCompteCourantService(int id)
        {
            return ccDal.DeleteCompteCourantDal(id);
        }

       public int Depot(int idClient, double montant)
        {
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteCourant e in liste)
            {
                cc = new CompteCourant(e.Solde, e.NumeroCompte, e.DecouvertAutorise, e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }
            cc.Depot(montant); // J'effectue le depot avec ce compte courant

            int verif = ccDal.UpdateCompteCourantDal(cc);

            if (verif != 0) // Si le depot a bien eu lieu, je verifie le resultat
            {
                Console.WriteLine( "Le depot est Ok");
            }

            return verif;
        } 

        public ObservableCollection<CompteCourant> GetAllCompteCourantService()
         // public List<CompteCourant> GetAllCompteCourantService()
        {
            return ccDal.GetAllCompteCourantDal();
        }

        public ObservableCollection<CompteCourant> GetCompteCourantByClientIdService(int clientId)
         // public List<CompteCourant> GetCompteCourantByClientIdService(int clientId)
        {
            return ccDal.GetCompteCourantByClientId(clientId);
        }

        public ObservableCollection<CompteCourant> GetCompteCourantByIdService(int id)
        {
            return ccDal.GetCompteCourantById(id);
        }

        public int Retrait(int idClient, double montant)
        {
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteCourant e in liste)
            {
                cc = new CompteCourant(e.Solde, e.NumeroCompte, e.DecouvertAutorise, e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }

            bool verif1 = cc.Retrait(montant); // J'effectue le depot avec ce compte courant
            int verif2 = 0;

            if (verif1)
            {
                Console.WriteLine( "Le retrait est Ok");
                verif2 = ccDal.UpdateCompteCourantDal(cc);
            }
            else
            {
                Console.WriteLine( "Le retrait est KO. Solde insuffisant");
            }

            return verif2;
        } 

        public int UpdateCompteCourantService(CompteCourant cli)
        {
            return ccDal.UpdateCompteCourantDal(cli);
        }

        public int Virement(int idClient, double montant, CompteCourant cc2)
        {
            CompteCourant cc = new CompteCourant();
            ObservableCollection<CompteCourant> liste = new ObservableCollection<CompteCourant>();
            liste = ccDal.GetCompteCourantByClientId(idClient); // le retour de cette méthode est une liste. Je suis obligée de stocquer dans une liste pour exploiter le résultat.
            foreach (CompteCourant e in liste)
            {
                cc = new CompteCourant(e.Solde, e.NumeroCompte, e.DecouvertAutorise, e.NumClient); // Je stocque le resultat de cette liste dans un compte courant.
            }


            bool verif1 = cc.Virement(montant, cc2);
            int verif2 = 0;

            if (verif1)
            {
                Console.WriteLine( "Le virement est Ok");
                verif2 = ccDal.UpdateCompteCourantDal(cc);
            }
            else
            {
                Console.WriteLine( "Le virement est KO. Solde insuffisant");
            }

            return verif2;
        } 
    }
}
