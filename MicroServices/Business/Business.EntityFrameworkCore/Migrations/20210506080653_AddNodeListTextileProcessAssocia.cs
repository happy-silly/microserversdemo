using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddNodeListTextileProcessAssocia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Craft_CraftNodeList_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList");

            migrationBuilder.DropIndex(
                name: "IX_Craft_CraftNodeList_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList");

            migrationBuilder.DropColumn(
                name: "TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList");

            migrationBuilder.CreateTable(
                name: "Craft_CraftNodeTextileProcessAssociation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TextileProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_CraftNodeTextileProcessAssociation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_CraftNodeTextileProcessAssociation_Assets_TextileProcess_TextileProcessId",
                        column: x => x.TextileProcessId,
                        principalSchema: "dbo",
                        principalTable: "Assets_TextileProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Craft_CraftNodeTextileProcessAssociation_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftNodeTextileProcessAssociation_CraftNodeListId",
                schema: "dbo",
                table: "Craft_CraftNodeTextileProcessAssociation",
                column: "CraftNodeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftNodeTextileProcessAssociation_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeTextileProcessAssociation",
                column: "TextileProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Craft_CraftNodeTextileProcessAssociation",
                schema: "dbo");

            migrationBuilder.AddColumn<Guid>(
                name: "TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftNodeList_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList",
                column: "TextileProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Craft_CraftNodeList_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "Assets_TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
