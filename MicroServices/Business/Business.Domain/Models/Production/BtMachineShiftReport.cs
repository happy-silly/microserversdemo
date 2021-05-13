using Business.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class BtMachineShiftReport : ShiftReportBase, IProductionCalculate, IProductionReport, IPowerReport
    {
        public long? ClassStartLength { get; set; }
        public long? ClassEndLength { get; set; }
        public long? TotalOutputCalStart { get; set; }
        public long? TotalOutputCalEnd { get; set; }
        public double? YarnLength { get; set; }
        public double? TheoreticalYarnWeight { get; set; }
        public double? ActualYarnWeight { get; set; }
        public double? Coe { get; set; }
        public double? EfcRun { get; set; }
        public Guid? ProductionDispatchId { get; set; }
        public double? Power { get; set; }
        public double? PowerPerWeight { get; set; }
        [Display(Name ="平均出条速度")]
        public int? AverageDeliverySpeed { get; set; }
    }
}
