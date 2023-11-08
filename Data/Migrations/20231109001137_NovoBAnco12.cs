using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Gran_Prix.Data.Migrations
{
    public partial class NovoBAnco12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "Caixa");

            migrationBuilder.DropColumn(
                name: "Pedido_Id",
                table: "Caixa");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "Caixa");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Caixa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Caixa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Caixa");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Caixa");

            migrationBuilder.AddColumn<double>(
                name: "Entrada",
                table: "Caixa",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Pedido_Id",
                table: "Caixa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Saida",
                table: "Caixa",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
