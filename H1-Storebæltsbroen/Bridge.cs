using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Storebæltsbroen
{
    internal class Bridge
    {
        private Vehicle[] vehicles;
        /// <summary>
        /// Array of all vehicles currently on bridge
        /// </summary>
        public Vehicle[] Vehicles
        {
            get { return vehicles; }
            private set { vehicles = value; }
        }

        private int motorcycleCount;
        /// <summary>
        /// Total amount of motorcycles on the bridge
        /// </summary>
        public int MotorcycleCount
        {
            get { return motorcycleCount; }
            private set { motorcycleCount = value; }
        }

        private int carCount;
        /// <summary>
        /// Total amount of cars on the bridge
        /// </summary>
        public int CarCount
        {
            get { return carCount; }
            private set { carCount = value; }
        }

        private int busCount;
        /// <summary>
        /// Total amount of busses on the bridge.
        /// </summary>
        public int BusCount
        {
            get { return busCount; }
            private set { busCount = value; }
        }

        private int truckCount;
        /// <summary>
        /// Total amount of trucks on the bridge.
        /// </summary>
        public int TruckCount
        {
            get { return truckCount; }
            private set { truckCount = value; }
        }

        public Bridge(Vehicle[] vehicles)
        {
            Vehicles = vehicles;

            // Find out how many of each vehicle type is on the bridge
            MotorcycleCount = vehicles.Where(v => v.Type == VehicleType.Motorcycle).Count();
            CarCount = vehicles.Where(v => v.Type == VehicleType.Car).Count();
            BusCount = vehicles.Where(v => v.Type == VehicleType.Bus).Count();
            TruckCount = vehicles.Where(v => v.Type == VehicleType.Truck).Count();
        }
    }
}
