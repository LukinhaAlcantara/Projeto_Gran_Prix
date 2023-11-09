using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Gran_Prix.Data.Migrations
{
    public partial class NovoBanco13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Caixa",
                newName: "Valor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Caixa",
                newName: "Preco");
        }
    }
}
