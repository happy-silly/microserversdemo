using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class AlterDbTablePrefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Infrastructure_ClassTable_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Infrastructure_ClassTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineDocument_MachineType_MachineTypeId",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineDocument_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineType_Manufacturer_ManufacturerId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineType_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_BtMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_BtMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_CsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_CsMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_HmMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_HmMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_JsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_JsMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_LtGroupShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtGroupShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_LtMachineRttemp_MachineDocument_Id",
                schema: "dbo",
                table: "Process_LtMachineRttemp");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_LtMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_LtPositionProductionReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtPositionProductionReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_SmMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_SmMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_TbjMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_XsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_XsMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_SpinningMill_TextileGroup_TextileGroupId",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextileProcess",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextileGroup",
                schema: "dbo",
                table: "TextileGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpinningMill",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_XsMachineShiftReport",
                schema: "dbo",
                table: "Process_XsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_TbjMachineShiftReport",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_SmMachineShiftReport",
                schema: "dbo",
                table: "Process_SmMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_LtPositionProductionReport",
                schema: "dbo",
                table: "Process_LtPositionProductionReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_LtMachineShiftReport",
                schema: "dbo",
                table: "Process_LtMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_LtMachineRttemp",
                schema: "dbo",
                table: "Process_LtMachineRttemp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_LtGroupShiftReport",
                schema: "dbo",
                table: "Process_LtGroupShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_JsMachineShiftReport",
                schema: "dbo",
                table: "Process_JsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_HmMachineShiftReport",
                schema: "dbo",
                table: "Process_HmMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_CsMachineShiftReport",
                schema: "dbo",
                table: "Process_CsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_BtMachineShiftReport",
                schema: "dbo",
                table: "Process_BtMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                schema: "dbo",
                table: "Manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachineType",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachineDocument",
                schema: "dbo",
                table: "MachineDocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Infrastructure_ClassTable",
                schema: "dbo",
                table: "Infrastructure_ClassTable");

            migrationBuilder.DropColumn(
                name: "AverageSpindleSpeed",
                schema: "dbo",
                table: "Process_XsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "FrontRollerSpeed",
                schema: "dbo",
                table: "Process_XsMachineShiftReport");

            migrationBuilder.RenameTable(
                name: "TextileProcess",
                schema: "dbo",
                newName: "Assets_TextileProcess",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "TextileGroup",
                schema: "dbo",
                newName: "Assets_TextileGroup",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "SpinningMill",
                schema: "dbo",
                newName: "Assets_SpinningMill",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_XsMachineShiftReport",
                schema: "dbo",
                newName: "Production_XsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_TbjMachineShiftReport",
                schema: "dbo",
                newName: "Production_TbjMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_SmMachineShiftReport",
                schema: "dbo",
                newName: "Production_SmMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_LtPositionProductionReport",
                schema: "dbo",
                newName: "Production_LtPositionProductionReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_LtMachineShiftReport",
                schema: "dbo",
                newName: "Production_LtMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_LtMachineRttemp",
                schema: "dbo",
                newName: "Production_LtMachineRttemp",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_LtGroupShiftReport",
                schema: "dbo",
                newName: "Production_LtGroupShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_JsMachineShiftReport",
                schema: "dbo",
                newName: "Production_JsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_HmMachineShiftReport",
                schema: "dbo",
                newName: "Production_HmMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_CsMachineShiftReport",
                schema: "dbo",
                newName: "Production_CsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_BtMachineShiftReport",
                schema: "dbo",
                newName: "Production_BtMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                schema: "dbo",
                newName: "Assets_Manufacturer",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MachineType",
                schema: "dbo",
                newName: "Assets_MachineType",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MachineDocument",
                schema: "dbo",
                newName: "Assets_MachineDocument",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Infrastructure_ClassTable",
                schema: "dbo",
                newName: "Process_ClassTable",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_SpinningMill_TextileGroupId",
                schema: "dbo",
                table: "Assets_SpinningMill",
                newName: "IX_Assets_SpinningMill_TextileGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_XsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                newName: "IX_Production_XsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_TbjMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                newName: "IX_Production_TbjMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_SmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                newName: "IX_Production_SmMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_LtPositionProductionReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                newName: "IX_Production_LtPositionProductionReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_LtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                newName: "IX_Production_LtMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_LtGroupShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                newName: "IX_Production_LtGroupShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_JsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                newName: "IX_Production_JsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_HmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                newName: "IX_Production_HmMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_CsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                newName: "IX_Production_CsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_BtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                newName: "IX_Production_BtMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineType_TextileProcessId",
                schema: "dbo",
                table: "Assets_MachineType",
                newName: "IX_Assets_MachineType_TextileProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineType_ManufacturerId",
                schema: "dbo",
                table: "Assets_MachineType",
                newName: "IX_Assets_MachineType_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineDocument_SpinningMillId",
                schema: "dbo",
                table: "Assets_MachineDocument",
                newName: "IX_Assets_MachineDocument_SpinningMillId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineDocument_MachineTypeId",
                schema: "dbo",
                table: "Assets_MachineDocument",
                newName: "IX_Assets_MachineDocument_MachineTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Infrastructure_ClassTable_TextileProcessId",
                schema: "dbo",
                table: "Process_ClassTable",
                newName: "IX_Process_ClassTable_TextileProcessId");

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_TextileProcess",
                schema: "dbo",
                table: "Assets_TextileProcess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_TextileGroup",
                schema: "dbo",
                table: "Assets_TextileGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_SpinningMill",
                schema: "dbo",
                table: "Assets_SpinningMill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_XsMachineShiftReport",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_TbjMachineShiftReport",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_SmMachineShiftReport",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_LtPositionProductionReport",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_LtMachineShiftReport",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_LtMachineRttemp",
                schema: "dbo",
                table: "Production_LtMachineRttemp",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_LtGroupShiftReport",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_JsMachineShiftReport",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_HmMachineShiftReport",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_CsMachineShiftReport",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production_BtMachineShiftReport",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_Manufacturer",
                schema: "dbo",
                table: "Assets_Manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_MachineType",
                schema: "dbo",
                table: "Assets_MachineType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets_MachineDocument",
                schema: "dbo",
                table: "Assets_MachineDocument",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_ClassTable",
                schema: "dbo",
                table: "Process_ClassTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_MachineDocument_Assets_MachineType_MachineTypeId",
                schema: "dbo",
                table: "Assets_MachineDocument",
                column: "MachineTypeId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_MachineDocument_Assets_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "Assets_MachineDocument",
                column: "SpinningMillId",
                principalSchema: "dbo",
                principalTable: "Assets_SpinningMill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_MachineType_Assets_Manufacturer_ManufacturerId",
                schema: "dbo",
                table: "Assets_MachineType",
                column: "ManufacturerId",
                principalSchema: "dbo",
                principalTable: "Assets_Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_MachineType_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Assets_MachineType",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "Assets_TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_SpinningMill_Assets_TextileGroup_TextileGroupId",
                schema: "dbo",
                table: "Assets_SpinningMill",
                column: "TextileGroupId",
                principalSchema: "dbo",
                principalTable: "Assets_TextileGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_ClassTable_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Process_ClassTable",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "Assets_TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_BtMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_BtMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_CsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_CsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_HmMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_HmMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_JsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_JsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtGroupShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtGroupShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtMachineRttemp_Assets_MachineDocument_Id",
                schema: "dbo",
                table: "Production_LtMachineRttemp",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_LtPositionProductionReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionProductionReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_SmMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_SmMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_TbjMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_XsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_XsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "Assets_MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_MachineDocument_Assets_MachineType_MachineTypeId",
                schema: "dbo",
                table: "Assets_MachineDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_MachineDocument_Assets_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "Assets_MachineDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_MachineType_Assets_Manufacturer_ManufacturerId",
                schema: "dbo",
                table: "Assets_MachineType");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_MachineType_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Assets_MachineType");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_SpinningMill_Assets_TextileGroup_TextileGroupId",
                schema: "dbo",
                table: "Assets_SpinningMill");

            migrationBuilder.DropForeignKey(
                name: "FK_Process_ClassTable_Assets_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Process_ClassTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_BtMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_BtMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_CsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_CsMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_HmMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_HmMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_JsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_JsMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtGroupShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtMachineRttemp_Assets_MachineDocument_Id",
                schema: "dbo",
                table: "Production_LtMachineRttemp");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_LtPositionProductionReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_LtPositionProductionReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_SmMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_SmMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_TbjMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_XsMachineShiftReport_Assets_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Production_XsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_XsMachineShiftReport",
                schema: "dbo",
                table: "Production_XsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_TbjMachineShiftReport",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_SmMachineShiftReport",
                schema: "dbo",
                table: "Production_SmMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_LtPositionProductionReport",
                schema: "dbo",
                table: "Production_LtPositionProductionReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_LtMachineShiftReport",
                schema: "dbo",
                table: "Production_LtMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_LtMachineRttemp",
                schema: "dbo",
                table: "Production_LtMachineRttemp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_LtGroupShiftReport",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_JsMachineShiftReport",
                schema: "dbo",
                table: "Production_JsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_HmMachineShiftReport",
                schema: "dbo",
                table: "Production_HmMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_CsMachineShiftReport",
                schema: "dbo",
                table: "Production_CsMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production_BtMachineShiftReport",
                schema: "dbo",
                table: "Production_BtMachineShiftReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Process_ClassTable",
                schema: "dbo",
                table: "Process_ClassTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_TextileProcess",
                schema: "dbo",
                table: "Assets_TextileProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_TextileGroup",
                schema: "dbo",
                table: "Assets_TextileGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_SpinningMill",
                schema: "dbo",
                table: "Assets_SpinningMill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_Manufacturer",
                schema: "dbo",
                table: "Assets_Manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_MachineType",
                schema: "dbo",
                table: "Assets_MachineType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets_MachineDocument",
                schema: "dbo",
                table: "Assets_MachineDocument");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_XsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_XsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_TbjMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_SmMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_SmMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtPositionProductionReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtPositionProductionReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_LtGroupShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_JsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_JsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_HmMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_HmMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_CsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_CsMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg1",
                schema: "dbo",
                table: "Production_BtMachineShiftReport");

            migrationBuilder.DropColumn(
                name: "SpeedAvg2",
                schema: "dbo",
                table: "Production_BtMachineShiftReport");

            migrationBuilder.RenameTable(
                name: "Production_XsMachineShiftReport",
                schema: "dbo",
                newName: "Process_XsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_TbjMachineShiftReport",
                schema: "dbo",
                newName: "Process_TbjMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_SmMachineShiftReport",
                schema: "dbo",
                newName: "Process_SmMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_LtPositionProductionReport",
                schema: "dbo",
                newName: "Process_LtPositionProductionReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_LtMachineShiftReport",
                schema: "dbo",
                newName: "Process_LtMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_LtMachineRttemp",
                schema: "dbo",
                newName: "Process_LtMachineRttemp",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_LtGroupShiftReport",
                schema: "dbo",
                newName: "Process_LtGroupShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_JsMachineShiftReport",
                schema: "dbo",
                newName: "Process_JsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_HmMachineShiftReport",
                schema: "dbo",
                newName: "Process_HmMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_CsMachineShiftReport",
                schema: "dbo",
                newName: "Process_CsMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Production_BtMachineShiftReport",
                schema: "dbo",
                newName: "Process_BtMachineShiftReport",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Process_ClassTable",
                schema: "dbo",
                newName: "Infrastructure_ClassTable",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_TextileProcess",
                schema: "dbo",
                newName: "TextileProcess",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_TextileGroup",
                schema: "dbo",
                newName: "TextileGroup",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_SpinningMill",
                schema: "dbo",
                newName: "SpinningMill",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_Manufacturer",
                schema: "dbo",
                newName: "Manufacturer",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_MachineType",
                schema: "dbo",
                newName: "MachineType",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Assets_MachineDocument",
                schema: "dbo",
                newName: "MachineDocument",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_Production_XsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                newName: "IX_Process_XsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_TbjMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport",
                newName: "IX_Process_TbjMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_SmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_SmMachineShiftReport",
                newName: "IX_Process_SmMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_LtPositionProductionReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtPositionProductionReport",
                newName: "IX_Process_LtPositionProductionReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_LtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtMachineShiftReport",
                newName: "IX_Process_LtMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_LtGroupShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtGroupShiftReport",
                newName: "IX_Process_LtGroupShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_JsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_JsMachineShiftReport",
                newName: "IX_Process_JsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_HmMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_HmMachineShiftReport",
                newName: "IX_Process_HmMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_CsMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_CsMachineShiftReport",
                newName: "IX_Process_CsMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_BtMachineShiftReport_MachineDocumentId",
                schema: "dbo",
                table: "Process_BtMachineShiftReport",
                newName: "IX_Process_BtMachineShiftReport_MachineDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Process_ClassTable_TextileProcessId",
                schema: "dbo",
                table: "Infrastructure_ClassTable",
                newName: "IX_Infrastructure_ClassTable_TextileProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_SpinningMill_TextileGroupId",
                schema: "dbo",
                table: "SpinningMill",
                newName: "IX_SpinningMill_TextileGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_MachineType_TextileProcessId",
                schema: "dbo",
                table: "MachineType",
                newName: "IX_MachineType_TextileProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_MachineType_ManufacturerId",
                schema: "dbo",
                table: "MachineType",
                newName: "IX_MachineType_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_MachineDocument_SpinningMillId",
                schema: "dbo",
                table: "MachineDocument",
                newName: "IX_MachineDocument_SpinningMillId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_MachineDocument_MachineTypeId",
                schema: "dbo",
                table: "MachineDocument",
                newName: "IX_MachineDocument_MachineTypeId");

            migrationBuilder.AddColumn<int>(
                name: "AverageSpindleSpeed",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrontRollerSpeed",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_XsMachineShiftReport",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_TbjMachineShiftReport",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_SmMachineShiftReport",
                schema: "dbo",
                table: "Process_SmMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_LtPositionProductionReport",
                schema: "dbo",
                table: "Process_LtPositionProductionReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_LtMachineShiftReport",
                schema: "dbo",
                table: "Process_LtMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_LtMachineRttemp",
                schema: "dbo",
                table: "Process_LtMachineRttemp",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_LtGroupShiftReport",
                schema: "dbo",
                table: "Process_LtGroupShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_JsMachineShiftReport",
                schema: "dbo",
                table: "Process_JsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_HmMachineShiftReport",
                schema: "dbo",
                table: "Process_HmMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_CsMachineShiftReport",
                schema: "dbo",
                table: "Process_CsMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Process_BtMachineShiftReport",
                schema: "dbo",
                table: "Process_BtMachineShiftReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Infrastructure_ClassTable",
                schema: "dbo",
                table: "Infrastructure_ClassTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextileProcess",
                schema: "dbo",
                table: "TextileProcess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextileGroup",
                schema: "dbo",
                table: "TextileGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpinningMill",
                schema: "dbo",
                table: "SpinningMill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                schema: "dbo",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachineType",
                schema: "dbo",
                table: "MachineType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachineDocument",
                schema: "dbo",
                table: "MachineDocument",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Infrastructure_ClassTable_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "Infrastructure_ClassTable",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineDocument_MachineType_MachineTypeId",
                schema: "dbo",
                table: "MachineDocument",
                column: "MachineTypeId",
                principalSchema: "dbo",
                principalTable: "MachineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineDocument_SpinningMill_SpinningMillId",
                schema: "dbo",
                table: "MachineDocument",
                column: "SpinningMillId",
                principalSchema: "dbo",
                principalTable: "SpinningMill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineType_Manufacturer_ManufacturerId",
                schema: "dbo",
                table: "MachineType",
                column: "ManufacturerId",
                principalSchema: "dbo",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineType_TextileProcess_TextileProcessId",
                schema: "dbo",
                table: "MachineType",
                column: "TextileProcessId",
                principalSchema: "dbo",
                principalTable: "TextileProcess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_BtMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_BtMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_CsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_CsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_HmMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_HmMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_JsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_JsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_LtGroupShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtGroupShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_LtMachineRttemp_MachineDocument_Id",
                schema: "dbo",
                table: "Process_LtMachineRttemp",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_LtMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_LtPositionProductionReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_LtPositionProductionReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_SmMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_SmMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_TbjMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_TbjMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Process_XsMachineShiftReport_MachineDocument_MachineDocumentId",
                schema: "dbo",
                table: "Process_XsMachineShiftReport",
                column: "MachineDocumentId",
                principalSchema: "dbo",
                principalTable: "MachineDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpinningMill_TextileGroup_TextileGroupId",
                schema: "dbo",
                table: "SpinningMill",
                column: "TextileGroupId",
                principalSchema: "dbo",
                principalTable: "TextileGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
