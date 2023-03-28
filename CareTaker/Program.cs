using System;
using System.Collections.Generic;

namespace Mediator.RealWorld
{
    /// <summary>
    /// Mediator Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Passenger
            // Captain who is driving Cab
            // OLA/UBer : CabCenter()
            // nearest cab to passenger

            CabCenter cabCenter = new CabCenter();

            Passenger ankit = new Passenger("ankit", "125 Street", 10);
            Passenger vikas = new Passenger("vikas", "10 Downing street", 25);

            Cab c1 = new Cab("Cab1", 11, true);
            Cab c2 = new Cab("Cab2", 22, false);

            // Registering the cabs
            cabCenter.Register(c1);
            cabCenter.Register(c2);

            cabCenter.BookCab(ankit);
            cabCenter.BookCab(vikas);

            // Wait for user
            Console.ReadKey();
        }
    }
}
