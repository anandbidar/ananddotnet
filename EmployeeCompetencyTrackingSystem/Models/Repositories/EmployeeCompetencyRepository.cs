using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCompetencyTrackingSystem.Models.Repositories
{
    public class EmployeeCompetencyRepository
    {
        private List<EmployeeCompetence> employeeCompetencies = new List<EmployeeCompetence>();
        public EmployeeCompetencyRepository()
        {
            InitializeEmployeeCompetencies();
        }

        private void InitializeEmployeeCompetencies()
        {
            GetDatausingStub();
            //GetDatausingDB();
        }

        private void GetDatausingStub()
        {
            var emp1 = new EmployeeCompetence { EmployeeId = 1000, EmployeeIName = "Roja", CompetencyId = 1, CompetencyName = "C#", CompetencyRating = 8 };
            var emp2 = new EmployeeCompetence { EmployeeId = 1001, EmployeeIName = "Sheela", CompetencyId = 1, CompetencyName = "C#", CompetencyRating = 6 };
            var emp3 = new EmployeeCompetence { EmployeeId = 1002, EmployeeIName = "Ganesh", CompetencyId = 2, CompetencyName = "Java", CompetencyRating = 8 };
            var emp4 = new EmployeeCompetence { EmployeeId = 1003, EmployeeIName = "Mary", CompetencyId = 3, CompetencyName = "Asp.Net MVC", CompetencyRating = 8 };
            var emp5 = new EmployeeCompetence { EmployeeId = 1004, EmployeeIName = "Rahul", CompetencyId = 2, CompetencyName = "Java", CompetencyRating = 4 };
            var emp6 = new EmployeeCompetence { EmployeeId = 1005, EmployeeIName = "Rashmi", CompetencyId = 1, CompetencyName = "C#", CompetencyRating = 9 };
            employeeCompetencies.Add(emp1);
            employeeCompetencies.Add(emp2);
            employeeCompetencies.Add(emp3);
            employeeCompetencies.Add(emp4);
            employeeCompetencies.Add(emp5);
            employeeCompetencies.Add(emp6);

        }
        public List<EmployeeCompetence> GetAllEmployeesCometencies()
        {
            return employeeCompetencies;
        }
        public List<EmployeeCompetence> GetAllEmployeeCometenciesByEmployeeId(int employeeId)
        {
            return employeeCompetencies.Where(e => e.EmployeeId == employeeId).ToList();
        }
        public List<EmployeeCompetence> GetAllEmployeesCometenciesByCompetencyId(int competencyId)
        {
            return employeeCompetencies.Where(e => e.CompetencyId == competencyId).ToList();
        }
    }
}