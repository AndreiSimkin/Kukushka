using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kukushka.Network.Migrations
{
    public partial class Add_Users_AcceptConnectionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "AcceptConnectionType",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptConnectionType",
                table: "Users");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Status",
                table: "Users",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "INTEGER");
        }
    }
}
