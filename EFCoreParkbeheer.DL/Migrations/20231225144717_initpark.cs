using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreParkbeheer.DL.Migrations
{
    /// <inheritdoc />
    public partial class initpark : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Huurders",
                columns: table => new
                {
                    HuurderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefoon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huurders", x => x.HuurderId);
                });

            migrationBuilder.CreateTable(
                name: "Parken",
                columns: table => new
                {
                    ParkId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Locatie = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parken", x => x.ParkId);
                });

            migrationBuilder.CreateTable(
                name: "Huizen",
                columns: table => new
                {
                    HuisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Nummer = table.Column<int>(type: "int", nullable: false),
                    Actief = table.Column<bool>(type: "bit", nullable: false),
                    ParkId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huizen", x => x.HuisId);
                    table.ForeignKey(
                        name: "FK_Huizen_Parken_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parken",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Huurcontracten",
                columns: table => new
                {
                    HuurcontractId = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AantalDagen = table.Column<int>(type: "int", nullable: false),
                    HuisId = table.Column<int>(type: "int", nullable: false),
                    HuurderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huurcontracten", x => x.HuurcontractId);
                    table.ForeignKey(
                        name: "FK_Huurcontracten_Huizen_HuisId",
                        column: x => x.HuisId,
                        principalTable: "Huizen",
                        principalColumn: "HuisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Huurcontracten_Huurders_HuurderId",
                        column: x => x.HuurderId,
                        principalTable: "Huurders",
                        principalColumn: "HuurderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Huizen_ParkId",
                table: "Huizen",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_Huurcontracten_HuisId",
                table: "Huurcontracten",
                column: "HuisId");

            migrationBuilder.CreateIndex(
                name: "IX_Huurcontracten_HuurderId",
                table: "Huurcontracten",
                column: "HuurderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Huurcontracten");

            migrationBuilder.DropTable(
                name: "Huizen");

            migrationBuilder.DropTable(
                name: "Huurders");

            migrationBuilder.DropTable(
                name: "Parken");
        }
    }
}
