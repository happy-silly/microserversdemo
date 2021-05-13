using Business.Models;
using Business.Models.Craft;
using Business.Models.Order;
using Business.Models.Production;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Business.EntityFrameworkCore
{
    [ConnectionStringName("Business")]
    public class BusinessDbContext : AbpDbContext<BusinessDbContext>
    {
        public DbSet<Book> Book { get; set; }

        //Code generation...
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        {

        }

        public DbSet<TextileGroup> TextileGroups { get; set; }
        public DbSet<SpinningMill> SpinningMills { get; set; }
        public DbSet<MachineDocument> MachineDocuments { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TextileProcess> TextileProcesses { get; set; }
        public DbSet<ClassTable> ClassTables { get; set; }
        public DbSet<LtMachineRttemp>  LtMachineRttemps { get; set; }
        public DbSet<LtMachineShiftReport> LtMachineShiftReports { get; set; }
        public DbSet<LtGroupShiftReport> LtGroupShiftReports { get; set; }
        public DbSet<LtPositionProductionReport> LtPositionProductionReports { get; set; }
        public DbSet<XsMachineShiftReport> XsMachineShiftReports { get; set; }
        public DbSet<CsMachineShiftReport> CsMachineShiftReports { get; set; }
        public DbSet<BtMachineShiftReport> BtMachineShiftReports { get; set; }
        public DbSet<JsMachineShiftReport> JsMachineShiftReports { get; set; }
        public DbSet<TbjMachineShiftReport> TbjMachineShiftReports { get; set; }
        public DbSet<SmMachineShiftReport> SmMachineShiftReports { get; set; }
        public DbSet<HmMachineShiftReport> HmMachineShiftReports { get; set; }
        public DbSet<LtPositionRttemp> LtPositionRttemps { get; set; }
        public DbSet<ArticleRecord> ArticleRecords { get; set; }
        public DbSet<FactoryProgramRecord> FactoryProgramRecords { get; set; }
        public DbSet<OrderCraftFlowAssociation> OrderCraftFlowAssociations { get; set; }
        public DbSet<CraftNodeList> CraftNodeLists { get; set; }
        public DbSet<CraftFlowRecordDetail> CraftFlowRecordDetails { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<CraftTypeList>  CraftTypeLists { get; set; }
        public DbSet<RecipeRecord> RecipeRecords { get; set; }
        public DbSet<RecipeRecordDetail> RecipeRecordDetails { get; set; }
        public DbSet<CraftNodeTextileProcessAssociation> CraftNodeTextileProcessAssociations { get; set; }
        public DbSet<OrderProgramRecord> OrderProgramRecords { get; set; }
        public DbSet<ProcessDispatchQueue> ProcessDispatchQueues { get; set; }
        public DbSet<MachineCertificate> MachineCertificates { get; set; }
        public DbSet<MachineCertificateRecord> MachineCertificateRecords{ get; set; }
        public DbSet<ProgramCraftItem> ProgramCraftItems { get; set; }
        public DbSet<ProgramCraftItemRecord>  ProgramCraftItemRecords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureBusiness();
        }
    }
}
