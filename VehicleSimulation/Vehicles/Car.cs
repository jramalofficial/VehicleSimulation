using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSimulation.Inerfaces;

namespace VehicleSimulation.Vehicles
{
    public class Car:IVehicle
    {
        public string Name { get; } = "ECar";
        public string Move()
        {
            return $"{Name} Driving";
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
