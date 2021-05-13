using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class alter_TextileProcess_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineDocument_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.DropIndex(
                name: "IX_MachineDocument_TextileProcessId",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.DropColumn(
                name: "TextileProcessId",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.AddColumn<Guid>(
                name: "TextileProcessId",
                schema: "dbo",
                table: "MachineType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MachineType_TextileProcessId",
                schema: "dbo",
                table: "MachineType",
                column: "TextileProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineType_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineType",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineType_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropIndex(
                name: "IX_MachineType_TextileProcessId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropColumn(
                name: "TextileProcessId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.AddColumn<Guid>(
                name: "TextileProcessId",
                schema: "dbo",
                table: "MachineDocument",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MachineDocument_TextileProcessId",
                schema: "dbo",
                table: "MachineDocument",
                column: "TextileProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineDocument_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineDocument",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
