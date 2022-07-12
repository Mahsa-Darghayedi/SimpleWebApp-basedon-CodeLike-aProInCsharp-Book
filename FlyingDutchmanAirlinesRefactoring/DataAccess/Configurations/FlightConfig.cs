using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlyingDutchmanAirlinesRefactoring.DataAccess.Configurations
{
    public class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("Flights");
            builder.HasKey("Id").HasName("FlightNumber");

            builder.Property(flight=> flight.Id)
                .HasColumnName("FlightNumber")
                .HasMaxLength(450)
                .IsRequired();


            builder.HasMany(flight => flight.Bookings)
                .WithOne(booking => booking.Flight)
                .HasForeignKey(booking => booking.FlightNumber);
        }
    }
}
