using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class EmployeeClass
    {
        private string name;
        private string department;
        private string role;

        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }
        public string EmployeeDepartment
        {
            get { return department; }
            set { department = value; }
        }
        public string Designation
        {
            get { return role; }
            set { role = value; }
        }

        public double Salary { get; set; }
        public string EmploymentType { get; set; }
        
        public virtual double CalculateSalary()
        {
            return 10000;
        }

        public double GetBonus()
        {
            return 1000;
        }
    }

    interface IBonus { public double GetBonus();  }
    public class PermanentEmployee : EmployeeClass, IBonus
    {
        public override double CalculateSalary()
        {
            return base.CalculateSalary()*5;
        }

        public new double GetBonus()
        {
            return (CalculateSalary()*10)/100;
        }
    }

    public class ContractualEmployee : EmployeeClass, IBonus
    {
        public override double CalculateSalary()
        {
            return base.CalculateSalary()*2.6;
        }
        public new double GetBonus()
        {
            return (CalculateSalary() * 5) / 100;
        }
    }
}
