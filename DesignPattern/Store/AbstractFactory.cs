
using System;

namespace RealWorld1
{
    public interface IBike
    {

    }

    public interface ICar
    {

    }

    public class TataCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Tata car");
        }
    }

    public class TataBike : IBike
    {
        public void Manufacture() { }
    }

    public class TeslaCar : ICar
    {
        public void Manufacture() { }
    }

    public class TeslaBike : IBike
    {
        public void Manufacture() { }
    }


    /// <summary>
    /// This is abstract factory which will return factiry of similar objects
    /// </summary>
    public abstract class VehicleCompany
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }


    public class TeslaCompany : VehicleCompany
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override ICar GetCar()
        {
            return new TeslaCar();
        }
    }

    public class TataCompany : VehicleCompany
    {
        public override IBike GetBike()
        {
            return new TataBike();
        }

        public override ICar GetCar()
        {
            return new TataCar();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        VehicleCompany tesla = new TeslaCompany();
    //        IBike bike = tesla.GetBike();
    //        ICar car = tesla.GetCar();

    //        VehicleCompany tata = new TataCompany();
    //        tata.GetBike();
    //        tata.GetCar();


    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
