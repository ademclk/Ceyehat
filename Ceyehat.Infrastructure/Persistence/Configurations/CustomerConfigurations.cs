using Ceyehat.Domain.CustomerAggregate;
using Ceyehat.Domain.CustomerAggregate.ValueObjects;
using Ceyehat.Domain.Enums;
using Ceyehat.Domain.FlightAggregate.ValueObjects;
using Ceyehat.Domain.PassengerAggregate.ValueObjects;
using Ceyehat.Domain.SeatAggregate.ValueObjects;
using Ceyehat.Domain.UserAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ceyehat.Infrastructure.Persistence.Configurations;

public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        ConfigureCustomersTable(builder);
        ConfigureCustomerPassengerIdsTable(builder);
        ConfigureCustomerBookingsTable(builder);
    }

    private void ConfigureCustomerBookingsTable(EntityTypeBuilder<Customer> builder)
    {
        builder.OwnsMany(
            c => c.Bookings,
            bb =>
            {
                bb.ToTable("CustomerBookings");

                bb.WithOwner().HasForeignKey("CustomerId");

                bb.HasKey(b => b.Id);

                bb.Property(b => b.Id)
                    .HasColumnName("BookingId")
                    .ValueGeneratedNever()
                    .HasConversion(
                        b => b.Value,
                        value => BookingId.Create(value));

                bb.Property(b => b.SeatId)
                    .HasColumnName("SeatId")
                    .ValueGeneratedNever()
                    .HasConversion(
                        b => b!.Value,
                        value => SeatId.Create(value));

                bb.Property(b => b.FlightId)
                    .HasColumnName("FlightId")
                    .ValueGeneratedNever()
                    .HasConversion(
                        b => b!.Value,
                        value => FlightId.Create(value));
            });
    }

    private void ConfigureCustomerPassengerIdsTable(EntityTypeBuilder<Customer> builder)
    {
        builder.OwnsMany(
            c => c.PassengerIds,
            pb =>
            {
                pb.ToTable("CustomerPassengerIds");

                pb.WithOwner().HasForeignKey("CustomerId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("PassengerId")
                    .ValueGeneratedNever();
            });

        builder.Metadata.FindNavigation(nameof(Customer.PassengerIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureCustomersTable(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(
                c => c.Value,
                value => CustomerId.Create(value));

        builder.Property(c => c.Name)
            .HasMaxLength(128);

        builder.Property(c => c.Surname)
            .HasMaxLength(128);

        builder.Property(c => c.Email)
            .HasMaxLength(128);

        builder.Property(c => c.PhoneNumber)
            .HasMaxLength(16);

        builder.Property(c => c.Title)
            .IsRequired()
            .HasConversion(
                title => (int)title,
                intValue => (Title)intValue);

        builder.Property(c => c.BirthDate)
            .IsRequired();

        builder.Property(c => c.PassengerType)
            .IsRequired()
            .HasConversion(
                passengerType => (int)passengerType,
                intValue => (PassengerType)intValue);

        builder.Property(c => c.UserId)
            .ValueGeneratedNever()
            .HasConversion(
                c => c!.Value,
                value => UserId.Create(value));
    }
}