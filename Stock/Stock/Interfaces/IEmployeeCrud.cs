using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Interfaces
{
    interface IEmployeeCrud
    {
        void Create(Employee employee);
        void Update(int id, Employee employee);
        void Delete(int id);
        Employee Read(int id);
    }
}
