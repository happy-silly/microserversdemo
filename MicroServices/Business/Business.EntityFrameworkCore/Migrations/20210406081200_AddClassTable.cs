using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddClassTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infrastructure_ClassTable",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TextileProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TsId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamSet = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    OrdClass = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ClassNum = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infrastructure_ClassTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Infrastructure_ClassTable_TextileProcess_TextileProcessId",
                        column: x => x.TextileProcessId,
                        principalSchema: "dbo",
                        principalTable: "TextileProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_ClassTable_TextileProcessId",
                schema: "dbo",
                table: "Infrastructure_ClassTable",
                column: "TextileProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infrastructure_ClassTable",
                schema: "dbo");
        }
    }
}
