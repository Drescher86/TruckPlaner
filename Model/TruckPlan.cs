namespace TruckPlaner.Model
{
    public class TruckPlan
    {
        public int Id { get; set; }
        public Driver Driver { get; set; }
        public bool IsActive { get; set; }
        public ICollection<GPSPing> GPSPings { get; set; }
    }
}
