using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLPlayground.Migrations
{
    public partial class AddCommandsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "command",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    howto = table.Column<string>(name: "how-to", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    commandline = table.Column<string>(name: "command-line", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    platformid = table.Column<int>(name: "platform-id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_command", x => x.id);
                    table.ForeignKey(
                        name: "FK_command_platforms_platform-id",
                        column: x => x.platformid,
                        principalTable: "platforms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_command_platform-id",
                table: "command",
                column: "platform-id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "command");
        }
    }
}
