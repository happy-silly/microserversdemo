using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AddLtMachineRttemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Process_LtMachineRttemp",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineWeight = table.Column<double>(type: "float", nullable: true),
                    MachineEfc = table.Column<double>(type: "float", nullable: true),
                    WorkState = table.Column<int>(type: "int", nullable: true),
                    SingleSpindleEnterNum = table.Column<int>(type: "int", nullable: true),
                    CurrentShift = table.Column<int>(type: "int", nullable: true),
                    YarndepotEmptyTubeEcho = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadPassNum = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadSuccessNum = table.Column<int>(type: "int", nullable: true),
                    SecondRawHeadPassNum = table.Column<int>(type: "int", nullable: true),
                    SecondRawHeadSuccessNum = table.Column<int>(type: "int", nullable: true),
                    TubeDrawingPassNum = table.Column<int>(type: "int", nullable: true),
                    FirstRawHeadRatio = table.Column<double>(type: "float", nullable: true),
                    SecondRawHeadRatio = table.Column<double>(type: "float", nullable: true),
                    YarndepotResidualRatio = table.Column<double>(type: "float", nullable: true),
                    YarndepotEmptyTubeRatio = table.Column<double>(type: "float", nullable: true),
                    TotalFullCylinder_num = table.Column<int>(type: "int", nullable: true),
                    TotalFallingCylinderSuccessRatio = table.Column<double>(type: "float", nullable: true),
                    FallingCylinderSuccessNum = table.Column<int>(type: "int", nullable: true),
                    FullCylinderNum = table.Column<int>(type: "int", nullable: true),
                    FallingCylinderSuccessRatio = table.Column<double>(type: "float", nullable: true),
                    MachineFault = table.Column<int>(type: "int", nullable: true),
                    DirectPowerFault = table.Column<int>(type: "int", nullable: true),
                    EsperoFault = table.Column<int>(type: "int", nullable: true),
                    BigYarnLibFault1 = table.Column<int>(type: "int", nullable: true),
                    BigYarnLibFault2 = table.Column<int>(type: "int", nullable: true),
                    YarnLibPlateFault = table.Column<int>(type: "int", nullable: true),
                    CanCnt = table.Column<int>(type: "int", nullable: true),
                    CanSucceedCount = table.Column<int>(type: "int", nullable: true),
                    HmiHardware = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HmiSoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Process_LtMachineRttemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_LtMachineRttemp_MachineDocument_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "MachineDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Process_LtMachineRttemp",
                schema: "dbo");
        }
    }
}
