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
    }
}
