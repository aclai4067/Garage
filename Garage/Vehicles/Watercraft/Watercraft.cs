using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Watercraft
{
    abstract class Watercraft : VehicleBase
    {
        public string Material { get; set; }


        public override void MoveVehicle(string destination, int passengers)
        {
            if (passengers > PassengerCapacity)
            {
                Console.WriteLine($"You have exceeded the maximum capacity.  Please remove {passengers - PassengerCapacity} passengers.");
            }
            else
            {
                Console.WriteLine($"Ahoy Cap'n! You are cruising through the waves to {destination}.");
            }
        }

        public abstract void doWatercraftThings();
    }
}
