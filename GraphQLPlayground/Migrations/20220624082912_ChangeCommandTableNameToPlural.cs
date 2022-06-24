using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLPlayground.Migrations
{
    public partial class ChangeCommandTableNameToPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_command_platforms_platform-id",
                table: "command");

            migrationBuilder.DropPrimaryKey(
                name: "PK_command",
                table: "command");

            migrationBuilder.RenameTable(
                name: "command",
                newName: "commands");

            migrationBuilder.RenameIndex(
                name: "IX_command_platform-id",
                table: "commands",
                newName: "IX_commands_platform-id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_commands",
                table: "commands",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_commands_platforms_platform-id",
                table: "commands",
                column: "platform-id",
                principalTable: "platforms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commands_platforms_platform-id",
                table: "commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_commands",
                table: "commands");

            migrationBuilder.RenameTable(
                name: "commands",
                newName: "command");

            migrationBuilder.RenameIndex(
                name: "IX_commands_platform-id",
                table: "command",
                newName: "IX_command_platform-id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_command",
                table: "command",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_command_platforms_platform-id",
                table: "command",
                column: "platform-id",
                principalTable: "platforms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
