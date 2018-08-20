using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    // now we can mock these interface for Unit Testing
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        void CommitChanges();
    }
}
