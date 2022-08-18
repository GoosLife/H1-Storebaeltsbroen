using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Storebæltsbroen
{
    public enum VehicleType
    {
        Motorcycle,
        Car,
        Bus,
        Truck
    }
    internal class Vehicle
    {
        private VehicleType type;
        public VehicleType Type
        {
            get { return type; }
            private set { type = value; }
        }

        public Vehicle(int type)
        {
            Type = (VehicleType)type;
        }

        /// <summary>
        /// Returns how many wheels are on a specific type of vehicle.
        /// </summary>
        /// <param name="type">The type of vehicle to check.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetWheelAmount(VehicleType type)
        {
            switch(type)
            {
                case VehicleType.Motorcycle:
                    return 2;
                case VehicleType.Car:
                    return 4;
                case VehicleType.Bus:
                case VehicleType.Truck:
                    return 6;
                default:
                    throw new Exception("Invalid vehicle type");
            }
        }
    }
}
