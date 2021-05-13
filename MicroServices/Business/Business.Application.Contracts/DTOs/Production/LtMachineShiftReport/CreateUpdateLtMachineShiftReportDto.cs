using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.LtMachineShiftReport
{
    public class CreateUpdateLtMachineShiftReportDto:IMachineShiftReportCreateUpdateDtoBase
    {
        public Guid MachineDocumentId { get; set; }
        [Display(Name = "机台号")]
        public string MachineName { get; set; }
        [Display(Name = "班次号")]
        public int TsId { get; set; }
        public int Tsid { get ; set ; }
        [Display(Name = "日期")]
        public DateTime Date { get; set; }
        [Display(Name = "班次")]
        public string OrdClass { get; set; }
        [Display(Name = "班组")]
        public string TeamSet { get; set; }
        [Display(Name = "班号")]
        public int? ClassNum { get; set; }
        [Display(Name = "班次开始时间")]
        public DateTime ClassStartTime { get; set; }
        [Display(Name = "班次结束时间")]
        public DateTime ClassEndTime { get; set; }
        [Display(Name = "进入单锭数(个)")]
        public int? SingleSpindleEnterNum { get; set; }
        [Display(Name = "空管回送数量(个)")]
        public int? YarndepotEmptyTubeEcho { get; set; }
        [Display(Name = "残纱数量(个)")]
        public int? YarndepotResidualNum { get; set; }
        [Display(Name = "第一生头通过数(个)")]
        public int? FirstRawHeadPassNum { get; set; }
        [Display(Name = "第一生头成功数(个)")]
        public int? FirstRawHeadSuccessNum { get; set; }
        [Display(Name = "第二生头通过数(个) ")]
        public int? SecondRawHeadPassNum { get; set; }
        [Display(Name = "第二生头成功数(个)")]
        public int? SecondRawHeadSuccessNum { get; set; }
        [Display(Name = "拔管处通过数(个)")]
        public int? TubeDrawingPassNum { get; set; }
        [Display(Name = "第一生头成功率(%)")]
        public double? FirstRawHeadRatio { get; set; }
        [Display(Name = "第二生头成功率(%)")]
        public double? SecondRawHeadRatio { get; set; }
        [Display(Name = "残纱率(%)")]
        public double? YarndepotResidualRatio { get; set; }
        [Display(Name = "空管率(%)")]
        public double? YarndepotEmptyTubeRatio { get; set; }
        [Display(Name = "小车落筒成功个数(个)")]
        public int? FallingCylinderSuccessNum { get; set; }
        [Display(Name = "小车落筒个数(个)")]
        public int? FullCylinderNum { get; set; }
        [Display(Name = "小车落筒成功百分率(%)")]
        public double? FallingCylinderSuccessRatio { get; set; }
        [Display(Name = "总满筒个数(个)")]
        public int? TotalFullCylinder_num { get; set; }
        [Display(Name = "总落筒成功百分率(%)")]
        public double? TotalFallingCylinderSuccessRatio { get; set; }
        public long? ClassStartLength { get; set; }
        public long? ClassEndLength { get; set; }
        public long? TotalOutputCalStart { get; set; }
        public long? TotalOutputCalEnd { get; set; }
        public double? CurrentLength { get; set; }
        public double? TheoreticalWeight { get; set; }
        public double? ActualWeight { get; set; }
        public double? OutputCoe { get; set; }
        public double? EfcRun { get; set; }
        public double? Power { get; set; }
        public double? PowerPerWeight { get; set; }
        public Guid? ArticleGuid { get; set; }
        public DateTime? ShiftDate { get ; set ; }
        public string ShiftName { get ; set ; }
        public int? ShiftNum { get ; set ; }
        public DateTime? Begin { get ; set ; }
        public DateTime? End { get ; set ; }
        public double? YarnLength { get ; set ; }
        public double? TheoreticalYarnWeight { get ; set ; }
        public double? ActualYarnWeight { get ; set ; }
        public double? Coe { get ; set ; }
        public Guid? ProductionDispatchId { get ; set ; }
        [Display(Name = "车速")]
        public double SpeedAvg1 { get ; set ; }
        public double SpeedAvg2 { get ; set ; }
    }
}
