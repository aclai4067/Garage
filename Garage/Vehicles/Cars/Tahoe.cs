using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Cars
{
    class Tahoe : Cars
    {
        public Tahoe(VehicleColor color)
        {
            FuelOrBatteryCapacity = 26;
            PassengerCapacity = 7;
            NumberOfDoors = 4;
            isElectric = false;
            Color = color;
        }
    }
}
