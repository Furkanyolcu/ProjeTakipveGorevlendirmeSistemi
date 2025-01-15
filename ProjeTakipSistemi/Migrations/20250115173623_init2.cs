using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonelBilgileris_PersonelProjeleris_PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris");

            migrationBuilder.DropIndex(
                name: "IX_PersonelBilgileris_PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris");

            migrationBuilder.DropColumn(
                name: "PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris");

            migrationBuilder.CreateTable(
                name: "PersonelBilgileriPersonelProjeleri",
                columns: table => new
                {
                    PersonelBilgilerisPersonelBilgileriId = table.Column<int>(type: "int", nullable: false),
                    PersonelProjelerisPersonelProjeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelBilgileriPersonelProjeleri", x => new { x.PersonelBilgilerisPersonelBilgileriId, x.PersonelProjelerisPersonelProjeId });
                    table.ForeignKey(
                        name: "FK_PersonelBilgileriPersonelProjeleri_PersonelBilgileris_PersonelBilgilerisPersonelBilgileriId",
                        column: x => x.PersonelBilgilerisPersonelBilgileriId,
                        principalTable: "PersonelBilgileris",
                        principalColumn: "PersonelBilgileriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleris_PersonelProjelerisPersonelProjeId",
                        column: x => x.PersonelProjelerisPersonelProjeId,
                        principalTable: "PersonelProjeleris",
                        principalColumn: "PersonelProjeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelBilgileriPersonelProjeleri_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri",
                column: "PersonelProjelerisPersonelProjeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelBilgileriPersonelProjeleri");

            migrationBuilder.AddColumn<int>(
                name: "PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonelBilgileris_PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris",
                column: "PersonelProjeleriPersonelProjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelBilgileris_PersonelProjeleris_PersonelProjeleriPersonelProjeId",
                table: "PersonelBilgileris",
                column: "PersonelProjeleriPersonelProjeId",
                principalTable: "PersonelProjeleris",
                principalColumn: "PersonelProjeId");
        }
    }
}
