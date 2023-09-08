using Models.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_DAL.Dao_DAL_Client
{
    public interface I_DAL_Client
    {
         int AddClientDal(Client cli);

         int UpdateClientDal(Client cli);

        int DeleteClientDal(int id);

        ObservableCollection<Client> GetAllClientDal();
        // List<Client> GetAllClientDal();

        ObservableCollection<Client> GetClientByIdDal(int id);
    }
}
