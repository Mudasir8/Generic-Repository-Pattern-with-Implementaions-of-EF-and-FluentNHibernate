using DAL;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations.EF
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {

        // to give the base context in BaseRepository that takes context DbContext in constuctor
        // will take DataContextEF and will pass to base class that is BaseRepository
        public StudentRepository(DataContextEF context) : base(context)
        {

        }

        // for simplicity not to use _context as DataContextEF every time
        public DataContextEF DataContextEF
        {
            // here _context is from Generic BaseRepository
            get { return _context as DataContextEF; }
        }

        public Student GetTopStudent()
        {
            //(_context as DataContextEF).Students.LastOrDefault();
            return DataContextEF.Students.LastOrDefault();
        }

    }
}
