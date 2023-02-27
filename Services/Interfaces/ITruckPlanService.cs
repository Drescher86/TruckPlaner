using System.Linq.Expressions;
using TruckPlaner.Model;

namespace TruckPlaner.Services.Interfaces
{
    public interface ITruckPlanService
    {
        public void AddPing(GPSPing ping, int driverId);
        public List<GPSPing> GetPings(Expression<Func<GPSPing, bool>> expression);
    }
}
