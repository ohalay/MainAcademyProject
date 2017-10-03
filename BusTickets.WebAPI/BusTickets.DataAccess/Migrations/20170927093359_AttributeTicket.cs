namespace BusTickets.DataAccess.Migrations
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AttributeTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "BusID_fk",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "DriverID_fk",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "JourneyID_fk",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Number_Of_Seats",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Phone_Number",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeats",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Drivers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Buses_BusID",
                table: "Ticket",
                column: "BusID",
                principalTable: "Buses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Drivers_DriverID",
                table: "Ticket",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Journeys_JourneyID",
                table: "Ticket",
                column: "JourneyID",
                principalTable: "Journeys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Buses_BusID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Drivers_DriverID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Journeys_JourneyID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "NumberOfSeats",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "Number_Of_Seats",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Phone_Number",
                table: "Drivers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "BusID_fk",
                table: "Ticket",
                column: "BusID",
                principalTable: "Buses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "DriverID_fk",
                table: "Ticket",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "JourneyID_fk",
                table: "Ticket",
                column: "JourneyID",
                principalTable: "Journeys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
