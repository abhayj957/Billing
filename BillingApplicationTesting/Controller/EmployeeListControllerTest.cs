using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BillingApplication.Controllers;
using System.Web.Mvc;

namespace BillingApplicationTesting.Controller
{
    [TestClass]
    public class EmployeeListControllerTest
    {
        [TestMethod]
        public void EmployeeList()
        {
            //arrange
            EmployeeListController controller = new EmployeeListController();

            //act
            ViewResult result = controller.EmployeeList() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

    }
}
