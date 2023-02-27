using Microsoft.AspNetCore.Mvc;
using TruckPlaner.Services;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Controllers
{
    [ApiController]
    public class TruckPlanController : Controller
    {
        private ITruckPlanService _truckPlanService;
        public TruckPlanController(ITruckPlanService truckPlanService)
        {
            _truckPlanService = truckPlanService;
        }
    }
}
