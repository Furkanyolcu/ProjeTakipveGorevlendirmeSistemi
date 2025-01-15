using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonelProjeleris",
                columns: table => new
                {
                    PersonelProjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeBaslik = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ProjeAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OncelikDurumu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TamamlanmaOrani = table.Column<int>(type: "int", nullable: false),
                    TamamlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TamamlanmaDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelProjeleris", x => x.PersonelProjeId);
                });

            migrationBuilder.CreateTable(
                name: "PersonelBilgileris",
                columns: table => new
                {
                    PersonelBilgileriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Yetki = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TCNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Departman = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Gorev = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PozisyonAciklama = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MedeniHal = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    YakinlikBilgisi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    YakinTC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    YakinTel = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonelProjeleriPersonelProjeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelBilgileris", x => x.PersonelBilgileriId);
                    table.ForeignKey(
                        name: "FK_PersonelBilgileris_PersonelProjeleris_PersonelProjeleriPersonelProjeId",
                        column: x => x.PersonelProjeleriPersonelProjeId,
                        principalTable: "PersonelProjeleris",
                        principalColumn: "PersonelProjeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelBilgileris_PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris",
                column: "PersonelProjeleriPersonelProjeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelBilgileris");

            migrationBuilder.DropTable(
                name: "PersonelProjeleris");
        }
    }
}
