using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Storebæltsbroen
{
    internal class WheelCounter
    {
        /// <summary>
        /// Counts the total number of wheels currently on the bridge, based on what vehicles are currently on it.
        /// </summary>
        /// <param name="motorcycleCount"></param>
        /// <param name="carCount"></param>
        /// <param name="busCount"></param>
        /// <param name="truckCount"></param>
        /// <returns></returns>
        public int TotalWheelsOnBridge(int motorcycleCount, int carCount, int busCount, int truckCount)
        {
            return (motorcycleCount * Vehicle.GetWheelAmount(VehicleType.Motorcycle)) +
                   (carCount * Vehicle.GetWheelAmount(VehicleType.Car)) +
                   (busCount * Vehicle.GetWheelAmount(VehicleType.Bus)) +
                   (truckCount * Vehicle.GetWheelAmount(VehicleType.Truck));
        }
    }
}