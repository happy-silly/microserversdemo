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
    /// 络筒整车班报
    /// </summary>
    public class LtMachineShiftReport:ShiftReportBase,IProductionCalculate,IProductionReport,IPowerReport
    {
        public LtMachineShiftReport()
        {

        }
        public LtMachineShiftReport(Guid id) : base(id)
        {

        }
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

        #region 基础
        public double? TotalFallingCylinderSuccessRatio { get; set; }
        public long? ClassStartLength { get; set; }
        public long? ClassEndLength { get; set; }
        public long? TotalOutputCalStart { get; set; }
        public long? TotalOutputCalEnd { get; set; }
        public double? YarnLength { get; set; }
        public double? TheoreticalYarnWeight { get; set; }
        public double? ActualYarnWeight { get; set; }
        public double? Coe { get; set; }
        public double? EfcRun { get; set; }
        public double? Power { get; set; }
        public double? PowerPerWeight { get; set; }
        public Guid? ProductionDispatchId { get; set; }

        #endregion

    }
}
