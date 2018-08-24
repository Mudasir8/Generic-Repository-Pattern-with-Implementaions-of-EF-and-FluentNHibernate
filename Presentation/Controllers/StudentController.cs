using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
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
            IEnumerable<Student> students = _unitOfWork.Students.GetAllRecord();
            return View(students);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            return View("Details", _unitOfWork.Students.GetByID(id.Value));

        }

        public ActionResult AddNew()
        {
            return View();
        }

        public bool AddNewStudent(string firtName, string lastName)
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
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}