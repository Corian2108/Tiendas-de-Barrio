using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTienda.Migrations
{
    public partial class Informacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barrio",
                table: "Direccion",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoordenadaGoogle",
                table: "Direccion",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InformacionId",
                table: "Direccion",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Informacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTienda = table.Column<string>(nullable: true),
                    Ruc = table.Column<string>(nullable: false),
                    Permisos = table.Column<byte[]>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    EncardadoEm = table.Column<string>(nullable: true),
                    PcrEm = table.Column<byte[]>(nullable: true),
                    EncardadoDes = table.Column<string>(nullable: true),
                    PcrDes = table.Column<byte[]>(nullable: true),
                    CorreoElectornico = table.Column<string>(nullable: true),
                    NumeroCelular = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: false),
                    EntregaDomicilio = table.Column<bool>(nullable: false),
                    ReservaPedido = table.Column<bool>(nullable: false),
                    transBancaria = table.Column<bool>(nullable: false),
                    Tarjeta = table.Column<bool>(nullable: false),
                    Otros = table.Column<bool>(nullable: false),
                    Efectivo = table.Column<bool>(nullable: false),
                    FacturaElectronica = table.Column<bool>(nullable: false),
                    FacturaFisica = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informacion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_InformacionId",
                table: "Direccion",
                column: "InformacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direccion_Informacion_InformacionId",
                table: "Direccion",
                column: "InformacionId",
                principalTable: "Informacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direccion_Informacion_InformacionId",
                table: "Direccion");

            migrationBuilder.DropTable(
                name: "Informacion");

            migrationBuilder.DropIndex(
                name: "IX_Direccion_InformacionId",
                table: "Direccion");

            migrationBuilder.DropColumn(
                name: "Barrio",
                table: "Direccion");

            migrationBuilder.DropColumn(
                name: "CoordenadaGoogle",
                table: "Direccion");

            migrationBuilder.DropColumn(
                name: "InformacionId",
                table: "Direccion");
        }
    }
}
