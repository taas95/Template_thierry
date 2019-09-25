using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Location.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appartements",
                columns: table => new
                {
                    idAppartement = table.Column<string>(nullable: false),
                    libelleAppartement = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    caution = table.Column<int>(nullable: false),
                    loyer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartements", x => x.idAppartement);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    idLocataire = table.Column<string>(maxLength: 10, nullable: false),
                    nom = table.Column<string>(maxLength: 30, nullable: true),
                    prenom = table.Column<string>(maxLength: 30, nullable: true),
                    tel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.idLocataire);
                });

            migrationBuilder.CreateTable(
                name: "Proprietaires",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    telephone = table.Column<int>(nullable: false),
                    adresse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietaires", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Retraits",
                columns: table => new
                {
                    idRetrait = table.Column<string>(nullable: false),
                    montant = table.Column<int>(nullable: false),
                    dateRetrait = table.Column<DateTime>(nullable: false),
                    commentaires = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retraits", x => x.idRetrait);
                });

            migrationBuilder.CreateTable(
                name: "Immeubles",
                columns: table => new
                {
                    idImmeuble = table.Column<string>(maxLength: 10, nullable: false),
                    libelle = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    idProprietaire = table.Column<string>(nullable: true),
                    Proprietaireid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immeubles", x => x.idImmeuble);
                    table.ForeignKey(
                        name: "FK_Immeubles_Proprietaires_Proprietaireid",
                        column: x => x.Proprietaireid,
                        principalTable: "Proprietaires",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratLocations",
                columns: table => new
                {
                    idContratLocation = table.Column<string>(nullable: false),
                    libelle = table.Column<string>(nullable: true),
                    idAppartement = table.Column<string>(nullable: true),
                    idLocataire = table.Column<string>(nullable: true),
                    idImmeuble = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratLocations", x => x.idContratLocation);
                    table.ForeignKey(
                        name: "FK_ContratLocations_Appartements_idAppartement",
                        column: x => x.idAppartement,
                        principalTable: "Appartements",
                        principalColumn: "idAppartement",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratLocations_Immeubles_idImmeuble",
                        column: x => x.idImmeuble,
                        principalTable: "Immeubles",
                        principalColumn: "idImmeuble",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratLocations_Locataires_idLocataire",
                        column: x => x.idLocataire,
                        principalTable: "Locataires",
                        principalColumn: "idLocataire",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    idContrat = table.Column<string>(maxLength: 10, nullable: false),
                    libelleContrat = table.Column<string>(nullable: true),
                    dateDeb = table.Column<DateTime>(nullable: false),
                    dateFin = table.Column<DateTime>(nullable: false),
                    commission = table.Column<int>(nullable: false),
                    idImmeuble = table.Column<int>(nullable: false),
                    ImmeubleidImmeuble = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.idContrat);
                    table.ForeignKey(
                        name: "FK_Contrats_Immeubles_ImmeubleidImmeuble",
                        column: x => x.ImmeubleidImmeuble,
                        principalTable: "Immeubles",
                        principalColumn: "idImmeuble",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payements",
                columns: table => new
                {
                    idProprietaire = table.Column<string>(maxLength: 10, nullable: false),
                    montant = table.Column<int>(nullable: false),
                    datePayement = table.Column<DateTime>(nullable: false),
                    commentaire = table.Column<string>(nullable: true),
                    idContratLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payements", x => x.idProprietaire);
                    table.ForeignKey(
                        name: "FK_Payements_ContratLocations_idContratLocation",
                        column: x => x.idContratLocation,
                        principalTable: "ContratLocations",
                        principalColumn: "idContratLocation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContratLocations_idAppartement",
                table: "ContratLocations",
                column: "idAppartement");

            migrationBuilder.CreateIndex(
                name: "IX_ContratLocations_idImmeuble",
                table: "ContratLocations",
                column: "idImmeuble");

            migrationBuilder.CreateIndex(
                name: "IX_ContratLocations_idLocataire",
                table: "ContratLocations",
                column: "idLocataire");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_ImmeubleidImmeuble",
                table: "Contrats",
                column: "ImmeubleidImmeuble");

            migrationBuilder.CreateIndex(
                name: "IX_Immeubles_Proprietaireid",
                table: "Immeubles",
                column: "Proprietaireid");

            migrationBuilder.CreateIndex(
                name: "IX_Payements_idContratLocation",
                table: "Payements",
                column: "idContratLocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "Payements");

            migrationBuilder.DropTable(
                name: "Retraits");

            migrationBuilder.DropTable(
                name: "ContratLocations");

            migrationBuilder.DropTable(
                name: "Appartements");

            migrationBuilder.DropTable(
                name: "Immeubles");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Proprietaires");
        }
    }
}
