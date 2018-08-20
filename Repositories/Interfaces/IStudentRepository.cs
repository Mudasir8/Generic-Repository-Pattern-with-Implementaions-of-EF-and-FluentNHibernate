using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        // since this interface inherits from our Generic BaseRepository 
        // here we will be able to use all the functions of BaseRepository like Add, Delete GetByID etc
        // also it has further functions related to Student entity only like GetTopStudent
        Student GetTopStudent();
    }
}
