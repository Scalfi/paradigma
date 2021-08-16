using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Paradigma.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "colaborador",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    salario = table.Column<decimal>(type: "numeric", nullable: false),
                    departamento_id = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colaborador", x => x.id);
                    table.ForeignKey(
                        name: "FK_colaborador_departamento_departamento_id",
                        column: x => x.departamento_id,
                        principalTable: "departamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departamento",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "TI" },
                    { 2, "Vendas" }
                });

            migrationBuilder.InsertData(
                table: "colaborador",
                columns: new[] { "id", "departamento_id", "nome", "salario" },
                values: new object[,]
                {
                    { 1, 1, "Joe", 70000m },
                    { 4, 1, "Max", 90000m },
                    { 2, 2, "Henry", 80000m },
                    { 3, 2, "Sam", 60000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_colaborador_departamento_id",
                table: "colaborador",
                column: "departamento_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "colaborador");

            migrationBuilder.DropTable(
                name: "departamento");
        }
    }
}
