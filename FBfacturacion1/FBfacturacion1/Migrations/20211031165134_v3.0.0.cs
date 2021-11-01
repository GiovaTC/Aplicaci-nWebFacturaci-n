using Microsoft.EntityFrameworkCore.Migrations;

namespace FBfacturacion1.Migrations
{
    public partial class v300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "facturacion");

            migrationBuilder.DropColumn(
                name: "N_factura",
                table: "facturacion");

            migrationBuilder.DropColumn(
                name: "desc",
                table: "facturacion");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "facturacion");

            migrationBuilder.DropColumn(
                name: "iva",
                table: "facturacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "facturacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "N_factura",
                table: "facturacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "facturacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fecha",
                table: "facturacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "iva",
                table: "facturacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
