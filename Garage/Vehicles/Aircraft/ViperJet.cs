using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Aircraft
{
    class ViperJet : Aircraft
    {
        public ViperJet(VehicleColor color)
        {
            MaxAltitude = 30000;
            FuelOrBatteryCapacity = 300;
            Color = color;
            PassengerCapacity = 2;
        }
    }
}
