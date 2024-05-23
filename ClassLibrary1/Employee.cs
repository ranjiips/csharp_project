using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersClasses
{
    public class Employee
    {
        public string Name;
        public string Designation;
        public int Salary;
        public string Location;
        public bool WillingToTravel;
    }

    public class EmployeeDetails
    {
        List<Employee> employees;
        public void AddEmployee()
        {
            employees = new List<Employee>
            {
                new Employee{Name="Ranjith Kumar",Designation = "SDET Lead", Salary =500000, Location ="Chennai", WillingToTravel= true },
                new Employee{Name="Vikram",Designation = "SDET", Salary =300000, Location ="Chennai", WillingToTravel= false },
                new Employee{Name="Kalai",Designation = "SDET", Salary =300000, Location ="Bangalore", WillingToTravel= true },
                new Employee{Name="Venkat",Designation = "Manager", Salary =800000, Location ="Hyderabad", WillingToTravel= false },
                new Employee{Name="Prabha",Designation = "QA", Salary =100000, Location ="USA", WillingToTravel= false }

            };

        }       
        
        public void GetEmployeeDetails()
        {
            AddEmployee();
            //var employee = employees.Where(e => e.Designation.Equals("SDET")).Select(r => r.Name).ToList();
            var employee = employees.Where(e => e.WillingToTravel.Equals(true)).Select(r =>r).ToList();
            //Console.WriteLine("SDET Resources are" + string.Join(",", employee));

            Console.WriteLine("Employees who are willing to travel " + string.Join(",", employee.Select(r=>r.Name)));
        }
       
    }
}
