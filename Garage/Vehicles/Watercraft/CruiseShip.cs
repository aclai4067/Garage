using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Watercraft
{
    class CruiseShip : Watercraft
    {
        public CruiseShip(int powerCapacity, VehicleColor color, int passengersCapacity)
        {
            Material = "steel";
            FuelOrBatteryCapacity = powerCapacity;
            Color = color;
            PassengerCapacity = passengersCapacity;
        }

        public override void doWatercraftThings()
        {
            Console.WriteLine($"Blow your big boat horn to tell the little boats to get out of the way!");
        }
    }
}
