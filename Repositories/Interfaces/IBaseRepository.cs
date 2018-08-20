using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetByID(int id);
        IEnumerable<T> GetAllRecord();
        void AddNewRecord(T entity);
    }
}
