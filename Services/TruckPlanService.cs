using System.Linq.Expressions;
using TruckPlaner.Context;
using TruckPlaner.Model;
using TruckPlaner.Services.Interfaces;

namespace TruckPlaner.Services
{
    public class TruckPlanService : ITruckPlanService
    {
        private readonly DatabaseContext _databaseContext;
        public TruckPlanService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void AddPing(GPSPing ping, int driverId)
        {
            try
            {
                var currentPlan = _databaseContext.TruckPlans.Where(p => p.IsActive && p.Driver.Id == driverId).First();
                currentPlan.GPSPings.Add(ping);
                _databaseContext.SaveChanges();
            }
            catch(Exception ex) 
            {
                //plan is not found
            }
        }

        public List<GPSPing> GetPings(Expression<Func<GPSPing, bool>> expression)
        {
            return _databaseContext.GPSPings.Where(expression).ToList();
        }
    }
}
