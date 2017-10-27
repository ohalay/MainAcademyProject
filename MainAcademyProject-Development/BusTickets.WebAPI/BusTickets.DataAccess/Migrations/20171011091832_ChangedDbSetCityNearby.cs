using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class ChangedDbSetCityNearby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Journeys_JourneyID",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CitiesNearby",
                table: "CitiesNearby");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "CitiesNearby",
                newName: "CitiesNearbys");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_JourneyID",
                table: "Tickets",
                newName: "IX_Tickets_JourneyID");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_CityToID",
                table: "Tickets",
                newName: "IX_Tickets_CityToID");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_CityFromID",
                table: "Tickets",
                newName: "IX_Tickets_CityFromID");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesNearby_CityNearbyID",
                table: "CitiesNearbys",
                newName: "IX_CitiesNearbys_CityNearbyID");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesNearby_CityID",
                table: "CitiesNearbys",
                newName: "IX_CitiesNearbys_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CitiesNearbys",
                table: "CitiesNearbys",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Journeys_JourneyID",
                table: "Tickets",
                column: "JourneyID",
                principalTable: "Journeys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Journeys_JourneyID",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CitiesNearbys",
                table: "CitiesNearbys");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "CitiesNearbys",
                newName: "CitiesNearby");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_JourneyID",
                table: "Ticket",
                newName: "IX_Ticket_JourneyID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_CityToID",
                table: "Ticket",
                newName: "IX_Ticket_CityToID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_CityFromID",
                table: "Ticket",
                newName: "IX_Ticket_CityFromID");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesNearbys_CityNearbyID",
                table: "CitiesNearby",
                newName: "IX_CitiesNearby_CityNearbyID");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesNearbys_CityID",
                table: "CitiesNearby",
                newName: "IX_CitiesNearby_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CitiesNearby",
                table: "CitiesNearby",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Journeys_JourneyID",
                table: "Ticket",
                column: "JourneyID",
                principalTable: "Journeys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
