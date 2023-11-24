using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petshop1.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "TipoServicos",
                columns: table => new
                {
                    idTipoServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicos", x => x.idTipoServico);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    idServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: true),
                    TipoServicoId = table.Column<int>(type: "int", nullable: false),
                    idTipoServico = table.Column<int>(type: "int", nullable: true),
                    horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.idServico);
                    table.ForeignKey(
                        name: "FK_Servicos_Clientes_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_Servicos_TipoServicos_idTipoServico",
                        column: x => x.idTipoServico,
                        principalTable: "TipoServicos",
                        principalColumn: "idTipoServico");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_idCliente",
                table: "Servicos",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_idTipoServico",
                table: "Servicos",
                column: "idTipoServico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TipoServicos");
        }
    }
}
