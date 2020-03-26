using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles.Aircraft
{
    class HotAirBalloon : Aircraft
    {
        public HotAirBalloon(VehicleColor color, int passengersCapacity)
        {
            MaxAltitude = 68986;
            FuelOrBatteryCapacity = 30;
            Color = color;
            PassengerCapacity = passengersCapacity;
        }

        public override void MoveVehicle(string destination, int passengers)
        {
            if (passengers > PassengerCapacity)
            {
                Console.WriteLine($"You have exceeded the maximum capacity.  Please remove {PassengerCapacity - passengers} passengers from the basket.");
            }
            else
            {
                Console.WriteLine($"Up we go! You are flying to {destination}.");
            }
        }
    }
}
