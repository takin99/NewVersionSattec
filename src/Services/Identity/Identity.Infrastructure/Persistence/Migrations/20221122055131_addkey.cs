using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sattec.Identity.Infrastructure.Persistence.Migrations
{
    public partial class addkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccount_Bank_BankId",
                table: "BankAccount");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount");

            migrationBuilder.DropIndex(
                name: "IX_BankAccount_BankId",
                table: "BankAccount");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BankAccount");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BankAccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount",
                column: "BankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BankAccount");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "BankAccount",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefaultAccount = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccount_BankId",
                table: "BankAccount",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccount_Bank_BankId",
                table: "BankAccount",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
