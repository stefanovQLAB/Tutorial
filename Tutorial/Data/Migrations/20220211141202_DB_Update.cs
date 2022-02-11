using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutorial.Data.Migrations
{
    public partial class DB_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfError",
                table: "Errors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Errors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Errors_DeveloperId",
                table: "Errors",
                column: "DeveloperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Developers_DeveloperId",
                table: "Errors",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Developers_DeveloperId",
                table: "Errors");

            migrationBuilder.DropIndex(
                name: "IX_Errors_DeveloperId",
                table: "Errors");

            migrationBuilder.DropColumn(
                name: "DateOfError",
                table: "Errors");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Errors");
        }
    }
}
