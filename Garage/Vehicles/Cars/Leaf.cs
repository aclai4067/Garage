using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Cars
{
    class Leaf : Cars
    {
        public Leaf(VehicleColor color)
        {
            FuelOrBatteryCapacity = 62;
            PassengerCapacity = 5;
            NumberOfDoors = 4;
            isElectric = true;
            Color = color;
        }
    }
}
