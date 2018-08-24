using DAL.NH;
using NHibernate;
using Repositories.Interfaces;
using System;

namespace Repositories.Implementations.NH
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISession _session;
        public IStudentRepository Students { get; private set; }

        public UnitOfWork()
        {
            _session = DataContextNH.SessionOpen();
            Students = new StudentRepository(_session);
        }


        public void CommitChanges()
        {
            _session.BeginTransaction().Commit();
        }

        public void Dispose()
        {
            _session.Dispose();
        }

       
    }
}
