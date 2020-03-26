using Garage.Vehicles;
using Garage.Vehicles.Aircraft;
using Garage.Vehicles.Cars;
using Garage.Vehicles.Watercraft;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var FlyingVehicles = new List<Aircraft>()
            { 
                new HotAirBalloon(VehicleColor.Red, 8),
                new HotAirBalloon(VehicleColor.Champaign, 20),
                new ViperJet(VehicleColor.Silver),
                new ViperJet(VehicleColor.Black)
            };

            foreach (var aircraft in FlyingVehicles)
            {
                aircraft.PushTheLimit();
            }

            var WaterVehicles = new List<Watercraft>()
            {
                new Jetski(VehicleColor.LightBlue),
                new Jetski(VehicleColor.Red),
                new CruiseShip(350000, VehicleColor.White, 700),
                new CruiseShip(400000, VehicleColor.White, 500)
            };

            foreach (var vessel in WaterVehicles)
            {
                vessel.doWatercraftThings();
            }

            var RoadVehicles = new List<Cars>()
            {
                new Leaf(VehicleColor.White),
                new Leaf(VehicleColor.LightBlue),
                new Leaf(VehicleColor.Grey),
                new Tahoe(VehicleColor.Black),
                new Tahoe(VehicleColor.Red),
                new Tahoe(VehicleColor.DarkBlue)
            };

            foreach (var car in RoadVehicles)
            {
                car.RoadRage("bluetooth");
            }

            var allVehicles = new List<VehicleBase>();
            allVehicles.AddRange(RoadVehicles);
            allVehicles.AddRange(WaterVehicles);
            allVehicles.AddRange(FlyingVehicles);

            foreach (var vehicle in allVehicles)
            {
                vehicle.Refuel(25);
                vehicle.MoveVehicle("California", 7);
            }
            Console.ReadKey();
        }
    }
}
