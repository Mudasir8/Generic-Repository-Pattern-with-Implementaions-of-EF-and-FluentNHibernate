using NHibernate;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Repositories.Implementations.NH
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ISession _session;

        public BaseRepository(ISession session)
        {
            _session = session;
        }

        public void AddNewRecord(T entity)
        {
            _session.Save(entity);
        }

        public IEnumerable<T> GetAllRecord()
        {
            return _session.Query<T>();
        }

        public T GetByID(int id)
        {
            //_session.CacheMode = CacheMode.Normal;
            return _session.Get<T>(id);
        }
    }
}
