using TruckPlaner.Model;

namespace TruckPlaner.Services.Interfaces
{
    public interface IPingService
    {
        public void RegisterPing(GPSPing ping, int driverId);
    }
}
