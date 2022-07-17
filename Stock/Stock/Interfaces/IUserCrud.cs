using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Interfaces
{
    interface IUserCrud
    {
        void Create(User user);
        void Update(int id, User user);
        void Delete(int id);
        User Read(int id);
    }
}
