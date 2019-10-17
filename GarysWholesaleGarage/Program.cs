using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // In your main method, make sure you have a list of electric vehicles, and a list of gas vehicles.
            
            
            
            List<GasPoweredVehicle> gasGuzzlers = new List<GasPoweredVehicle>()
            {
                new GasPoweredVehicle()
                {
                    MakeAndModel = "Ford Explorer",
                    GasTankCapacity = 15.5      
                },
                new GasPoweredVehicle()
                {
                    MakeAndModel = "Dodge Ram",
                    GasTankCapacity = 18.1      
                },
                new GasPoweredVehicle()
                {
                    MakeAndModel = "Cadillac Escalade",
                    GasTankCapacity = 14.9                          
                }
            };
            
            List<ElectricVehicle> electricCars = new List<ElectricVehicle>()
            {
                new ElectricVehicle()
                {
                    MakeAndModel = "Chevy Bolt",
                    ChargeCapacity = 14
                },
                new ElectricVehicle()
                {
                    MakeAndModel = "Nissan Leaf",
                    ChargeCapacity = 9
                },
                new ElectricVehicle()
                {
                    MakeAndModel = "Tesla Whatever",
                    ChargeCapacity = 17                    
                }
            };

            // Create an instance of BatteryStation and GasStation.
            BatteryStation electricCharge = new BatteryStation()
            {
                Capacity = 3
            };
            
            GasStation gasNGo = new GasStation()
            {
                Capacity = 15
            };

            //Refuel all the vehicles by sending them to the correct refueling station.
            
            electricCharge.Refuel(electricCars);
            gasNGo.Refuel(gasGuzzlers);
        }
    }
}
