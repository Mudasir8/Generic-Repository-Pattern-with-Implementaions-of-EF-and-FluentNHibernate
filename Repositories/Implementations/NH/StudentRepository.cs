using Models;
using NHibernate;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations.NH
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(ISession session) : base(session) { }

        public Student GetTopStudent()
        {
            return _session.Query<Student>().LastOrDefault();
        }
    }
}
