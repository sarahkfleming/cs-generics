using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public class BatteryStation : IRefuelingStation<ElectricVehicle>
    {
        public int Capacity { get; set; }

        public void Refuel(List<ElectricVehicle> vehicles)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Available Charging Ports: {Capacity}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            foreach (var vehicle in vehicles)
            {
                Capacity -= 1;
                Console.WriteLine($"The {vehicle.MakeAndModel} has been recharged to {vehicle.ChargeCapacity} kWh.");
            }
            Console.WriteLine($"Available Charging Ports: {Capacity}");
        }
    }
}