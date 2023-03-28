using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.RealWorld
{

    internal class CabCenter
    {
        private readonly Dictionary<string, ICab> cabRegister = new Dictionary<string, ICab>();

        internal void Register(Cab cab)
        {
            if (!cabRegister.ContainsValue(cab))
            {
                cabRegister.Add(cab.Name, cab);
            }
        }

        internal void BookCab(Passenger passenger)
        {
            foreach (var cab in cabRegister.Values.Where(a => a.IsFree))
            {
                if (IsWith5MileRadius(cab.CurrentLocation, passenger.Location))
                {
                    cab.Assign(passenger.Name, passenger.Address);
                }
            }
        }

        private bool IsWith5MileRadius(int cabLocation, int passengerLocation)
        {
            return Math.Abs(cabLocation - passengerLocation) < 5;
        }
    }
}