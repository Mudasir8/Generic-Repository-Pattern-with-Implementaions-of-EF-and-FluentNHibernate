using DAL;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContextEF _context;
        public IStudentRepository Students { get; private set; }

        public UnitOfWork()
        {
            _context = new DataContextEF();
            // uses the same context
            Students = new StudentRepository(_context);
        }

        public void CommitChanges()
        {
             _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
