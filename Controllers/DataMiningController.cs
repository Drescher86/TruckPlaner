using Microsoft.AspNetCore.Mvc;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Controllers
{
    [ApiController]
    public class DataMiningController
    {
        private IDistanceCalculator _distanceCalculator;
        private ITruckPlanService _truckPlanService;
        public DataMiningController(IDistanceCalculator distanceCalculator, ITruckPlanService truckPlanService)
        {
            _truckPlanService = truckPlanService;
            _distanceCalculator = distanceCalculator;
        }

        public double FindKilometersDriven()
        {
            
        }
    }
}
