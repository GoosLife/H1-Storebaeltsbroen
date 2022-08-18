using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Storebæltsbroen
{
    internal class SpawnManager
    {
        public SpawnManager() { }

        /// <summary>
        /// Create a single new vehicle of a random type.
        /// </summary>
        /// <returns></returns>
        public Vehicle SpawnVehicle()
        {
            Random r = new Random();
            int amountOfVehicles = Enum.GetNames(typeof(VehicleType)).Length;

            Vehicle v = new Vehicle(r.Next(amountOfVehicles));
            return v;
        }

        /// <summary>
        /// Spawns the specified amount of vehicles, each with a random type.
        /// </summary>
        /// <param name="amount">Amount of vehicles to spawn.</param>
        /// <returns></returns>
        public Vehicle[] SpawnManyVehicles(int amount)
        {
            Vehicle[] vehicles = new Vehicle[amount];

            for (int i = 0; i < amount; i++)
            {
                Vehicle v = SpawnVehicle();
                vehicles[i] = v;
            }

            return vehicles;
        }
    }
}
