using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class MigratonName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haracterystica_tovarov",
                columns: table => new
                {
                    Id_kategorii = table.Column<int>(type: "int", nullable: false),
                    Name_kategorii = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Proizvoditel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Strana_proizvoditelya = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brend = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Material = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Rasmer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Haracter__AEFCAE3E45265997", x => x.Id_kategorii);
                });

            migrationBuilder.CreateTable(
                name: "Pokupatel",
                columns: table => new
                {
                    Id_pokupatel = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pokupate__E1DD4D883C33D591", x => x.Id_pokupatel);
                });

            migrationBuilder.CreateTable(
                name: "Tovar",
                columns: table => new
                {
                    Id_tovara = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Id_kategorii = table.Column<int>(type: "int", nullable: false),
                    Kolichestvo = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Opisanie_tovara = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tovar__95DB0B97106D7409", x => x.Id_tovara);
                    table.ForeignKey(
                        name: "FK__Tovar__Id_katego__40058253",
                        column: x => x.Id_kategorii,
                        principalTable: "Haracterystica_tovarov",
                        principalColumn: "Id_kategorii",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corzina",
                columns: table => new
                {
                    Id_zakaz = table.Column<int>(type: "int", nullable: false),
                    Id_tovara = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Kolichestvo = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Status_tovara = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Corzina__EE5C9C9BE88374A1", x => x.Id_zakaz);
                    table.ForeignKey(
                        name: "FK__Corzina__Status___42E1EEFE",
                        column: x => x.Id_tovara,
                        principalTable: "Tovar",
                        principalColumn: "Id_tovara",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zakaz",
                columns: table => new
                {
                    Id_zakaz = table.Column<int>(type: "int", nullable: false),
                    Id_pokupatel = table.Column<int>(type: "int", nullable: false),
                    Date_zakaz = table.Column<DateTime>(type: "date", nullable: false),
                    Srok_sborki = table.Column<int>(type: "int", nullable: false),
                    Sposob_dostavci = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status_dostavci = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Zakaz__Id_zakaz__4F47C5E3",
                        column: x => x.Id_zakaz,
                        principalTable: "Corzina",
                        principalColumn: "Id_zakaz",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Zakaz__Status_do__4E53A1AA",
                        column: x => x.Id_pokupatel,
                        principalTable: "Pokupatel",
                        principalColumn: "Id_pokupatel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corzina_Id_tovara",
                table: "Corzina",
                column: "Id_tovara");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_Id_kategorii",
                table: "Tovar",
                column: "Id_kategorii");

            migrationBuilder.CreateIndex(
                name: "IX_Zakaz_Id_pokupatel",
                table: "Zakaz",
                column: "Id_pokupatel");

            migrationBuilder.CreateIndex(
                name: "IX_Zakaz_Id_zakaz",
                table: "Zakaz",
                column: "Id_zakaz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zakaz");

            migrationBuilder.DropTable(
                name: "Corzina");

            migrationBuilder.DropTable(
                name: "Pokupatel");

            migrationBuilder.DropTable(
                name: "Tovar");

            migrationBuilder.DropTable(
                name: "Haracterystica_tovarov");
        }
    }
}
