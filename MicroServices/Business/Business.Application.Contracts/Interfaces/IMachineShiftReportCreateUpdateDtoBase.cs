using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs
{
    public interface IMachineShiftReportCreateUpdateDtoBase
    {
        public Guid MachineDocumentId { get; set; }
        public string MachineName { get; set; }
        public int Tsid { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string ShiftName { get; set; }
        public string TeamSet { get; set; }
        public int? ShiftNum { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }
        public double? YarnLength { get; set; }
        public double? TheoreticalYarnWeight { get; set; }
        public double? ActualYarnWeight { get; set; }
        public double? Coe { get; set; }
        public Guid? ProductionDispatchId { get; set; }
        public long? ClassStartLength { get; set; }
        public long? ClassEndLength { get; set; }
        public long? TotalOutputCalStart { get; set; }
        public long? TotalOutputCalEnd { get; set; }
        public double? Power { get; set; }
        public double? PowerPerWeight { get; set; }
        public double? EfcRun { get; set; }
        public double SpeedAvg1 { get; set; }
        public double SpeedAvg2 { get; set; }
    }
}
