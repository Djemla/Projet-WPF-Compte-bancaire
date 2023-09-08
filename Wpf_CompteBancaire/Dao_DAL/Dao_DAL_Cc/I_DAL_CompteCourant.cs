using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_DAL.Dao_DAL_Cc
{
    public interface I_DAL_CompteCourant
    {
        int AddCompteCourantDal(CompteCourant cli);

        int UpdateCompteCourantDal(CompteCourant cli);

        int DeleteCompteCourantDal(int id);

        ObservableCollection<CompteCourant> GetAllCompteCourantDal();
        //  List<CompteCourant> GetAllCompteCourantDal();

        ObservableCollection<CompteCourant> GetCompteCourantById(int id); 

         ObservableCollection<CompteCourant> GetCompteCourantByClientId(int clientId); // Liste ici car un client peut avoir plusieurs comptes courants
                                                                                       // List<CompteCourant> GetCompteCourantByClientId(int clientId);


        // int attribuerCompte(Client cli, CompteCourant cc); A faire dans service qui appelera ajoutCc au cas où

        // int Depot(int idClient, double montant); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

        // int Retrait(int idClient, double montant); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

        //  int Virement(int idClient, double montant, CompteCourant cc2); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

    }
}
