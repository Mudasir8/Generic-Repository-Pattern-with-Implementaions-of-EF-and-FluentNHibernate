using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations.EF
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void AddNewRecord(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllRecord()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
