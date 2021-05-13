using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddCraftBigtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Craft_CraftTypeList",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineTypeId1 = table.Column<int>(type: "int", nullable: true),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortNum = table.Column<int>(type: "int", nullable: true),
                    UsageRange = table.Column<int>(type: "int", nullable: false),
                    LimitUp = table.Column<double>(type: "float", nullable: true),
                    LimitLow = table.Column<double>(type: "float", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_CraftTypeList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_CraftTypeList_Assets_MachineType_MachineTypeId1",
                        column: x => x.MachineTypeId1,
                        principalSchema: "dbo",
                        principalTable: "Assets_MachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Craft_CraftTypeList_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Craft_CraftTypeList_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Craft_RecipeRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpCompile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpVerifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpApprover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_RecipeRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_RecipeRecord_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Craft_RecipeRecord_Process_ArticleRecord_ArticleRecordId",
                        column: x => x.ArticleRecordId,
                        principalSchema: "dbo",
                        principalTable: "Process_ArticleRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Craft_RecipeRecordDetail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftTypeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_RecipeRecordDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_RecipeRecordDetail_Craft_CraftTypeList_CraftTypeListId",
                        column: x => x.CraftTypeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftTypeList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Craft_RecipeRecordDetail_Craft_RecipeRecord_RecipeRecordId",
                        column: x => x.RecipeRecordId,
                        principalSchema: "dbo",
                        principalTable: "Craft_RecipeRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftTypeList_CraftNodeListId",
                schema: "dbo",
                table: "Craft_CraftTypeList",
                column: "CraftNodeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftTypeList_MachineTypeId1",
                schema: "dbo",
                table: "Craft_CraftTypeList",
                column: "MachineTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftTypeList_SpinningMillId",
                schema: "dbo",
                table: "Craft_CraftTypeList",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_RecipeRecord_ArticleRecordId",
                schema: "dbo",
                table: "Craft_RecipeRecord",
                column: "ArticleRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_RecipeRecord_SpinningMillId",
                schema: "dbo",
                table: "Craft_RecipeRecord",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_RecipeRecordDetail_CraftTypeListId",
                schema: "dbo",
                table: "Craft_RecipeRecordDetail",
                column: "CraftTypeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_RecipeRecordDetail_RecipeRecordId",
                schema: "dbo",
                table: "Craft_RecipeRecordDetail",
                column: "RecipeRecordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Craft_RecipeRecordDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Craft_CraftTypeList",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Craft_RecipeRecord",
                schema: "dbo");
        }
    }
}
