using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTienda.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompraCliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Detalle = table.Column<string>(nullable: true),
                    Cantidad = table.Column<string>(nullable: true),
                    Precio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DueñoTienda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Detalle = table.Column<string>(nullable: true),
                    Cantidad = table.Column<string>(nullable: true),
                    Precio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DueñoTienda", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraCliente");

            migrationBuilder.DropTable(
                name: "DueñoTienda");
        }
    }
}
