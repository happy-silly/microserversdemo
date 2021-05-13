using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.CsMachineShiftReport
{
    public class CsMachineShiftReportDto:AuditedEntityDto<Guid>, IMachineShiftReportCreateUpdateDtoBase
    {
        [Display(Name = "机台")]
        public Guid MachineDocumentId { get; set; }

        [Display(Name = "机台号")]
        public string MachineName { get; set; }

        [Display(Name = "ShiftTimestampId")]
        public int Tsid { get; set; }

        [Display(Name = "日期")]
        public DateTime? ShiftDate { get; set; }

        [Display(Name = "班次")]
        public string ShiftName { get; set; }

        [Display(Name = "班组")]
        public string TeamSet { get; set; }

        [Display(Name = "序号")]
        public int? ShiftNum { get; set; }

        [Display(Name = "开始时间")]
        public DateTime? Begin { get; set; }
        [Display(Name = "结束时间")]
        public DateTime? End { get; set; }

        [Display(Name = "上机产量")]
        public long? ClassStartLength { get; set; }
        [Display(Name = "下机产量")]
        public long? ClassEndLength { get; set; }
        [Display(Name = "E系统计算的上机产量")]
        public long? TotalOutputCalStart { get; set; }
        [Display(Name = "E系统计算的下机产量")]
        public long? TotalOutputCalEnd { get; set; }

        [Display(Name = "耗电")]
        public double? Power { get; set; }
        [Display(Name = "吨纱耗电")]
        public double? PowerPerWeight { get; set; }

        [Display(Name = "运转效率")]
        public double? EfcRun { get; set; }

        //[Display(Name = "平均锭速")]
        //public int? AverageSpindleSpeed { get; set; }
        [Display(Name = "最高锭速")]
        public int? MaxSpindleSpeed { get; set; }
        public double? YarnLength { get ; set ; }
        public double? TheoreticalYarnWeight { get ; set ; }
        public double? ActualYarnWeight { get ; set ; }
        public double? Coe { get ; set ; }
        public Guid? ProductionDispatchId { get ; set ; }
        [Display(Name = "锭速")]
        public double SpeedAvg1 { get ; set ; }
        public double SpeedAvg2 { get ; set ; }
    }
}
