namespace TruckPlaner.Model
{
    public class Driver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public ICollection<TruckPlan> TruckPlans { get; set; }

    }
}
