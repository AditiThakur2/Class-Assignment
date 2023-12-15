using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryOfEmployee
{
    internal class Manager:Employee
    {
        public double OnsiteAllowance { get; set; }
        public double Bonus { get; set; }

        public Manager(int id,string name,double salary, DateTime dateofbirth, double onsiteAllowance, double bonus):base(id,name,salary,dateofbirth)
        {
            OnsiteAllowance = onsiteAllowance;
            Bonus = bonus;
        }
        public override double ComputeSalary()
        {
            return base.ComputeSalary() + OnsiteAllowance + Bonus;
        }
    }
}
