using FlyingDutchmanAirlinesRefactoring.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlyingDutchmanAirlinesRefactoring.DataAccess.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey("Id").HasName("CustomerID");

            builder.Property(customer=> customer.Id).HasColumnName("CustomerID").IsRequired();

            builder.Property(customer=> customer.Name).HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();


            builder.HasMany(customer => customer.Bookings)
                .WithOne(booking => booking.Customer)
                .HasForeignKey(booking => booking.CustomerID);
        }
    }
}
