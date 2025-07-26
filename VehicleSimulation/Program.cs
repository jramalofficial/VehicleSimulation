using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace VehicleSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PlayGround playGround = new PlayGround();
            playGround.StartGame();
        }
    }
}
