using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSimulation.Inerfaces;

namespace VehicleSimulation.Vehicles
{
    public class Bus:IVehicle
    {
        public string Name { get; } = "bus";
        public string Move()
        {
            return "Bus Driving";
        }
        public string GetIn()
        {
            return "Getting on the Bus";
        }
        public string GetOff()
        {
            return "Getting off the Bus";
        }
    }
}
