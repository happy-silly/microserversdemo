using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.JsMachineShiftReport
{
    public class JsMachineShiftReportDto : IMachineShiftReportCreateUpdateDtoBase
    {
        public Guid MachineDocumentId { get ; set ; }
        public string MachineName { get ; set ; }
        public int Tsid { get ; set ; }
        public DateTime? ShiftDate { get ; set ; }
        public string ShiftName { get ; set ; }
        public string TeamSet { get ; set ; }
        public int? ShiftNum { get ; set ; }
        public DateTime? Begin { get ; set ; }
        public DateTime? End { get ; set ; }
        public double? YarnLength { get ; set ; }
        public double? TheoreticalYarnWeight { get ; set ; }
        public double? ActualYarnWeight { get ; set ; }
        public double? Coe { get ; set ; }
        public Guid? ProductionDispatchId { get ; set ; }
        public long? ClassStartLength { get ; set ; }
        public long? ClassEndLength { get ; set ; }
        public long? TotalOutputCalStart { get ; set ; }
        public long? TotalOutputCalEnd { get ; set ; }
        public double? Power { get ; set ; }
        public double? PowerPerWeight { get ; set ; }
        public double? EfcRun { get ; set ; }
        [Display(Name = "出条速度(米/分)")]
        public double SpeedAvg1 { get ; set ; }
        [Display(Name = "梳理速度(钳次/分)")]
        public double SpeedAvg2 { get ; set ; }
    }
}
