namespace TruckPlaner.Model
{
    public class GPSPing
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Longitude { get; set; }
        public Decimal Latitude { get; set; }

        public int TruckPlanId { get; set; }
        public TruckPlan TruckPlan { get; set; }
    }
}
