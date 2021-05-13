using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddOrderProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order_MachineCertificate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_MachineCertificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_MachineCertificate_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_MachineCertificate_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_OrderProgramRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FactoryProgramRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MergedOrderWeight = table.Column<double>(type: "float", nullable: false),
                    YieldRate = table.Column<double>(type: "float", nullable: true),
                    ExpectedOutput = table.Column<double>(type: "float", nullable: true),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speed = table.Column<double>(type: "float", nullable: true),
                    SpeedUnit = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_OrderProgramRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderProgramRecord_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderProgramRecord_Order_FactoryProgramRecord_FactoryProgramRecordId",
                        column: x => x.FactoryProgramRecordId,
                        principalSchema: "dbo",
                        principalTable: "Order_FactoryProgramRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_OrderProgramRecord_Process_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Process_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_ProgramCraftItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineTypeId1 = table.Column<int>(type: "int", nullable: true),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_ProgramCraftItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ProgramCraftItem_Assets_MachineType_MachineTypeId1",
                        column: x => x.MachineTypeId1,
                        principalSchema: "dbo",
                        principalTable: "Assets_MachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_ProgramCraftItem_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDispatchQueues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderProgramRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ScheduledStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedOutput = table.Column<double>(type: "float", nullable: true),
                    AccomplishFlag = table.Column<int>(type: "int", nullable: false),
                    AccomplishTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmedFlag = table.Column<int>(type: "int", nullable: false),
                    ConfirmedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrintedFlag = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialPreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Lot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightPerLength = table.Column<double>(type: "float", nullable: true),
                    WeightPerLengthUnit = table.Column<int>(type: "int", nullable: true),
                    MoistureRegain = table.Column<double>(type: "float", nullable: true),
                    LabTechnicianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApproximateStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDispatchQueues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessDispatchQueues_Assets_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "Assets_MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessDispatchQueues_Order_OrderProgramRecord_OrderProgramRecordId",
                        column: x => x.OrderProgramRecordId,
                        principalSchema: "dbo",
                        principalTable: "Order_OrderProgramRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcessDispatchQueues_Process_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Process_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessDispatchQueues_Process_Material_MaterialPreId",
                        column: x => x.MaterialPreId,
                        principalSchema: "dbo",
                        principalTable: "Process_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_MachineCertificateRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineCertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessDispatchQueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_MachineCertificateRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_MachineCertificateRecord_Order_MachineCertificate_MachineCertificateId",
                        column: x => x.MachineCertificateId,
                        principalSchema: "dbo",
                        principalTable: "Order_MachineCertificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_MachineCertificateRecord_ProcessDispatchQueues_ProcessDispatchQueueId",
                        column: x => x.ProcessDispatchQueueId,
                        principalTable: "ProcessDispatchQueues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order_ProgramCraftItemRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessDispatchQueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramCraftItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_ProgramCraftItemRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ProgramCraftItemRecord_Order_ProgramCraftItem_ProgramCraftItemId",
                        column: x => x.ProgramCraftItemId,
                        principalSchema: "dbo",
                        principalTable: "Order_ProgramCraftItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_ProgramCraftItemRecord_ProcessDispatchQueues_ProcessDispatchQueueId",
                        column: x => x.ProcessDispatchQueueId,
                        principalTable: "ProcessDispatchQueues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_MachineCertificate_CraftNodeListId",
                schema: "dbo",
                table: "Order_MachineCertificate",
                column: "CraftNodeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MachineCertificate_SpinningMillId",
                schema: "dbo",
                table: "Order_MachineCertificate",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MachineCertificateRecord_MachineCertificateId",
                schema: "dbo",
                table: "Order_MachineCertificateRecord",
                column: "MachineCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MachineCertificateRecord_ProcessDispatchQueueId",
                schema: "dbo",
                table: "Order_MachineCertificateRecord",
                column: "ProcessDispatchQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderProgramRecord_CraftNodeListId",
                schema: "dbo",
                table: "Order_OrderProgramRecord",
                column: "CraftNodeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderProgramRecord_FactoryProgramRecordId",
                schema: "dbo",
                table: "Order_OrderProgramRecord",
                column: "FactoryProgramRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderProgramRecord_MaterialId",
                schema: "dbo",
                table: "Order_OrderProgramRecord",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProgramCraftItem_CraftNodeListId",
                schema: "dbo",
                table: "Order_ProgramCraftItem",
                column: "CraftNodeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProgramCraftItem_MachineTypeId1",
                schema: "dbo",
                table: "Order_ProgramCraftItem",
                column: "MachineTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProgramCraftItemRecord_ProcessDispatchQueueId",
                schema: "dbo",
                table: "Order_ProgramCraftItemRecord",
                column: "ProcessDispatchQueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProgramCraftItemRecord_ProgramCraftItemId",
                schema: "dbo",
                table: "Order_ProgramCraftItemRecord",
                column: "ProgramCraftItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessDispatchQueues_MachineDocumentId",
                table: "ProcessDispatchQueues",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessDispatchQueues_MaterialId",
                table: "ProcessDispatchQueues",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessDispatchQueues_MaterialPreId",
                table: "ProcessDispatchQueues",
                column: "MaterialPreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessDispatchQueues_OrderProgramRecordId",
                table: "ProcessDispatchQueues",
                column: "OrderProgramRecordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_MachineCertificateRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order_ProgramCraftItemRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order_MachineCertificate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order_ProgramCraftItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProcessDispatchQueues");

            migrationBuilder.DropTable(
                name: "Order_OrderProgramRecord",
                schema: "dbo");
        }
    }
}
