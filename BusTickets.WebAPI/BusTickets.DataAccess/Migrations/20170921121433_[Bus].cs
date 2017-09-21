using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTickets.DataAccess.Migrations
{
    public partial class Bus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Busess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusNumber = table.Column<int>(type: "int", nullable: false),
                    BusTypeID = table.Column<int>(type: "int", nullable: false),
                    SeatsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Busess", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Busess_BusTypes_BusTypeID",
                        column: x => x.BusTypeID,
                        principalTable: "BusTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Number_Of_Seats = table.Column<int>(type: "int", nullable: false),
                    Opinion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Busess_BusTypeID",
                table: "Busess",
                column: "BusTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DriverID",
                table: "Reviews",
                column: "DriverID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Busess");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "BusTypes");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
