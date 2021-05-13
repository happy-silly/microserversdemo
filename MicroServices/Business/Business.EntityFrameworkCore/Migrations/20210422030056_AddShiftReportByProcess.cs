using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddShiftReportByProcess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Process_BtMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageDeliverySpeed = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_BtMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_BtMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_CsMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageSpindleSpeed = table.Column<int>(type: "int", nullable: true),
                    MaxSpindleSpeed = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_CsMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_CsMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_HmMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Power = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    AverageWarehousePressure = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_HmMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_HmMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_JsMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageDeliverySpeed = table.Column<int>(type: "int", nullable: true),
                    AverageCardingSpeed = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_JsMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_JsMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_LtGroupShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: false),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_LtGroupShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_LtGroupShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_LtMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SingleSpindleEnterNum = table.Column<int>(type: "int", nullable: true),
                    YarndepotEmptyTubeEcho = table.Column<int>(type: "int", nullable: true),
                    YarndepotResidualNum = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadPassNum = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadSuccessNum = table.Column<int>(type: "int", nullable: true),
                    SecondRawHeadPassNum = table.Column<int>(type: "int", nullable: true),
                    SecondRawHeadSuccessNum = table.Column<int>(type: "int", nullable: true),
                    TubeDrawingPassNum = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadRatio = table.Column<double>(type: "float", nullable: true),
                    SecondRawHeadRatio = table.Column<double>(type: "float", nullable: true),
                    YarndepotResidualRatio = table.Column<double>(type: "float", nullable: true),
                    YarndepotEmptyTubeRatio = table.Column<double>(type: "float", nullable: true),
                    FallingCylinderSuccessNum = table.Column<int>(type: "int", nullable: true),
                    FullCylinderNum = table.Column<int>(type: "int", nullable: true),
                    FallingCylinderSuccessRatio = table.Column<double>(type: "float", nullable: true),
                    TotalFullCylinder_num = table.Column<int>(type: "int", nullable: true),
                    TotalFallingCylinderSuccessRatio = table.Column<double>(type: "float", nullable: true),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_LtMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_LtMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_LtPositionProductionReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_LtPositionProductionReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_LtPositionProductionReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_SmMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageDeliverySpeed = table.Column<int>(type: "int", nullable: true),
                    AverageProductionRate = table.Column<double>(type: "float", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_SmMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_SmMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_TbjMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageVehicleSpeed = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_TbjMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_TbjMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process_XsMachineShiftReport",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassStartLength = table.Column<long>(type: "bigint", nullable: true),
                    ClassEndLength = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalStart = table.Column<long>(type: "bigint", nullable: true),
                    TotalOutputCalEnd = table.Column<long>(type: "bigint", nullable: true),
                    YarnLength = table.Column<double>(type: "float", nullable: true),
                    TheoreticalYarnWeight = table.Column<double>(type: "float", nullable: true),
                    ActualYarnWeight = table.Column<double>(type: "float", nullable: true),
                    Coe = table.Column<double>(type: "float", nullable: true),
                    EfcRun = table.Column<double>(type: "float", nullable: true),
                    ProductionDispatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PowerPerWeight = table.Column<double>(type: "float", nullable: true),
                    AverageSpindleSpeed = table.Column<int>(type: "int", nullable: true),
                    MaxSpindleSpeed = table.Column<int>(type: "int", nullable: true),
                    FrontRollerSpeed = table.Column<int>(type: "int", nullable: true),
                    AverageActualTwist = table.Column<double>(type: "float", nullable: true),
                    RollerDiameter = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tsid = table.Column<int>(type: "int", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftNum = table.Column<int>(type: "int", nullable: true),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process_XsMachineShiftReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_XsMachineShiftReport_MachineDocument_MachineDocumentId",
                        column: x => x.MachineDocumentId,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Process_BtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_BtMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_CsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_CsMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_HmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_HmMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_JsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_JsMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_LtGroupShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtGroupShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_LtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_LtPositionProductionReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtPositionProductionReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_SmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_SmMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_TbjMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport",
                column: "MachineDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_XsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                column: "MachineDocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Process_BtMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_CsMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_HmMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_JsMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_LtGroupShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_LtMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_LtPositionProductionReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_SmMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_TbjMachineShiftReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Process_XsMachineShiftReport",
                schema: "dbo");
        }
    }
}
