using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VehicleSimulation.Inerfaces;
using VehicleSimulation.Vehicles;

namespace VehicleSimulation
{
    public class PlayGround
    {
        private readonly IServiceProvider _provider;

        public PlayGround(IServiceProvider provider)
        {
            _provider = provider;
        }
        
        public void StartGame()
        {
            Dictionary<string, Func<IVehicle>> vehicles = new()
            {
                { "c", () => _provider.GetRequiredService<Car>() },
                { "b", () => _provider.GetRequiredService<Bike>() },
                { "u", () => _provider.GetRequiredService<Bus>() }
            };
            Dictionary<string, string> keyBindings = new()
            {
                {"e","exit"},
                {"uparrow","move"},
                {"t","throw"}
            };
            IVehicle currentVehicle = null;

            Console.WriteLine("Enter the Name of the Player");
            string name = Console.ReadLine();

            var player = new Player(name);

            Console.WriteLine("Instructions");

            Console.WriteLine("UpArrow => Move");
            Console.WriteLine("C => Get Car");
            Console.WriteLine("B => Get Bike");
            Console.WriteLine("U => Get Bus");
            Console.WriteLine("U => Throw the vehicle");
            Console.WriteLine("E => Exit the Game\n\n\n");


            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                var key = keyInfo.Key.ToString().ToLower();


                if (vehicles.TryGetValue(key, out var getVehicle))
                {
                    currentVehicle = getVehicle();
                    Console.WriteLine(currentVehicle.GetIn());

                }
                else if (keyBindings.TryGetValue(key, out var action) && action == "move")
                {
                    if (currentVehicle != null)
                    {
                        Console.WriteLine(currentVehicle.Move());
                    }
                    else
                    {
                        Console.WriteLine(player.Walk());
                    }
                }
                else if (keyBindings.TryGetValue(key, out action) && action == "throw")
                {
                    if (currentVehicle != null)
                    {
                        Console.WriteLine(currentVehicle.GetOff());
                        currentVehicle = null;
                    }
                    else
                    {
                        Console.WriteLine("There is no vehicle");
                    }
                }
                else if (keyBindings.TryGetValue(key, out action) && action == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Key");
                }
            }
        }
    }
}
