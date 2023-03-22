using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class PartTimeEmployee : Employee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }
        public int NumberOfStudent { get; set; }
        public int pastPerformance { get; set; }
        
        public override int GetMonthlySalary() // : 55k
        {
            return this.HourlyPay * this.TotalHoursWorked / pastPerformance * NumberOfStudent;
        }
    }
}
