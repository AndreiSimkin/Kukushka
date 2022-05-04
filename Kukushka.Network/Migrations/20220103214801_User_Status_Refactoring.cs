using Microsoft.EntityFrameworkCore.Migrations;

namespace Kukushka.Network.Migrations
{
    public partial class User_Status_Refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Users",
                newName: "TreeLevel");

            migrationBuilder.AddColumn<bool>(
                name: "IsMobile",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMobile",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TreeLevel",
                table: "Users",
                newName: "Status");
        }
    }
}
