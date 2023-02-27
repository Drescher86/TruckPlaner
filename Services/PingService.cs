using TruckPlaner.Model;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Services
{
    public class PingService : IPingService
    {
        private ITruckPlanService _truckPlanService;
        public PingService(ITruckPlanService truckPlanService)
        {
            _truckPlanService = truckPlanService;
        }
        public void RegisterPing(GPSPing ping, int driverId)
        {
            throw new NotImplementedException();
        }
    }
}
