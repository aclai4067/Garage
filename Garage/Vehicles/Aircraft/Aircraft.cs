using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Aircraft
{
    abstract class Aircraft : VehicleBase
    {
        public Aircraft(int powerCapacity, VehicleColor color, int passengersCapacity)
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
                Console.WriteLine($"Return your seat to it's upright position! You are flying to {destination}.");
            }
        }
    }
}
