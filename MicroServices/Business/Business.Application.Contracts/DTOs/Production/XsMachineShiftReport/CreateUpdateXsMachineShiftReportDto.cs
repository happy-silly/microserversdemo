using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.XsMachineShiftReport
{
    public class CreateUpdateXsMachineShiftReportDto:IMachineShiftReportCreateUpdateDtoBase
    {
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

        [Display(Name = "班产(米)")]
        public double? YarnLength { get; set; }

        [Display(Name = "理论重量(Kg)")]
        public double? TheoreticalYarnWeight { get; set; }

        [Display(Name = "实际重量(Kg)")]
        public double? ActualYarnWeight { get; set; }

        [Display(Name = "修正系数")]
        public double? Coe { get; set; }

        [Display(Name = "调度记录")]
        public Guid? ProductionDispatchId { get; set; }

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
        //[Display(Name = "前罗拉速度")]
        //public int? FrontRollerSpeed { get; set; }
        [Display(Name = "平均捻度")]
        public double? AverageActualTwist { get; set; }
        [Display(Name = "罗拉直径")]
        public int? RollerDiameter { get; set; }
        [Display(Name ="锭速")]
        public double SpeedAvg1 { get ; set ; }
        [Display(Name = "前罗拉速度")]
        public double SpeedAvg2 { get ; set ; }
    }
}
