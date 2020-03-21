using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Watercraft
{
    abstract class Watercraft : VehicleBase
    {
        public Watercraft(int powerCapacity, VehicleColor color, int passengersCapacity)
        {
            FuelOrBatteryCapacity = powerCapacity;
            Color = color;
            PassengerCapacity = passengersCapacity;
        }

        public override void MoveVehicle(string destination, int passengers)
        {
            if (passengers > PassengerCapacity)
            {
                Console.WriteLine($"You have exceeded the maximum capacity.  Please remove {PassengerCapacity - passengers} passengers.");
            }
            else
            {
                Console.WriteLine($"Ahoy Cap'n! You are cruising through the waves to {destination}.");
            }
        }
    }
}
