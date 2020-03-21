using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles
{
    abstract class VehicleBase
    {
        public int FuelOrBatteryCapacity { get; protected set; }
        public VehicleColor Color { get; protected set; }
        public int PassengerCapacity { get; protected set; }

        public virtual void Refuel(int amount)
        {
            if (amount <= FuelOrBatteryCapacity)
            {
                Console.WriteLine($"You have added {amount} gallons of fuel out of a maximum capacity of {FuelOrBatteryCapacity} gallons.");
            }
            else
            {
                Console.WriteLine($"You have added {amount} gallons of fuel and spilled it everywhere because you are over the maximum capacity of {FuelOrBatteryCapacity}.");
            }  
        }

        public abstract void MoveVehicle(string destination, int passengers);
    }
}
