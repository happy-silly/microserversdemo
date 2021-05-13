using Business.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    /// <summary>
    /// 络筒分组班报
    /// </summary>
    public class LtGroupShiftReport:ShiftReportBase,IProductionReport
    {
        public LtGroupShiftReport()
        {

        }
        public LtGroupShiftReport(Guid id) : base(id)
        {

        }
        [Display(Name = "组号")]
        public int Num { get; set; }

        public double? YarnLength { get ; set ; }

        public double? TheoreticalYarnWeight { get ; set ; }
        public double? ActualYarnWeight { get ; set ; }

        public double? Coe { get ; set ; }
        public double? EfcRun { get ; set ; }
        public Guid? ProductionDispatchId { get ; set ; }

        [Display(Name ="上位机开始时间")]
        public DateTime? BeginTimeFromUpComputer { get; set; }
        [Display(Name ="上位机更新时间")]
        public DateTime? UpdateTimeFromUpComputer { get; set; }
    }
}
