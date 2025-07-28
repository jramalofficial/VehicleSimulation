using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using VehicleSimulation.Vehicles;

namespace VehicleSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();

            service.AddTransient<Car>();
            service.AddTransient<Bus>();
            service.AddTransient<Bike>();
            service.AddTransient<Cycle>();
            service.AddTransient<PlayGround>();

            var serviceProvider = service.BuildServiceProvider();

           
            var game = serviceProvider.GetRequiredService<PlayGround>();
            game.StartGame();
        }
    }
}
