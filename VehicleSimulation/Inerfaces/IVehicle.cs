using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSimulation.Inerfaces
{
    public interface IVehicle
    {
        public string Name { get;}
        public string Move();
        public string GetIn();
        public string GetOff();
        
    }
}
