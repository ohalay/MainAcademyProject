﻿// <auto-generated />
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BusTickets.DataAccess.Migrations
{
    [DbContext(typeof(BusTicketDbContext))]
    partial class BusTicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusTickets.DataAccess.Bus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusNumber");

                    b.Property<int>("BusTypeID");

                    b.Property<int>("SeatsNumber");

                    b.HasKey("ID");

                    b.HasIndex("BusTypeID");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("BusTickets.DataAccess.BusStation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<int>("CityID");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("BusStations");
                });

            modelBuilder.Entity("BusTickets.DataAccess.BusStop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityID");

                    b.Property<int>("Distance");

                    b.Property<int>("JorneyID");

                    b.Property<int?>("JourneyID");

                    b.Property<double>("Price");

                    b.Property<int>("Time");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("JourneyID");

                    b.ToTable("BusStops");
                });

            modelBuilder.Entity("BusTickets.DataAccess.BusType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("BusTypes");
                });

            modelBuilder.Entity("BusTickets.DataAccess.CitiesNearby", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityID");

                    b.Property<int>("CityNearbyID");

                    b.Property<float>("Distance");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CityNearbyID");

                    b.ToTable("CitiesNearby");
                });

            modelBuilder.Entity("BusTickets.DataAccess.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("People");

                    b.HasKey("ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Driver", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Journey", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArrivalStationID");

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<int>("BusID");

                    b.Property<int>("DepartureStationID");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<float>("Distance");

                    b.Property<int>("DriverID");

                    b.HasKey("ID");

                    b.HasIndex("ArrivalStationID");

                    b.HasIndex("BusID");

                    b.HasIndex("DepartureStationID");

                    b.HasIndex("DriverID");

                    b.ToTable("Journeys");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DriverID");

                    b.Property<string>("Explanation")
                        .HasMaxLength(50);

                    b.Property<int>("NumberOfSeats");

                    b.Property<int>("Opinion");

                    b.HasKey("ID");

                    b.HasIndex("DriverID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityFromID");

                    b.Property<int>("CityToID");

                    b.Property<int>("JourneyID");

                    b.Property<int>("SeatNumber");

                    b.HasKey("ID");

                    b.HasIndex("CityFromID");

                    b.HasIndex("CityToID");

                    b.HasIndex("JourneyID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Bus", b =>
                {
                    b.HasOne("BusTickets.DataAccess.BusType", "BusType")
                        .WithMany("Buses")
                        .HasForeignKey("BusTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.DataAccess.BusStation", b =>
                {
                    b.HasOne("BusTickets.DataAccess.City", "City")
                        .WithMany("BusStations")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.DataAccess.BusStop", b =>
                {
                    b.HasOne("BusTickets.DataAccess.City", "City")
                        .WithMany("BusStops")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTickets.DataAccess.Journey", "Journey")
                        .WithMany()
                        .HasForeignKey("JourneyID");
                });

            modelBuilder.Entity("BusTickets.DataAccess.CitiesNearby", b =>
                {
                    b.HasOne("BusTickets.DataAccess.City", "City")
                        .WithMany("Cities")
                        .HasForeignKey("CityID")
                        .HasConstraintName("CityID_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.City", "CityNearby")
                        .WithMany("CitiesNearby")
                        .HasForeignKey("CityNearbyID")
                        .HasConstraintName("CityNearbyID_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BusTickets.DataAccess.Journey", b =>
                {
                    b.HasOne("BusTickets.DataAccess.BusStation", "ArrivalBusStation")
                        .WithMany("ArrivalBusStation")
                        .HasForeignKey("ArrivalStationID")
                        .HasConstraintName("ArrivalID_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.Bus", "JourneyBus")
                        .WithMany("JourneyBus")
                        .HasForeignKey("BusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BusTickets.DataAccess.BusStation", "DepartureBusStation")
                        .WithMany("DepartureBusStation")
                        .HasForeignKey("DepartureStationID")
                        .HasConstraintName("DepartureID_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.Driver", "JourneyDriver")
                        .WithMany("JourneyDriver")
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.DataAccess.Review", b =>
                {
                    b.HasOne("BusTickets.DataAccess.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.DataAccess.Ticket", b =>
                {
                    b.HasOne("BusTickets.DataAccess.City", "CityFrom")
                        .WithMany("CityFrom")
                        .HasForeignKey("CityFromID")
                        .HasConstraintName("CityFromID_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.City", "CityTo")
                        .WithMany("CityTo")
                        .HasForeignKey("CityToID")
                        .HasConstraintName("CityToID_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.Journey", "TicketJourney")
                        .WithMany("TicketJourney")
                        .HasForeignKey("JourneyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
