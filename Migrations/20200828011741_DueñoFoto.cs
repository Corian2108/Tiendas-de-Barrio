using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTienda.Migrations
{
    public partial class DueñoFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "DueñoTienda",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "DueñoTienda");
        }
    }
}
