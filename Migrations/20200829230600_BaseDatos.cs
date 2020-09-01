using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTienda.Migrations
{
    public partial class BaseDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallePrincipal = table.Column<string>(nullable: true),
                    CalleSecundari = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    CompraClienteId = table.Column<int>(nullable: true),
                    DueñoTiendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direccion_CompraCliente_CompraClienteId",
                        column: x => x.CompraClienteId,
                        principalTable: "CompraCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Direccion_DueñoTienda_DueñoTiendaId",
                        column: x => x.DueñoTiendaId,
                        principalTable: "DueñoTienda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    CompraClienteId = table.Column<int>(nullable: true),
                    DueñoTiendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_CompraCliente_CompraClienteId",
                        column: x => x.CompraClienteId,
                        principalTable: "CompraCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_DueñoTienda_DueñoTiendaId",
                        column: x => x.DueñoTiendaId,
                        principalTable: "DueñoTienda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_CompraClienteId",
                table: "Direccion",
                column: "CompraClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_DueñoTiendaId",
                table: "Direccion",
                column: "DueñoTiendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CompraClienteId",
                table: "Producto",
                column: "CompraClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_DueñoTiendaId",
                table: "Producto",
                column: "DueñoTiendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
