using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class MoveBusIDAndDriverIDTOJourney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Buses_BusID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Drivers_DriverID",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "CitiesNearbys");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_BusID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_DriverID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "BusID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusID",
                table: "Journeys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DriverID",
                table: "Journeys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CityID",
                table: "Ticket",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_BusID",
                table: "Journeys",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_DriverID",
                table: "Journeys",
                column: "DriverID");

            migrationBuilder.AddForeignKey(
                name: "FK_Journeys_Buses_BusID",
                table: "Journeys",
                column: "BusID",
                principalTable: "Buses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Journeys_Drivers_DriverID",
                table: "Journeys",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Cities_CityID",
                table: "Ticket",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journeys_Buses_BusID",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "FK_Journeys_Drivers_DriverID",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Cities_CityID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CityID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_BusID",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_DriverID",
                table: "Journeys");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "BusID",
                table: "Journeys");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Journeys");

            migrationBuilder.AddColumn<int>(
                name: "BusID",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DriverID",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CitiesNearbys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityID = table.Column<int>(nullable: false),
                    Distance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesNearbys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CitiesNearbys_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BusID",
                table: "Ticket",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DriverID",
                table: "Ticket",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesNearbys_CityID",
                table: "CitiesNearbys",
                column: "CityID");

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
        }
    }
}
