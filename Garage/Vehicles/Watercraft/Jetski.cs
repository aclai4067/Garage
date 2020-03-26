using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Watercraft
{
    class Jetski : Watercraft
    {
        public Jetski(VehicleColor color)
        {
            Material = "fiberglass";
            FuelOrBatteryCapacity = 16;
            Color = color;
            PassengerCapacity = 2;
        }

        public override void doWatercraftThings()
        {
            Console.WriteLine($"Your jumped your {Color} jetski over some sweet waves!");
        }
    }
}
