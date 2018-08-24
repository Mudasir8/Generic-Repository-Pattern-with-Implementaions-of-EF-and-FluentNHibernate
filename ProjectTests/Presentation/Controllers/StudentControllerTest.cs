using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Presentation.Controllers;
using System.Web.Mvc;

namespace ProjectTests.Presentation.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new StudentController(new Repositories.Implementations.NH.UnitOfWork());
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        // to check weather data returned is correct
        [TestMethod]
        public void TestDetailsViewData()
        {

            var controller = new StudentController(new Repositories.Implementations.NH.UnitOfWork());
            var result = controller.Details(2) as ViewResult;
            // 2 -> Waqar
            Student student = (Student) result.ViewData.Model;
            Assert.AreEqual("Waqar", student.FirstName);

        }

    }
}
