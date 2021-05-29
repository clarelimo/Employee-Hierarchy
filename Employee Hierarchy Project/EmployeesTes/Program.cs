using System;
using System.Collections.Generic;
using Employee_Hierarchy_Project;

namespace EmployeesTes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empInfo = System.IO.File.ReadAllLines(@"C:\Users\Tech Jargon\Desktop\TechnoBrain\Employee-Hierarchy\csv\EmployeesInfo.csv");
            Employees emp = new Employees(empInfo);
            var employee = new List<Employees>();
            int n = empInfo.Length;
            for (int i = 1; i < n; i++)
            {
                employee.Add(emp);
            }
            
            for(int i=0;i<employee.Count;i++){
                Console.WriteLine(employee[i]);
            }
        }
    }
}
