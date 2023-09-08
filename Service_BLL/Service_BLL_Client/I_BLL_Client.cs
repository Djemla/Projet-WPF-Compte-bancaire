using Dao_DAL.Dao_DAL_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Client;
using System.Collections.ObjectModel;

namespace Service_BLL.Service_BLL_Client
{
    public interface I_BLL_Client
    {
        
        int AddClientBll(Client cli);

        int UpdateClientBll(Client cli);

        int DeleteClientBll(int id);

        // List<Client> GetAllClientBll();
        ObservableCollection<Client> GetAllClientBll();
        // Je met en commentaire car on aura pas besoin de faire appel à cette méthode, vu que notre liste est dejà placée dans le constructeur pour qu'il affiche la liste automatiquement sur le gridView par l'instanciation de la classe

        ObservableCollection<Client> GetClientByIdBll(int id);
    }

    
}
