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
    [Migration("20230213110036_AirportMapping")]
    partial class AirportMapping
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
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
