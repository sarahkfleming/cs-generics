using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public interface IRefuelingStation<TVehicle>
    {
        int Capacity { get; set; }
        
        void Refuel(List<TVehicle> vehicles); 
    }
}