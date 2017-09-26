using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class ChangeForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ArrivalBusStation_fk",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "DepartureBusStation_fk",
                table: "Journeys");

            migrationBuilder.AddColumn<int>(
                name: "Distance",
                table: "BusStops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JorneyID",
                table: "BusStops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JourneyID",
                table: "BusStops",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusStops_JourneyID",
                table: "BusStops",
                column: "JourneyID");

            migrationBuilder.AddForeignKey(
                name: "FK_BusStops_Journeys_JourneyID",
                table: "BusStops",
                column: "JourneyID",
                principalTable: "Journeys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ArrivalID_fk",
                table: "Journeys",
                column: "ArrivalStationID",
                principalTable: "BusStations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "DepartureID_fk",
                table: "Journeys",
                column: "DepartureStationID",
                principalTable: "BusStations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusStops_Journeys_JourneyID",
                table: "BusStops");

            migrationBuilder.DropForeignKey(
                name: "ArrivalID_fk",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "DepartureID_fk",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_BusStops_JourneyID",
                table: "BusStops");

            migrationBuilder.DropColumn(
                name: "Distance",
                table: "BusStops");

            migrationBuilder.DropColumn(
                name: "JorneyID",
                table: "BusStops");

            migrationBuilder.DropColumn(
                name: "JourneyID",
                table: "BusStops");

            migrationBuilder.AddForeignKey(
                name: "ArrivalBusStation_fk",
                table: "Journeys",
                column: "ArrivalStationID",
                principalTable: "BusStations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "DepartureBusStation_fk",
                table: "Journeys",
                column: "DepartureStationID",
                principalTable: "BusStations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
