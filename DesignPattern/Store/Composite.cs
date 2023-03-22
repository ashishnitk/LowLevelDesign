
using System;
using System.Collections.Generic;

namespace RealWorld134w
{
    interface IEmployee
    {
        void GetDetails();
    }

    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(string name, string dept)
        {
            Name = name;
            Department = dept;
        }

        public void GetDetails()
        {
            Console.WriteLine("My details are " + Name + ". My Depat is " + Department);
        }
    }

    class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }
        public Manager(string name, string dept, List<IEmployee> subOrdinates)
        {
            Name = name;
            Department = dept;
            SubOrdinates = subOrdinates;
        }

        public void GetDetails()
        {
            Console.WriteLine("My details are " + Name + ". My Depat is " + Department);

            foreach (var item in SubOrdinates)
            {
                item.GetDetails();
            }

        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        IEmployee jhon = new Employee("jhon", "IT");
    //        IEmployee mike = new Employee("mike", "IT");
    //        IEmployee jason = new Employee("jason", "IT");
    //        IEmployee eric = new Employee("jhon", "IT");
    //        IEmployee henry = new Employee("henry", "IT");
    //        IEmployee tushar = new Employee("tushar", "IT");
    //        IEmployee james = new Manager("James", "ManagerSKS", new List<IEmployee>() { jhon, mike, jason });


    //        IEmployee philip = new Manager("philip", "ManagerIT", new List<IEmployee> { tushar, henry, eric });
    //        IEmployee bob = new Manager("bob", "Head", new List<IEmployee> { james, philip });
    //        //IEmployee bob = new Manager("bob", "Head") { SubOrdinates = { James, philip } };

    //        // bob -> philip,James
    //        // phhilip -> json....
    //        // james

    //        bob.GetDetails();

    //        // bob.GetDetails();
    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
