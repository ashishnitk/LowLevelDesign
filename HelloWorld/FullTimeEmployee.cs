using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class FullTimeEmployee : Employee
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
