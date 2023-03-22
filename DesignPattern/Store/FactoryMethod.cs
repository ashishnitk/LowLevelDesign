using System;
using System.Threading.Tasks;

namespace HelloWorld1
{

    interface ICarSupplier
    {
        string CarColor
        {
            get;
        }
        void GetCarModel();
    }

    class Honda : ICarSupplier
    {
        public string CarColor
        {
            get { return "RED"; }
        }

        public void GetCarModel()
        {
            Console.WriteLine("HondaCar 2014");
        }
    }

    class BMW : ICarSupplier
    {
        public string CarColor
        {
            get { return "BLACK"; }
        }

        public void GetCarModel()
        {
            Console.WriteLine("BMW 2014");
        }
    }



    static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int id)
        {
            switch (id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                default:
                    return null;
            }
        }
    }



    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee emp1 = new Employee();
    //        emp1.Id = 4;
    //        emp1.Name = "Ashish";

    //        Employee emp2 = emp1;


    //        // OPEN for Modification
    //        //Honda objHonda = new Honda();
    //        //objHonda.GetCarModel();

    //        //BMW bmw = new BMW();
    //        //bmw.GetCarModel();

    //        ICarSupplier objCarSupplier = CarFactory.GetCarInstance(5);
    //        objCarSupplier.GetCarModel();

    //        Console.WriteLine("And the color is " + objCarSupplier.CarColor);

    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
