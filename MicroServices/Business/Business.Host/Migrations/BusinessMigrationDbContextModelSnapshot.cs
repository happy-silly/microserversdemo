﻿// <auto-generated />
using System;
using Business.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace Business.Migrations
{
    [DbContext(typeof(BusinessMigrationDbContext))]
    partial class BusinessMigrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("XCZ.FormManagement.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Api")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Disabled")
                        .HasColumnType("bit");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EntityName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Namespace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Remark")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TableName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("base_form");
                });

            modelBuilder.Entity("XCZ.FormManagement.FormField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DefaultValue")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Disabled")
                        .HasColumnType("bit");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FieldType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSort")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("Maxlength")
                        .HasColumnType("int");

                    b.Property<string>("Options")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placeholder")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Regx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("base_form_fields");
                });
#pragma warning restore 612, 618
        }
    }
}
