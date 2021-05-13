using Business.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class HmMachineShiftReport : ShiftReportBase, IPowerReport, IProductionReport//,IEfc
    {
        public double? Power { get ; set ; }

        [NotMapped]
        public double? PowerPerWeight { get; set ; }

        public double? EfcRun { get ; set ; }

        [Display(Name = "平均棉仓压力")]
        public double? AverageWarehousePressure { get; set; }

        [NotMapped]
        public double? YarnLength { get {
                return null;
            } set => throw new NotImplementedException(); }

        [NotMapped]
        public double? TheoreticalYarnWeight { get { return null; } 
            set => throw new NotImplementedException(); 
        }
        [NotMapped]
        public double? ActualYarnWeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotMapped]
        public double? Coe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public Guid? ProductionDispatchId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
