using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleris_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri",
                column: "PersonelProjelerisPersonelProjeId",
                principalTable: "PersonelProjeleris",
                principalColumn: "PersonelProjeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonelBilgileriPersonelProjeleri_PersonelProjeleris_PersonelProjelerisPersonelProjeId",
                table: "PersonelBilgileriPersonelProjeleri");

            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
