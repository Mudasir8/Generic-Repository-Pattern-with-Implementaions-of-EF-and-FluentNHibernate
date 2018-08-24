using Models;
using Newtonsoft.Json;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularSPA.Controllers
{
    public class StudentController : Controller
    {
        // DI is provided by IoCBuilder class using AutoFac for NH implementaion of IUnitOfWork in "Project.Repositories.Implementations.NH" using AutoFac DI
        IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

        public string GetStudentByID(int? id)
        {
            if (!id.HasValue)
            {
                return null;
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(_unitOfWork.Students.GetByID(id.Value));
        }

        public string GetStudentsList()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_unitOfWork.Students.GetAllRecord().ToList());
        }

        public string AddNewStudent(string firtName, string lastName)
        {
            try
            {
                Student st = new Student
                {
                    FirstName = firtName,
                    LastName = lastName
                };
                _unitOfWork.Students.AddNewRecord(st);
                _unitOfWork.CommitChanges();
                return JsonConvert.SerializeObject(true);
            }
            catch (Exception)
            {

                return JsonConvert.SerializeObject(false);
            }

        }

        public string DeleteStudentByID(int id)
        {
            try
            {
                _unitOfWork.Students.DeleteByID(id);
                _unitOfWork.CommitChanges();
                return JsonConvert.SerializeObject(true);
            }
            catch (Exception)
            {

                return JsonConvert.SerializeObject(false);
            }
            
        }
    }
}