using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_DAL.Dao_DAL_Ce
{
    public interface I_DAL_CompteEpargne
    {
        int AddCompteEpargneDal(CompteEpargne cli);

        int UpdateCompteEpargneDal(CompteEpargne cli);

        int DeleteCompteEpargneDal(int id);

        ObservableCollection<CompteEpargne> GetAllCompteEpargneDal();
        //  List<CompteEpargne> GetAllCompteEpargneDal();

        ObservableCollection<CompteEpargne> GetCompteEpargneById(int id); // L'id est unique, ça retourne un seul compte

        ObservableCollection<CompteEpargne> GetCompteEpargneByClientId(int clientId); // Liste ici car un client peut avoir plusieurs comptes courants
                                                                                      //  List<CompteEpargne> GetCompteEpargneByClientId(int clientId);


        // int attribuerCompte(Client cli, CompteEpargne ce); A faire dans service qui appelera ajoutCe au cas où

        //   int Depot(int idClient, double montant); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

        //   int Retrait(int idClient, double montant); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

        //   int Virement(int idClient, double montant, CompteEpargne ce2); // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.

    }
}
