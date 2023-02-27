using Microsoft.EntityFrameworkCore;
using System.Data;
using TruckPlaner.Model;

namespace TruckPlaner.Context
{
    public class DatabaseContext:DbContext
    {
        public DbSet<TruckPlan> TruckPlans { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<GPSPing> GPSPings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
