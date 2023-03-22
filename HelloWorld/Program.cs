using System;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee emp1 = new FullTimeEmployee();
            emp1.FirstName = "Ashsih";
            emp1.LastName = "Prasad";
            emp1.AnnualSalary = 60000;
            Console.WriteLine(emp1.GetFullName());
            Console.WriteLine(emp1.GetMonthlySalary());

            PartTimeEmployee emp = new PartTimeEmployee();
            emp.FirstName = "Tushar";
            emp.LastName = "Roy";
            emp.HourlyPay = 250;
            emp.TotalHoursWorked = 4;
            Console.WriteLine(emp.GetFullName());
            Console.WriteLine(emp.GetMonthlySalary());

            Console.WriteLine("Hello World!");
        }
    }
}
