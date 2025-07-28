using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSimulation.Inerfaces;

namespace VehicleSimulation.Vehicles
{
    public class Bike : IVehicle
    {
        public string Name { get; } = "Bike";
        public string Move()
        {
            return $"{Name} Riding";
        }
        public string GetIn()
        {
            return $"Getting on the {Name}";
        }
        public string GetOff()
        {
            return $"Getting off the {Name}";
        }
        
        
    }
}
