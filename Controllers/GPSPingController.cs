using TruckPlaner.Model;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Controllers
{
    public class GPSPingController
    {
        private ITruckPlanService _truckPlanService;
        public GPSPingController(ITruckPlanService truckPlanService) 
        {
            _truckPlanService = truckPlanService;
        }
        public void PingTruckPlan(GPSPing ping, int driverId)
        {
            _truckPlanService.AddPing(ping, driverId);
        }
    }
}
