using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_BLL.Service_BLL_Ce
{
    public interface I_BLL_CompteEpargne
    {
        int AddCompteEpargneService(CompteEpargne cli);

        int UpdateCompteEpargneService(CompteEpargne cli);

        int DeleteCompteEpargneService(int id);

         ObservableCollection<CompteEpargne> GetAllCompteEpargneService();
        //  List<CompteEpargne> GetAllCompteEpargneService();

        ObservableCollection<CompteEpargne> GetCompteEpargneByIdService(int id); // Retourne CompteEpargne car l'Id est unique. Sinon liste

        ObservableCollection<CompteEpargne> GetCompteEpargneByClientIdService(int clientId);
       // List<CompteEpargne> GetCompteEpargneByClientIdService(int clientId);

        int AttribuerCompte(int ClientId, CompteEpargne ce);

       int Depot(int idClient, double montant);

        int Retrait(int idClient, double montant);

       int Virement(int idClient, double montant, CompteEpargne ce2);
    }
}
