using Models.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_CompteBancaire2.Views_Models
{
    public interface I_Menu_Client_Model
    {
        int AddClientBll(Client cli, AjoutOk messageAjoutOk);

        int UpdateClientBll(Client cli, MessageModification messageModification, ModificationOk modificationOk, MessageError messageErreur);

        int DeleteClientBll(int id, MessageSuppression messageSuppression, SuppressionOk suppressionOk, MessageError messageErreur);

         ObservableCollection<Client> GetAllClientBll();
        // Je met en commentaire car on aura pas besoin de faire appel à cette méthode, vu que notre liste est dejà placée dans le constructeur pour qu'il affiche la liste automatiquement sur le gridView par l'instanciation de la classe

        ObservableCollection<Client> GetClientByIdBll(int id, MessageError messageErreur);
    }
}

// Les délégués
// Obligée declarer le délégué ici, car si je le met dans service, il ne sera pas reconnu par l'interface. Or l'interface est un contrat.public delegate bool MessageModification();
public delegate void AjoutOk(); 
public delegate void MessageError();
public delegate bool MessageSuppression();
public delegate void SuppressionOk();
public delegate bool MessageModification();
public delegate void ModificationOk();
