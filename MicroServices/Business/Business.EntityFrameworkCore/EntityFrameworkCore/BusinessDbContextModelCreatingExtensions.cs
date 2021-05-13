using Business.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Business.Models.Order;
using Business.Models.Production;
using Business.Models.Craft;

namespace Business.EntityFrameworkCore
{
    public static class BusinessDbContextModelCreatingExtensions
    {
        public static void ConfigureBusiness(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<TextileGroup>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix + "TextileGroup", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.GroupName).IsRequired();
            });

            builder.Entity<SpinningMill>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix+"SpinningMill", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.MillName).IsRequired();
            });

            builder.Entity<MachineDocument>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix + "MachineDocument", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.MachineName).IsRequired();
            });

            builder.Entity<MachineType>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix + "MachineType", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.MachineTypeName).IsRequired();
            });

            builder.Entity<Manufacturer>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix + "Manufacturer", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.CompanyName).IsRequired();
            });

            builder.Entity<TextileProcess>(op =>
            {
                op.ToTable(BusinessConst.AssetsDbTablePrefix + "TextileProcess", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.ProcessName).IsRequired();
            });
            builder.Entity<ClassTable>(op =>
            {
                op.ToTable(BusinessConst.ProcessDbTablePrefix+"ClassTable", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.Property(o => o.TsId).IsRequired();
                op.Property(o => o.TeamSet).HasMaxLength(1);
                op.Property(o => o.OrdClass).HasMaxLength(1);
            });
            builder.Entity<LtMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "LtMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<LtGroupShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "LtGroupShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<LtPositionProductionReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "LtPositionProductionReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<XsMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "XsMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<CsMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "CsMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<BtMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "BtMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<JsMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "JsMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<TbjMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "TbjMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<SmMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "SmMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<HmMachineShiftReport>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "HmMachineShiftReport", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<LtMachineRttemp>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "LtMachineRttemp", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<LtPositionRttemp>(op =>
            {
                op.ToTable(BusinessConst.ProductionDbTablePrefix + "LtPositionRttemp", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<ArticleRecord>(op =>
            {
                op.ToTable(BusinessConst.ProcessDbTablePrefix + "ArticleRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<Material>(op =>
            {
                op.ToTable(BusinessConst.ProcessDbTablePrefix + "Material", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<Book>(b =>
            {
                b.ToTable("Book");

                b.ConfigureByConvention();

                b.Property(x => x.Name).IsRequired();

        
            });
            builder.Entity<FactoryProgramRecord>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "FactoryProgramRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<OrderCraftFlowAssociation>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "OrderCraftFlowAssociation", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
                op.HasOne(p => p.FactoryProgramRecord).WithMany(q => q.OrderCraftFlowAssociations).OnDelete(DeleteBehavior.NoAction);
                op.HasOne(p => p.CraftFlowRecord).WithMany(q => q.OrderCraftFlowAssociations).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<CraftNodeList>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "CraftNodeList", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<CraftFlowRecord>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "CraftFlowRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<CraftFlowRecordDetail>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "CraftFlowRecordDetail", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                                            //op.HasKey(o => o.MachineDocumentId);
                op.HasOne(p => p.Material).WithMany(q => q.CraftFlowRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<CraftTypeList>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "CraftTypeList", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasKey(o => o.MachineDocumentId);
            });
            builder.Entity<RecipeRecord>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "RecipeRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.HasOne(p => p.SpinningMill).WithMany(q => q.RecipeRecords).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<RecipeRecordDetail>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "RecipeRecordDetail", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.HasOne(p => p.CraftTypeList).WithMany(q => q.RecipeRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<CraftNodeTextileProcessAssociation>(op =>
            {
                op.ToTable(BusinessConst.CraftDbTablePrefix + "CraftNodeTextileProcessAssociation", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasOne(p => p.C).WithMany(q => q.RecipeRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<OrderProgramRecord>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "OrderProgramRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasOne(p => p.C).WithMany(q => q.RecipeRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<MachineCertificate>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "MachineCertificate", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasOne(p => p.C).WithMany(q => q.RecipeRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<MachineCertificateRecord>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "MachineCertificateRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.HasOne(p => p.ProcessDispatchQueue).WithMany(q => q.MachineCertificateRecords).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<ProgramCraftItem>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "ProgramCraftItem", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                //op.HasOne(p => p.C).WithMany(q => q.RecipeRecordDetails).OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<ProgramCraftItemRecord>(op =>
            {
                op.ToTable(BusinessConst.OrderDbTablePrefix + "ProgramCraftItemRecord", BusinessConst.DbSchema);
                op.ConfigureByConvention(); //auto configure for the base class props
                op.HasOne(p => p.ProcessDispatchQueue).WithMany(q => q.ProgramCraftItemRecords).OnDelete(DeleteBehavior.NoAction);
            });
            //Code generation...
        }
    }
}
