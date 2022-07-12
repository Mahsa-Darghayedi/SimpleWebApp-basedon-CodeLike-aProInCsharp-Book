using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlyingDutchmanAirlinesRefactoring.DataAccess.Configurations
{
    internal class AirportConfig : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("Airports");

            builder.HasKey("Id")
                .HasName("AirportID");

            builder.Property(airport => airport.Id)
                            .ValueGeneratedOnAdd()
                            .HasColumnName("AirportID");

            builder.Property(airport => airport.City)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(airport => airport.IATA)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasMany(airport => airport.FlightsOrigin)
                .WithOne(flight => flight.AirportOrigin)
                .HasForeignKey(flight => flight.Origin);


            builder.HasMany(airport => airport.FlightsDestination)
                         .WithOne(flight => flight.AirportDestination)
                         .HasForeignKey(fligh => fligh.Destination);


        }
    }
}
