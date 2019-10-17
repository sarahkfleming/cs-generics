using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public class GasStation : IRefuelingStation<GasPoweredVehicle>
    {
        public int Capacity { get; set; }

        public void Refuel(List<GasPoweredVehicle> vehicles)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Available Fuel Pumps: {Capacity}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {
                Capacity -= 1;
                Console.WriteLine($"The {vehicle.MakeAndModel} has been refueled with {vehicle.GasTankCapacity} gallons of gas.");
            }
            Console.WriteLine($"Available Fuel Pumps: {Capacity}");
        }
    }
}