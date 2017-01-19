using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    interface IRepository<T>
    {
        T GetById(Guid Id);
        void Add(T root);
        void Delete(T root);
    }
}
