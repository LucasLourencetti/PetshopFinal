using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petshop1.Migrations
{
    public partial class Quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Clientes_idCliente",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_TipoServicos_idTipoServico",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "TipoServicoId",
                table: "Servicos");

            migrationBuilder.AlterColumn<int>(
                name: "idTipoServico",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idCliente",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idAnimal",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos",
                column: "idAnimal",
                principalTable: "Animais",
                principalColumn: "idAnimal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Clientes_idCliente",
                table: "Servicos",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_TipoServicos_idTipoServico",
                table: "Servicos",
                column: "idTipoServico",
                principalTable: "TipoServicos",
                principalColumn: "idTipoServico",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Clientes_idCliente",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_TipoServicos_idTipoServico",
                table: "Servicos");

            migrationBuilder.AlterColumn<int>(
                name: "idTipoServico",
                table: "Servicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idCliente",
                table: "Servicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idAnimal",
                table: "Servicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoServicoId",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Animais_idAnimal",
                table: "Servicos",
                column: "idAnimal",
                principalTable: "Animais",
                principalColumn: "idAnimal");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Clientes_idCliente",
                table: "Servicos",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_TipoServicos_idTipoServico",
                table: "Servicos",
                column: "idTipoServico",
                principalTable: "TipoServicos",
                principalColumn: "idTipoServico");
        }
    }
}
