using System;

namespace H1_Storebæltsbroen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bridge b = new Bridge(new SpawnManager().SpawnManyVehicles(100)); // Create a new bridge and populate it with 100 random vehicles
            Console.WriteLine("Total amount of wheels on bridge: " + new WheelCounter().TotalWheelsOnBridge(b.MotorcycleCount, b.CarCount, b.BusCount, b.TruckCount)); // Output the total amount of wheels on the bridge
        }
    }
}
