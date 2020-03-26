using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Aircraft
{
    abstract class Aircraft : VehicleBase
    {
        public int MaxAltitude { get; set; }

        public override void MoveVehicle(string destination, int passengers)
        {
            if (passengers > PassengerCapacity)
            {
                Console.WriteLine($"You have exceeded the maximum capacity.  Please remove {PassengerCapacity - passengers} passengers.");
            }
            else
            {
                Console.WriteLine($"Return your seat to it's upright position! You are flying to {destination}.");
            }
        }

        public void PushTheLimit()
        {
            Console.WriteLine($"You are flying at your maximum altitude of {MaxAltitude} feet!!");
        }
    }
}
