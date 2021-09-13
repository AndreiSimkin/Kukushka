using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kukushka.Network.Migrations
{
    public partial class Add_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "BLOB", nullable: false),
                    IP = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Port = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Status = table.Column<byte[]>(type: "BLOB", nullable: true),
                    ActivityTime = table.Column<byte[]>(type: "BLOB", nullable: true),
                    RsaOpenKey = table.Column<byte[]>(type: "BLOB", nullable: true),
                    FreeSpace = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
