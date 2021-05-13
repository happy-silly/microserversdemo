using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddLtGroupHt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginTimeFromUpComputer",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTimeFromUpComputer",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Craft_CraftNodeList",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextileProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortNum = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_CraftNodeList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_CraftNodeList_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Craft_CraftNodeList_Assets_TextileProcess_TextileProcessId",
                        column: x => x.TextileProcessId,
                        principalSchema: "dbo",
                        principalTable: "Assets_TextileProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Production_LtPositionRttemp",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: true),
                    YarnFaultCuts = table.Column<int>(type: "int", nullable: true),
                    YarnFaultCutsPer10Km = table.Column<int>(type: "int", nullable: true),
                    ConeCuts = table.Column<int>(type: "int", nullable: true),
                    BobbinCuts = table.Column<int>(type: "int", nullable: true),
                    YarnWeight = table.Column<double>(type: "float", nullable: true),
                    SpoolSucceedCnt = table.Column<int>(type: "int", nullable: true),
                    SigleWeight = table.Column<double>(type: "float", nullable: true),
                    SigleLength = table.Column<int>(type: "int", nullable: true),
                    TiedTimeAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiedCnt = table.Column<int>(type: "int", nullable: true),
                    TiedTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpliceCnt = table.Column<int>(type: "int", nullable: true),
                    JointCnt = table.Column<int>(type: "int", nullable: true),
                    JointCntPer10Km = table.Column<int>(type: "int", nullable: true),
                    ConeJointCnt = table.Column<int>(type: "int", nullable: true),
                    BobbinChanges = table.Column<int>(type: "int", nullable: true),
                    ConeCnt = table.Column<int>(type: "int", nullable: true),
                    WorkTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoffAvgTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoffCnt = table.Column<int>(type: "int", nullable: true),
                    DoffTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlarmTimeAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlarmCnt = table.Column<int>(type: "int", nullable: true),
                    AlarmTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaultTimeAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaultCnt = table.Column<int>(type: "int", nullable: true),
                    FaultTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicalEfc = table.Column<double>(type: "float", nullable: true),
                    ProductionEfc = table.Column<double>(type: "float", nullable: true),
                    TechnicalAlarmTimeAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalAlarmCnt = table.Column<int>(type: "int", nullable: true),
                    TechnicalAlarmTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentShiftLength = table.Column<double>(type: "float", nullable: true),
                    CurrentLength = table.Column<double>(type: "float", nullable: true),
                    FixLength = table.Column<int>(type: "int", nullable: true),
                    RemainLength = table.Column<double>(type: "float", nullable: true),
                    TotalLength = table.Column<double>(type: "float", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceState = table.Column<int>(type: "int", nullable: true),
                    StateCode = table.Column<int>(type: "int", nullable: true),
                    TotalLengthCal = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutputLengthStart = table.Column<double>(type: "float", nullable: true),
                    RunTimes = table.Column<int>(type: "int", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    CommunicateErrorCnt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production_LtPositionRttemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Production_LtPositionRttemp_Assets_MachineDocument_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "Assets_MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_ArticleRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleColor = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ArticleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YarnCount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CottonAssorting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCraftNodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_ArticleRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_ArticleRecord_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Process_ArticleRecord_Craft_CraftNodeList_LastCraftNodeId",
                        column: x => x.LastCraftNodeId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Process_Material",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftNodeListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CottonAssort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightPerLength = table.Column<double>(type: "float", nullable: false),
                    WeightPerLengthUnit = table.Column<int>(type: "int", nullable: false),
                    MoistureRegain = table.Column<double>(type: "float", nullable: true),
                    YieldRate = table.Column<double>(type: "float", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_Material_Craft_CraftNodeList_CraftNodeListId",
                        column: x => x.CraftNodeListId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftNodeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Craft_CraftFlowRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftFlowFlag = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_CraftFlowRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_CraftFlowRecord_Process_ArticleRecord_ArticleRecordId",
                        column: x => x.ArticleRecordId,
                        principalSchema: "dbo",
                        principalTable: "Process_ArticleRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_FactoryProgramRecord",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpinningMillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduledStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MakeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArtilceRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArticleRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DueWeight = table.Column<double>(type: "float", nullable: false),
                    OrderFlag = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_FactoryProgramRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_FactoryProgramRecord_Assets_SpinningMill_SpinningMillId",
                        column: x => x.SpinningMillId,
                        principalSchema: "dbo",
                        principalTable: "Assets_SpinningMill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_FactoryProgramRecord_Process_ArticleRecord_ArticleRecordId",
                        column: x => x.ArticleRecordId,
                        principalSchema: "dbo",
                        principalTable: "Process_ArticleRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Craft_CraftFlowRecordDetail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftFlowRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percenty = table.Column<double>(type: "float", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craft_CraftFlowRecordDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craft_CraftFlowRecordDetail_Craft_CraftFlowRecord_CraftFlowRecordId",
                        column: x => x.CraftFlowRecordId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftFlowRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Craft_CraftFlowRecordDetail_Process_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Process_Material",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Craft_CraftFlowRecordDetail_Process_Material_PreMaterialId",
                        column: x => x.PreMaterialId,
                        principalSchema: "dbo",
                        principalTable: "Process_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_OrderCraftFlowAssociation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FactoryProgramRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CraftFlowRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_OrderCraftFlowAssociation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderCraftFlowAssociation_Craft_CraftFlowRecord_CraftFlowRecordId",
                        column: x => x.CraftFlowRecordId,
                        principalSchema: "dbo",
                        principalTable: "Craft_CraftFlowRecord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_OrderCraftFlowAssociation_Order_FactoryProgramRecord_FactoryProgramRecordId",
                        column: x => x.FactoryProgramRecordId,
                        principalSchema: "dbo",
                        principalTable: "Order_FactoryProgramRecord",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftFlowRecord_ArticleRecordId",
                schema: "dbo",
                table: "Craft_CraftFlowRecord",
                column: "ArticleRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftFlowRecordDetail_CraftFlowRecordId",
                schema: "dbo",
                table: "Craft_CraftFlowRecordDetail",
                column: "CraftFlowRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftFlowRecordDetail_MaterialId",
                schema: "dbo",
                table: "Craft_CraftFlowRecordDetail",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftFlowRecordDetail_PreMaterialId",
                schema: "dbo",
                table: "Craft_CraftFlowRecordDetail",
                column: "PreMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftNodeList_SpinningMillId",
                schema: "dbo",
                table: "Craft_CraftNodeList",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Craft_CraftNodeList_TextileProcessId",
                schema: "dbo",
                table: "Craft_CraftNodeList",
                column: "TextileProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FactoryProgramRecord_ArticleRecordId",
                schema: "dbo",
                table: "Order_FactoryProgramRecord",
                column: "ArticleRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FactoryProgramRecord_SpinningMillId",
                schema: "dbo",
                table: "Order_FactoryProgramRecord",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderCraftFlowAssociation_CraftFlowRecordId",
                schema: "dbo",
                table: "Order_OrderCraftFlowAssociation",
                column: "CraftFlowRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderCraftFlowAssociation_FactoryProgramRecordId",
                schema: "dbo",
                table: "Order_OrderCraftFlowAssociation",
                column: "FactoryProgramRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_ArticleRecord_LastCraftNodeId",
                schema: "dbo",
                table: "Process_ArticleRecord",
                column: "LastCraftNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_ArticleRecord_SpinningMillId",
                schema: "dbo",
                table: "Process_ArticleRecord",
                column: "SpinningMillId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_Material_CraftNodeListId",
                schema: "dbo",
                table: "Process_Material",
                column: "CraftNodeListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Craft_CraftFlowRecordDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order_OrderCraftFlowAssociation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Production_LtPositionRttemp",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_Material",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Craft_CraftFlowRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order_FactoryProgramRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_ArticleRecord",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Craft_CraftNodeList",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "BeginTimeFromUpComputer",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.DropColumn(
                name: "UpdateTimeFromUpComputer",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tsid",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
