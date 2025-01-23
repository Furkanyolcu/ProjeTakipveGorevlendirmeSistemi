using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class innn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YakinTel",
                table: "PersonelBilgileris",
                type: "int",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "YakinTC",
                table: "PersonelBilgileris",
                type: "int",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "TelNo",
                table: "PersonelBilgileris",
                type: "int",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "TCNO",
                table: "PersonelBilgileris",
                type: "int",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YakinTel",
                table: "PersonelBilgileris",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "YakinTC",
                table: "PersonelBilgileris",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "PersonelBilgileris",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "TCNO",
                table: "PersonelBilgileris",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 15);
        }
    }
}
