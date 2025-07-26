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
        public string Name { get; } = "Car";
        public string Move()
        {
            return "Car Driving";
        }
        public string GetIn()
        {
            return "Getting in the Car";
        }
        public string GetOff()
        {
            return "Getting off the Car";
        }
    }
}
