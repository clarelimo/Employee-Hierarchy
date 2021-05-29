using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Hierarchy_Project
{
    public class Employees
    {
        public string employeeId, managerId;
        public int employeeSalary;
       
        public Employees(string[] employeesInfo)
        {
            int n = employeesInfo.Length;
            List<string> managers = new List<string>();
            List<string> employees = new List<string>();
            int ceo = 0;
      
            for(int i = 1; i<n; i++)
            {
                string[] employeesData = employeesInfo[i].Split(',');
                this.employeeId = employeesData[0];
                this.managerId = employeesData[1];
               
                if(!(Int32.TryParse(employeesData[2], out employeeSalary)))
                {
                    throw new Exception("The slaries should be intergers.");
                }
                
                if (employees.Contains(employeeId))
                {
                    throw new Exception("One employee does not report to more than one manager");
                }
                else
                {
                    employees.Add(employeeId);
                }

                if (!string.IsNullOrEmpty(managerId))
                {
                    managers.Add(managerId);
                }
                else
                {
                    ceo++;
                }
            }

            if (ceo > 1)
            {
                throw new Exception("There can only be one ceo");
            }

            foreach (var manager in managers)
            {
                if (!employees.Contains(manager)) 
                {
                    throw new Exception("There is no manager that is not an employee");
                }
            }
        }
        public long salaryBudget(string manager, string[] employeeInfo)
        {
            long sum = 0;
            foreach (var emp in employeeInfo)
            {
                employeeId = emp[0].ToString();
                managerId = emp[1].ToString();
                employeeSalary = int.Parse(emp[2].ToString());

                if(manager == managerId || manager == employeeId)
                {
                    sum += employeeSalary;
                }

            }
            return sum;
        }
    }
}
