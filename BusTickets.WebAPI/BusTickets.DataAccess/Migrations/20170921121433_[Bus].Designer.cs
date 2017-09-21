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
    [Migration("20170921121433_[Bus]")]
    partial class Bus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Busess");
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

                    b.Property<double>("Price");

                    b.Property<int>("Time");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

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

                    b.Property<float>("Distance");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("CitiesNearbys");
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

                    b.Property<string>("Phone_Number")
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

                    b.Property<int>("DepartureStationID");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<float>("Distance");

                    b.HasKey("ID");

                    b.HasIndex("ArrivalStationID");

                    b.HasIndex("DepartureStationID");

                    b.ToTable("Journeys");
                });

            modelBuilder.Entity("BusTickets.DataAccess.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DriverID");

                    b.Property<string>("Explanation")
                        .HasMaxLength(50);

                    b.Property<int>("Number_Of_Seats");

                    b.Property<int>("Opinion");

                    b.HasKey("ID");

                    b.HasIndex("DriverID");

                    b.ToTable("Reviews");
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
                });

            modelBuilder.Entity("BusTickets.DataAccess.CitiesNearby", b =>
                {
                    b.HasOne("BusTickets.DataAccess.City", "City")
                        .WithMany("CitiesNearbys")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusTickets.DataAccess.Journey", b =>
                {
                    b.HasOne("BusTickets.DataAccess.BusStation", "ArrivalBusStation")
                        .WithMany("ArrivalBusStation")
                        .HasForeignKey("ArrivalStationID")
                        .HasConstraintName("ArrivalBusStation_fk")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusTickets.DataAccess.BusStation", "DepartureBusStation")
                        .WithMany("DepartureBusStation")
                        .HasForeignKey("DepartureStationID")
                        .HasConstraintName("DepartureBusStation_fk")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BusTickets.DataAccess.Review", b =>
                {
                    b.HasOne("BusTickets.DataAccess.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
