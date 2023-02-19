﻿// <auto-generated />
using System;
using Ceyehat.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ceyehat.Infrastructure.Migrations
{
    [DbContext(typeof(CeyehatDbContext))]
    [Migration("20230219192337_FixMapping")]
    partial class FixMapping
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ceyehat.Domain.AircraftAggregate.Aircraft", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AirlineId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FaaRegistration")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Icao24Code")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("ManufacturerSerialNumber")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Model")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("RegistrationNumber")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Aircrafts", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.AirlineAggregate.Airline", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Callsign")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Code")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IataCode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("IcaoCode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Website")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("Airlines", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.AirportAggregate.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IataCode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("IcaoCode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(6, 16)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(6, 16)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Airports", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.CityAggregate.City", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.CountryAggregate.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Currency")
                        .HasColumnType("integer");

                    b.Property<string>("Iso2")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("Iso3")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("UnLocode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.CustomerAggregate.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int>("PassengerType")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Surname")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int>("Title")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.FlightAggregate.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ActualArrival")
                        .HasMaxLength(256)
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ActualDeparture")
                        .HasMaxLength(256)
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("AircraftId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ArrivalAirportId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DepartureAirportId")
                        .HasColumnType("uuid");

                    b.Property<string>("FlightNumber")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<Guid>("PriceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ScheduledArrival")
                        .HasMaxLength(256)
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ScheduledDeparture")
                        .HasMaxLength(256)
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasMaxLength(32)
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasMaxLength(32)
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Flights", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.PriceAggregate.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Currency")
                        .HasMaxLength(3)
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Prices", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.SeatAggregate.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AircraftId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SeatClass")
                        .HasColumnType("integer");

                    b.Property<string>("SeatNumber")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Seats", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.UserAggregate.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("LastName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Password")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ceyehat.Domain.AircraftAggregate.Aircraft", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.FlightAggregate.ValueObjects.FlightId", "FlightIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("AircraftId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("FlightId");

                            b1.HasKey("Id");

                            b1.HasIndex("AircraftId");

                            b1.ToTable("AircraftFlightIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AircraftId");
                        });

                    b.OwnsMany("Ceyehat.Domain.SeatAggregate.ValueObjects.SeatId", "SeatIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("AircraftId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("SeatId");

                            b1.HasKey("Id");

                            b1.HasIndex("AircraftId");

                            b1.ToTable("AircraftSeatIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AircraftId");
                        });

                    b.Navigation("FlightIds");

                    b.Navigation("SeatIds");
                });

            modelBuilder.Entity("Ceyehat.Domain.AirlineAggregate.Airline", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.AircraftAggregate.ValueObjects.AircraftId", "AircraftIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("AirlineId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("AircraftId");

                            b1.HasKey("Id");

                            b1.HasIndex("AirlineId");

                            b1.ToTable("AirlineAircraftIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AirlineId");
                        });

                    b.OwnsOne("Ceyehat.Domain.AirlineAggregate.Entities.AirlineAddress", "AirlineAddress", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("AirlineId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("CityId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id", "AirlineId");

                            b1.HasIndex("AirlineId")
                                .IsUnique();

                            b1.ToTable("AirlineAddresses", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AirlineId");
                        });

                    b.Navigation("AircraftIds");

                    b.Navigation("AirlineAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("Ceyehat.Domain.AirportAggregate.Airport", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.FlightAggregate.ValueObjects.FlightId", "ArrivalFlights", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("AirportId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("FlightId");

                            b1.HasKey("Id");

                            b1.HasIndex("AirportId");

                            b1.ToTable("AirportArrivalFlightIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AirportId");
                        });

                    b.OwnsMany("Ceyehat.Domain.FlightAggregate.ValueObjects.FlightId", "DepartureFlights", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("AirportId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("FlightId");

                            b1.HasKey("Id");

                            b1.HasIndex("AirportId");

                            b1.ToTable("AirportDepartureFlightIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AirportId");
                        });

                    b.Navigation("ArrivalFlights");

                    b.Navigation("DepartureFlights");
                });

            modelBuilder.Entity("Ceyehat.Domain.CityAggregate.City", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.CityAggregate.Entities.District", "Districts", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("CityId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Name")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b1.HasKey("Id");

                            b1.HasIndex("CityId");

                            b1.ToTable("Districts", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CityId");

                            b1.OwnsMany("Ceyehat.Domain.CityAggregate.Entities.Neighborhood", "Neighborhoods", b2 =>
                                {
                                    b2.Property<Guid>("Id")
                                        .HasColumnType("uuid");

                                    b2.Property<Guid?>("AirlineId")
                                        .HasColumnType("uuid");

                                    b2.Property<Guid?>("AirportId")
                                        .HasColumnType("uuid");

                                    b2.Property<Guid>("DistrictId")
                                        .HasColumnType("uuid");

                                    b2.Property<string>("Name")
                                        .HasMaxLength(256)
                                        .HasColumnType("character varying(256)");

                                    b2.HasKey("Id");

                                    b2.HasIndex("DistrictId");

                                    b2.ToTable("Neighborhoods", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("DistrictId");
                                });

                            b1.Navigation("Neighborhoods");
                        });

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Ceyehat.Domain.CountryAggregate.Country", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.AirlineAggregate.ValueObjects.AirlineId", "AirlineIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("CountryId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("AirlineId");

                            b1.HasKey("Id");

                            b1.HasIndex("CountryId");

                            b1.ToTable("CountryAirlineIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsMany("Ceyehat.Domain.CityAggregate.ValueObjects.CityId", "CityIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("CountryId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("CityId");

                            b1.HasKey("Id");

                            b1.HasIndex("CountryId");

                            b1.ToTable("CountryCityIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsMany("Ceyehat.Domain.AircraftAggregate.ValueObjects.AircraftId", "AircraftIds", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<Guid>("CountryId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uuid")
                                .HasColumnName("AircraftId");

                            b1.HasKey("Id");

                            b1.HasIndex("CountryId");

                            b1.ToTable("CountryAircraftIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.Navigation("AircraftIds");

                    b.Navigation("AirlineIds");

                    b.Navigation("CityIds");
                });

            modelBuilder.Entity("Ceyehat.Domain.CustomerAggregate.Customer", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.CustomerAggregate.Entities.BoardingPass", "BoardingPasses", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<string>("BoardingGate")
                                .HasMaxLength(8)
                                .HasColumnType("character varying(8)");

                            b1.Property<string>("BoardingGroup")
                                .HasMaxLength(2)
                                .HasColumnType("character varying(2)");

                            b1.Property<DateTime>("BoardingTime")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<DateTime>("CheckInTime")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id");

                            b1.HasIndex("CustomerId");

                            b1.ToTable("CustomerBoardingPasses", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsMany("Ceyehat.Domain.CustomerAggregate.Entities.Booking", "Bookings", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid")
                                .HasColumnName("BookingId");

                            b1.Property<int>("Currency")
                                .HasColumnType("integer");

                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.Property<Guid?>("FlightId")
                                .HasColumnType("uuid")
                                .HasColumnName("FlightId");

                            b1.Property<int>("PassengerType")
                                .HasColumnType("integer");

                            b1.Property<float>("Price")
                                .HasColumnType("real");

                            b1.Property<Guid?>("SeatId")
                                .HasColumnType("uuid")
                                .HasColumnName("SeatId");

                            b1.HasKey("Id");

                            b1.HasIndex("CustomerId");

                            b1.ToTable("CustomerBookings", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.OwnsMany("Ceyehat.Domain.CustomerAggregate.Entities.FlightTicket", "FlightTickets", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<Guid?>("BoardingPassId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("BookingId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.HasKey("Id");

                            b1.HasIndex("CustomerId");

                            b1.ToTable("CustomerFlightTickets", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.Navigation("BoardingPasses");

                    b.Navigation("Bookings");

                    b.Navigation("FlightTickets");
                });

            modelBuilder.Entity("Ceyehat.Domain.PriceAggregate.Price", b =>
                {
                    b.OwnsOne("Ceyehat.Domain.PriceAggregate.Entities.FlightPricing", "FlightPricing", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("PriceId")
                                .HasColumnType("uuid");

                            b1.Property<decimal>("BaseCost")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("ClassMultiplier")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("CompetitionMultiplier")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("DemandMultiplier")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("LengthMultiplier")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("MarkupPercentage")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("SeasonalMultiplier")
                                .HasColumnType("decimal(10,2)");

                            b1.Property<decimal>("TotalCost")
                                .HasColumnType("numeric");

                            b1.HasKey("Id", "PriceId");

                            b1.HasIndex("PriceId")
                                .IsUnique();

                            b1.ToTable("FlightPricing", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PriceId");
                        });

                    b.Navigation("FlightPricing")
                        .IsRequired();
                });

            modelBuilder.Entity("Ceyehat.Domain.UserAggregate.User", b =>
                {
                    b.OwnsMany("Ceyehat.Domain.UserAggregate.Entities.Relationship", "Relationships", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("UserId")
                                .HasColumnType("uuid");

                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Type")
                                .HasColumnType("integer");

                            b1.HasKey("Id", "UserId");

                            b1.HasIndex("UserId");

                            b1.ToTable("UserRelationships", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Relationships");
                });
#pragma warning restore 612, 618
        }
    }
}
