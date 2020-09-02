using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTienda.Migrations
{
    public partial class DetalleCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompraDetalleId",
                table: "Producto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompraDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCompra = table.Column<string>(nullable: true),
                    Precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraDetalle", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CompraDetalleId",
                table: "Producto",
                column: "CompraDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_CompraDetalle_CompraDetalleId",
                table: "Producto",
                column: "CompraDetalleId",
                principalTable: "CompraDetalle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_CompraDetalle_CompraDetalleId",
                table: "Producto");

            migrationBuilder.DropTable(
                name: "CompraDetalle");

            migrationBuilder.DropIndex(
                name: "IX_Producto_CompraDetalleId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "CompraDetalleId",
                table: "Producto");
        }
    }
}
