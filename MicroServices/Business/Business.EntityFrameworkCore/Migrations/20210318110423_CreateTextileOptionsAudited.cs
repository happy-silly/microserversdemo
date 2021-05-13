using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class CreateTextileOptionsAudited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "dbo",
                table: "TextileProcess",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                schema: "dbo",
                table: "TextileProcess",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "dbo",
                table: "TextileProcess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                schema: "dbo",
                table: "TextileProcess",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "dbo",
                table: "TextileGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                schema: "dbo",
                table: "TextileGroup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "dbo",
                table: "TextileGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                schema: "dbo",
                table: "TextileGroup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "dbo",
                table: "SpinningMill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                schema: "dbo",
                table: "SpinningMill",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "dbo",
                table: "SpinningMill",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                schema: "dbo",
                table: "SpinningMill",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "dbo",
                table: "Manufacturer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                schema: "dbo",
                table: "Manufacturer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "dbo",
                table: "Manufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                schema: "dbo",
                table: "Manufacturer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                schema: "dbo",
                table: "MachineType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                schema: "dbo",
                table: "MachineType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                schema: "dbo",
                table: "MachineType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                schema: "dbo",
                table: "MachineType",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                schema: "dbo",
                table: "TextileProcess");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "dbo",
                table: "TextileGroup");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                schema: "dbo",
                table: "TextileGroup");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "dbo",
                table: "TextileGroup");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                schema: "dbo",
                table: "TextileGroup");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                schema: "dbo",
                table: "SpinningMill");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "dbo",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                schema: "dbo",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "dbo",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                schema: "dbo",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                schema: "dbo",
                table: "MachineType");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                schema: "dbo",
                table: "MachineType");
        }
    }
}
