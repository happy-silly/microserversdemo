using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AlterLtPositionRttemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtPositionRttemp_Assets_MachineDocument_Id",
                schema: "dbo",
                table: "Production_LtPositionRttemp");

            migrationBuilder.AddColumn<Guid>(
                name: "MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Production_LtPositionRttemp_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp",
                column: "MachineDocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtPositionRttemp_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtPositionRttemp_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp");

            migrationBuilder.DropIndex(
                name: "IX_Production_LtPositionRttemp_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp");

            migrationBuilder.DropColumn(
                name: "MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionRttemp");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtPositionRttemp_Assets_MachineDocument_Id",
                schema: "dbo",
                table: "Production_LtPositionRttemp",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
