using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BillingApplication.Controllers;

namespace BillingApplicationNunitTesting.ControllerNunitTesting
{
    [TestClass]
    public class EmployeeListControllerNunitTesting
    {
        [TestMethod]
        public void EmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.EmployeeList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }


        [TestMethod]
        public void GetBussinessUnitfromEmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.GetBussinessUnitList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetcategoryfromEmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.GetcategoryList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetDomainListfromEmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.GetDomainList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetReportingListfromEmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.GetReportingList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetStatusListfromEmployeeListController()
        {
            //arrange
            EmployeeListController employeeListController = new EmployeeListController();

            //act
            var a = employeeListController.GetStatusList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

       


    }
}
