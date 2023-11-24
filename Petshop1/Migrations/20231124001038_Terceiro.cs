using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petshop1.Migrations
{
    public partial class Terceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "valor",
                table: "TipoServicos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idAnimal",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "qtde",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_idAnimal",
                table: "Servicos",
                column: "idAnimal");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos",
                column: "idAnimal",
                principalTable: "Animais",
                principalColumn: "idAnimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_idAnimal",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "TipoServicos");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "idAnimal",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "qtde",
                table: "Servicos");
        }
    }
}
