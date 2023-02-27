using TruckPlaner.Model;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Services
{
    public class DistanceCalculator : IDistanceCalculator
    {
        public double CalculateDistanceBetweenGpsPoints(GPSPing ping1, GPSPing ping2)
        {
            //I don't know how to calculate the distance between two gps points
            return Random.Shared.NextDouble() * 5;
        }
    }
}
