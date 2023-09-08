using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_CompteBancaire2.Views_Models
{
    internal interface I_Menu_Ce_Model// Remplace ici le I_BLL_CompteEpargne
    {
        int AddCompteEpargneService(CompteEpargne cli, AjoutOk messageAjoutOk);

        int UpdateCompteEpargneService(CompteEpargne cli, MessageModification messageModification, ModificationOk modificationOk, MessageError messageErreur);

        int DeleteCompteEpargneService(int ClientId, MessageSuppression messageSuppression, SuppressionOk suppressionOk, MessageError messageErreur);

        ObservableCollection<CompteEpargne> GetAllCompteEpargneService();
        //  List<CompteEpargne> GetAllCompteEpargneService();

        ObservableCollection<CompteEpargne> GetCompteEpargneByIdService(int id, MessageError messageErreur); // Retourne compteEpargne car l'Id est unique. Sinon liste

        ObservableCollection<CompteEpargne> GetCompteEpargneByClientIdService(int clientId, MessageError messageErreur);
        // List<CompteEpargne> GetCompteEpargneByClientIdService(int clientId);

        int AttribuerCompte(CompteEpargne ce, MessageCeExistant messageCeExistant, AttributionOk attributionOk, MessageError messageErreur);

        int Depot(int idClient, double montant, DepotOk messageDepotOk);

        int Retrait(int idClient, double montant, RetraitOk messageRetraitOk, NonRetrait messageNonRetrait);

        int Virement(int idClient, double montant, CompteEpargne ce2, VirementOk messageVirementOk, NonVirement messageNonVirement);
    }
}

// Les délégués
// Obliger de declarer les délégués ici, car si je les met dans service, ils ne seront pas reconnus par l'interface. Or l'interface est un contrat.
// Vu que les autres délégués ont déjà été declarés précedemment dans le I_Menu_Client_Model, ces délégués appartiennent tous au même name.space. On ne peut pas les declarer une seconde fois, le systeme va signaler.

/* Délégués déclarés precedemment dans I_Menu_Client_Model
public delegate void AjoutOk();
public delegate void MessageError();
public delegate bool MessageSuppression();
public delegate void SuppressionOk();
public delegate bool MessageModification();
public delegate void ModificationOk(); */

/* // Délégués déclarés precedemment dans I_Menu_Cc_Model
public delegate void AttributionOk();
public delegate void DepotOk();
public delegate void RetraitOk();
public delegate void NonRetrait();
public delegate void VirementOk();
public delegate void NonVirement(); */

// Nouveaux Délégués déclarés
public delegate void MessageCeExistant();
