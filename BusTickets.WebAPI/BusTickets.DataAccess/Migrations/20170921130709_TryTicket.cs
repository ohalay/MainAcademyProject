using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class TryTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Busess_BusTypes_BusTypeID",
                table: "Busess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Busess",
                table: "Busess");

            migrationBuilder.RenameTable(
                name: "Busess",
                newName: "Buses");

            migrationBuilder.RenameIndex(
                name: "IX_Busess_BusTypeID",
                table: "Buses",
                newName: "IX_Buses_BusTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buses",
                table: "Buses",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusID = table.Column<int>(type: "int", nullable: false),
                    CityFromID = table.Column<int>(type: "int", nullable: false),
                    CityToID = table.Column<int>(type: "int", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    JourneyID = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ID);
                    table.ForeignKey(
                        name: "BusID_fk",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CityFromID_fk",
                        column: x => x.CityFromID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CityToID_fk",
                        column: x => x.CityToID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "DriverID_fk",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "JourneyID_fk",
                        column: x => x.JourneyID,
                        principalTable: "Journeys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BusID",
                table: "Ticket",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CityFromID",
                table: "Ticket",
                column: "CityFromID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CityToID",
                table: "Ticket",
                column: "CityToID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DriverID",
                table: "Ticket",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_JourneyID",
                table: "Ticket",
                column: "JourneyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_BusTypes_BusTypeID",
                table: "Buses",
                column: "BusTypeID",
                principalTable: "BusTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_BusTypes_BusTypeID",
                table: "Buses");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buses",
                table: "Buses");

            migrationBuilder.RenameTable(
                name: "Buses",
                newName: "Busess");

            migrationBuilder.RenameIndex(
                name: "IX_Buses_BusTypeID",
                table: "Busess",
                newName: "IX_Busess_BusTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Busess",
                table: "Busess",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Busess_BusTypes_BusTypeID",
                table: "Busess",
                column: "BusTypeID",
                principalTable: "BusTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
