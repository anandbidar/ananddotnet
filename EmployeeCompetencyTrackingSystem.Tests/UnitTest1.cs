using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeCompetencyTrackingSystem.Controllers;
using System.Web.Mvc;
using EmployeeCompetencyTrackingSystem.Models;
using System.Collections.Generic;

namespace EmployeeCompetencyTrackingSystem.Tests
{
    [TestClass]
    public class UnitTestEmployeeCompetencyController
    {
        [TestMethod]
        public void TestIndex()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult) _EmployeeCompetencyController.Index();
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(6, count);
        }
        [TestMethod]
        public void TestDetailsByEid()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByEmployeeId(1000);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void TestDetailsByCid()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByCompetencyId(1);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(4, count);
        }
    }
}
