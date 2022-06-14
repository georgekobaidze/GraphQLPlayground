using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLPlayground.Migrations
{
    public partial class MakeLicenseKeyNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "license-key",
                table: "platforms",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "platforms",
                keyColumn: "license-key",
                keyValue: null,
                column: "license-key",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "license-key",
                table: "platforms",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
