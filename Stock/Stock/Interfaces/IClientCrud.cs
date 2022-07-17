using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Interfaces
{
    interface IClientCrud
    {
        void Create(Client client);
        void Update(int id, Client user);
        void Delete(int id);
        Client Read(int id);
    }
}
