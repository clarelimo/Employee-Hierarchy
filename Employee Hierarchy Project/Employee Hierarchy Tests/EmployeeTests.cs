using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Employee_Hierarchy_Project;

namespace Employee_Hierarchy_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void validIntegers()
        {
            string[] csv = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(csv);
            int actualSal = 500;
            Assert.AreEqual(actualSal.GetType(), emp.employeeSalary.GetType());
        }
        
        [TestMethod]
        public void validSalayBudgetEmp1()
        {           
            string[] csv = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(csv);
            int expectedBudget = 2800;
            long actualBudget = emp.salaryBudget("Employee1", csv);
            Assert.AreEqual(expectedBudget, actualBudget);
        }

        [TestMethod]
        public void validSalayBudgetEmp2()
        {
            string[] csv = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(csv);
            int expectedBudget = 1500;
            long actualBudget = emp.salaryBudget("Employee2", csv);
            Assert.AreEqual(expectedBudget, actualBudget);
        }

        [TestMethod]
        public void validSalayBudgetEmp3()
        {
            string[] csv = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(csv);
            int expectedBudget = 800;
            long actualBudget = emp.salaryBudget("Employee3", csv);
            Assert.AreEqual(expectedBudget, actualBudget);
        }

        [TestMethod] 
        public void NumberOfCeos()
        {
            string[] csv = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(csv);
            int ceos = emp.ceo;
            Assert.AreEqual(1, ceos);
        }
    }
}
