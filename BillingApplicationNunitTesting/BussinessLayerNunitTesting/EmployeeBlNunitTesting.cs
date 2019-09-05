using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BillingApplication.Context;

namespace BillingApplicationNunitTesting.BussinessLayerNunitTesting
{

    [TestClass]
    public class EmployeeBlNunitTesting
    {
        [TestMethod]
        public void GetEmployeeListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetEmployeeList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetBussinessUnitListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetBussinessUnitList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetcategoryListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetcategoryList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetDomainListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetDomainList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetReportingListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetReportingList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

        [TestMethod]
        public void GetStatusListfromEmployeeBussinessLayer()
        {
            //arrange
            EmployeeBl employeebl = new EmployeeBl();

            //act
            var a = employeebl.GetStatusList();

            //assert
            NUnit.Framework.Assert.IsNotNull(a);

        }

    }
}
