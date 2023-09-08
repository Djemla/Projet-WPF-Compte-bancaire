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
    public interface I_BLL_CompteCourant
    {
        int AddCompteCourantService(CompteCourant cli);

        int UpdateCompteCourantService(CompteCourant cli);

        int DeleteCompteCourantService(int id);

        ObservableCollection<CompteCourant> GetAllCompteCourantService();
        // List<CompteCourant> GetAllCompteCourantService();

        ObservableCollection<CompteCourant> GetCompteCourantByIdService(int id); // Retourne compteCourant car l'Id est unique. Sinon liste

        ObservableCollection<CompteCourant> GetCompteCourantByClientIdService(int clientId);
      //  List<CompteCourant> GetCompteCourantByClientIdService(int clientId);

        int AttribuerCompte(int ClientId, CompteCourant cc);

        int Depot(int idClient, double montant);

        int Retrait(int idClient, double montant);

        int Virement(int idClient, double montant, CompteCourant cc2);
    }
}
