using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class CreateTextileOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceEngineer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainProducts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextileGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextileGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineTypeAbbr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachinePicPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JingweiLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatedSpeed = table.Column<float>(type: "real", nullable: true),
                    FontAwesomeIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineType_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "dbo",
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpinningMill",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextileGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpinningMill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpinningMill_TextileGroup_TextileGroupId",
                        column: x => x.TextileGroupId,
                        principalSchema: "dbo",
                        principalTable: "TextileGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MachineDocument",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineNo = table.Column<int>(type: "int", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModbusAddr = table.Column<byte>(type: "tinyint", nullable: true),
                    Subtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpcVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSpindles = table.Column<int>(type: "int", nullable: true),
                    Segments = table.Column<int>(type: "int", nullable: true),
                    YarnBreakDetection = table.Column<int>(type: "int", nullable: true),
                    RecordTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MachineTypeId = table.Column<int>(type: "int", nullable: true),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineDocument_MachineType_MachineTypeId",
                        column: x => x.MachineTypeId,
                        principalSchema: "dbo",
                        principalTable: "MachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MachineDocument_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextileProcess",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProcessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextileProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextileProcess_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MachineDocument_MachineTypeId",
                schema: "dbo",
                table: "MachineDocument",
                column: "MachineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineDocument_SpinningMillId",
                schema: "dbo",
                table: "MachineDocument",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineType_ManufacturerId",
                schema: "dbo",
                table: "MachineType",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_SpinningMill_TextileGroupId",
                schema: "dbo",
                table: "SpinningMill",
                column: "TextileGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TextileProcess_SpinningMillId",
                schema: "dbo",
                table: "TextileProcess",
                column: "SpinningMillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MachineDocument",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TextileProcess",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MachineType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SpinningMill",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Manufacturer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TextileGroup",
                schema: "dbo");
        }
    }
}
