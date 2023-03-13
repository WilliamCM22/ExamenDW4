using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenDW4.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appartements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Surface = table.Column<int>(type: "int", nullable: false),
                    Meuble = table.Column<bool>(type: "bit", nullable: false),
                    TypeAppartement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    AppartementID = table.Column<int>(type: "int", nullable: false),
                    LocataireID = table.Column<int>(type: "int", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "date", nullable: false),
                    LoyerMensuel = table.Column<int>(type: "int", nullable: false),
                    DateFin = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => new { x.AppartementID, x.LocataireID, x.DateDebut });
                    table.ForeignKey(
                        name: "FK_Locations_Appartements_AppartementID",
                        column: x => x.AppartementID,
                        principalTable: "Appartements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Locataires_LocataireID",
                        column: x => x.LocataireID,
                        principalTable: "Locataires",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocataireID",
                table: "Locations",
                column: "LocataireID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Appartements");

            migrationBuilder.DropTable(
                name: "Locataires");
        }
    }
}
