using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ProyectoTienda.Migrations
{
    public partial class IngresarDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Informaciones",
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
                  table.PrimaryKey("PK_Id", x => x.Id);
              });

            migrationBuilder.CreateTable(
               name: "AspNetUser",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false),
                   UserName = table.Column<string>(maxLength: 256, nullable: true),
                   NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                   Email = table.Column<string>(maxLength: 256, nullable: true),
                   NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                   EmailConfirmed = table.Column<bool>(nullable: false),
                   PasswordHash = table.Column<string>(nullable: true),
                   SecurityStamp = table.Column<string>(nullable: true),
                   ConcurrencyStamp = table.Column<string>(nullable: true),
                   PhoneNumber = table.Column<string>(nullable: true),
                   PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                   TwoFactorEnabled = table.Column<bool>(nullable: false),
                   LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                   LockoutEnabled = table.Column<bool>(nullable: false),
                   AccessFailedCount = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AspNetUser", x => x.Id);
               });
            migrationBuilder.CreateTable(
              name: "AspNetUserLogin",
              columns: table => new
              {
                  LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                  ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                  ProviderDisplayName = table.Column<string>(nullable: true),
                  UserId = table.Column<int>(nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_AspNetUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                  //table.ForeignKey(
                  //    name: "FK_AspNetUserLogin_AspNetUser_UserId",
                  //    column: x => x.UserId,
                  //    principalTable: "AspNetUser",
                  //    principalColumn: "Id",
                  //    onDelete: ReferentialAction.Cascade);
              });
            migrationBuilder.CreateIndex(
              name: "IX_AspNetUserLogin_UserId",
              table: "AspNetUserLogin",
              column: "UserId");
           

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "AspNetUserLogin");

        
            migrationBuilder.DropTable(
                name: "AspNetUser");
        }
    }
}
