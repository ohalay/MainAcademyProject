using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class AddFCtoCitiesNearby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CitiesNearby",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CityNearbyID = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesNearby", x => x.ID);
                    table.ForeignKey(
                        name: "CityID_fk",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CityNearbyID_fk",
                        column: x => x.CityNearbyID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesNearby_CityID",
                table: "CitiesNearby",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesNearby_CityNearbyID",
                table: "CitiesNearby",
                column: "CityNearbyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitiesNearby");
        }
    }
}
