using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Cars
{
    abstract class Cars : VehicleBase
    {
        public int NumberOfDoors { get; protected set; }
        public bool isElectric { get; protected set; }

        public override void Refuel(int amount)
        {
            if (isElectric)
            {
                Console.WriteLine($"You have charged your battery by {amount} kWh.  Max power is {FuelOrBatteryCapacity} kWh.");
            }
            else
            {
                base.Refuel(amount);
            }
        }


        public override void MoveVehicle(string destination, int passengers)
        {
            if (passengers > PassengerCapacity)
            {
                Console.WriteLine($"You have exceeded the maximum capacity.  Please remove {passengers - PassengerCapacity} passengers.");
            }
            else
            {
                Console.WriteLine($"Buckle up! You are driving your car to {destination}.");
            }
        }

        public void RoadRage(string musicInput)
        {
            Console.WriteLine($"We all hate traffic, but you deal with it poorly. Play Bad Habit on your {musicInput} and scream until your face turns red.");
        }
    }
}
