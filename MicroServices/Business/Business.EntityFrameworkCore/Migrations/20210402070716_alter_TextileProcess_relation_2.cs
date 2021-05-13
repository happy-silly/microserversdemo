using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class alter_TextileProcess_relation_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TextileProcess_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropIndex(
                name: "IX_TextileProcess_SpinningMillId",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropColumn(
                name: "SpinningMillId",
                schema: "dbo",
                table: "TextileProcess");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SpinningMillId",
                schema: "dbo",
                table: "TextileProcess",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TextileProcess_SpinningMillId",
                schema: "dbo",
                table: "TextileProcess",
                column: "SpinningMillId");

            migrationBuilder.AddForeignKey(
                name: "FK_TextileProcess_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "TextileProcess",
                column: "SpinningMillId",
                principalSchema: "dbo",
                principalTable: "SpinningMill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
