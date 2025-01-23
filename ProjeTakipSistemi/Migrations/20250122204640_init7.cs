using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleris_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonelProjeleris",
                table: "PersonelProjeleris");

            migrationBuilder.RenameTable(
                name: "PersonelProjeleris",
                newName: "PersonelProjeleri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonelProjeleri",
                table: "PersonelProjeleri",
                column: "PersonelProjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleri_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri",
                column: "PersonelProjelerisPersonelProjeId",
                principalTable: "PersonelProjeleri",
                principalColumn: "PersonelProjeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleri_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonelProjeleri",
                table: "PersonelProjeleri");

            migrationBuilder.RenameTable(
                name: "PersonelProjeleri",
                newName: "PersonelProjeleris");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonelProjeleris",
                table: "PersonelProjeleris",
                column: "PersonelProjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleris_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri",
                column: "PersonelProjelerisPersonelProjeId",
                principalTable: "PersonelProjeleris",
                principalColumn: "PersonelProjeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
