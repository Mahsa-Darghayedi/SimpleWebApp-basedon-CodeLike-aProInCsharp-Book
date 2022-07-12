using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FlyingDutchmanAirlinesRefactoring.DataAccess.Context
{
    public class FlyingDutchManDbContext : DbContext
    {
        public FlyingDutchManDbContext(DbContextOptions options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FlyingDutchManDbContext).Assembly);
        }
    }
}
