using TruckPlaner.Model;

namespace TruckPlaner.Services.Interfaces
{
    public interface IDistanceCalculator
    {
        public double CalculateDistanceBetweenGpsPoints(GPSPing ping1, GPSPing ping2);
    }
}
