using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Location.Migrations
{
    public partial class RetratTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "idContrat",
                table: "Retraits",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Retraits_idContrat",
                table: "Retraits",
                column: "idContrat");

            migrationBuilder.AddForeignKey(
                name: "FK_Retraits_Contrats_idContrat",
                table: "Retraits",
                column: "idContrat",
                principalTable: "Contrats",
                principalColumn: "idContrat",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Retraits_Contrats_idContrat",
                table: "Retraits");

            migrationBuilder.DropIndex(
                name: "IX_Retraits_idContrat",
                table: "Retraits");

            migrationBuilder.DropColumn(
                name: "idContrat",
                table: "Retraits");
        }
    }
}
