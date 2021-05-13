﻿// <auto-generated />
using System;
using Business.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace Business.Migrations
{
    [DbContext(typeof(BusinessDbContext))]
    [Migration("20210402070513_alter_TextileProcess_relation")]
    partial class alter_TextileProcess_relation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Business.Models.MachineDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MachineNo")
                        .HasColumnType("int");

                    b.Property<int?>("MachineTypeId")
                        .HasColumnType("int");

                    b.Property<byte?>("ModbusAddr")
                        .HasColumnType("tinyint");

                    b.Property<string>("ProcessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecordTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Segments")
                        .HasColumnType("int");

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpinningMillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Subtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalSpindles")
                        .HasColumnType("int");

                    b.Property<string>("UpcVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YarnBreakDetection")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MachineTypeId");

                    b.HasIndex("SpinningMillId");

                    b.ToTable("MachineDocument", "dbo");
                });

            modelBuilder.Entity("Business.Models.MachineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("FontAwesomeIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JingweiLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("MachineDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineDescriptionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachinePicPrefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineTypeAbbr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("ProcessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("RatedSpeed")
                        .HasColumnType("real");

                    b.Property<Guid?>("TextileProcessId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("TextileProcessId");

                    b.ToTable("MachineType", "dbo");
                });

            modelBuilder.Entity("Business.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coordinates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("MainProducts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SEPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceEngineer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer", "dbo");
                });

            modelBuilder.Entity("Business.Models.SpinningMill", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coordinates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("MillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TextileGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TextileGroupId");

                    b.ToTable("SpinningMill", "dbo");
                });

            modelBuilder.Entity("Business.Models.TextileGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Slogan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TextileGroup", "dbo");
                });

            modelBuilder.Entity("Business.Models.TextileProcess", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("ProcessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpinningMillId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SpinningMillId");

                    b.ToTable("TextileProcess", "dbo");
                });

            modelBuilder.Entity("Business.Models.MachineDocument", b =>
                {
                    b.HasOne("Business.Models.MachineType", "MachineType")
                        .WithMany("MachineDocuments")
                        .HasForeignKey("MachineTypeId");

                    b.HasOne("Business.Models.SpinningMill", "SpinningMill")
                        .WithMany("MachineDocuments")
                        .HasForeignKey("SpinningMillId");

                    b.Navigation("MachineType");

                    b.Navigation("SpinningMill");
                });

            modelBuilder.Entity("Business.Models.MachineType", b =>
                {
                    b.HasOne("Business.Models.Manufacturer", "Manufacturer")
                        .WithMany("MachineTypes")
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Business.Models.TextileProcess", "TextileProcess")
                        .WithMany("MachineTypes")
                        .HasForeignKey("TextileProcessId");

                    b.Navigation("Manufacturer");

                    b.Navigation("TextileProcess");
                });

            modelBuilder.Entity("Business.Models.SpinningMill", b =>
                {
                    b.HasOne("Business.Models.TextileGroup", "TextileGroup")
                        .WithMany("SpinningMills")
                        .HasForeignKey("TextileGroupId");

                    b.Navigation("TextileGroup");
                });

            modelBuilder.Entity("Business.Models.TextileProcess", b =>
                {
                    b.HasOne("Business.Models.SpinningMill", null)
                        .WithMany("TextileProcesses")
                        .HasForeignKey("SpinningMillId");
                });

            modelBuilder.Entity("Business.Models.MachineType", b =>
                {
                    b.Navigation("MachineDocuments");
                });

            modelBuilder.Entity("Business.Models.Manufacturer", b =>
                {
                    b.Navigation("MachineTypes");
                });

            modelBuilder.Entity("Business.Models.SpinningMill", b =>
                {
                    b.Navigation("MachineDocuments");

                    b.Navigation("TextileProcesses");
                });

            modelBuilder.Entity("Business.Models.TextileGroup", b =>
                {
                    b.Navigation("SpinningMills");
                });

            modelBuilder.Entity("Business.Models.TextileProcess", b =>
                {
                    b.Navigation("MachineTypes");
                });
#pragma warning restore 612, 618
        }
    }
}