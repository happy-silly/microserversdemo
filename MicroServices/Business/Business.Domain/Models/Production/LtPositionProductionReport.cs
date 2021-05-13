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
    /// 络筒单锭班报
    /// </summary>
    public class LtPositionProductionReport : ShiftReportBase ,IProductionReport
    {
        public LtPositionProductionReport()
        {

        }
        public LtPositionProductionReport(Guid id) : base(id)
        {

        }
        [Display(Name ="锭号")]
        public int? Num { get; set; }

        public double? YarnLength { get; set; }
        public double? TheoreticalYarnWeight { get; set; }
        public double? ActualYarnWeight { get; set; }
        public double? Coe { get; set; }
        public double? EfcRun { get; set; }
        public Guid? ProductionDispatchId { get; set; }

        [Display(Name = "切疵次数")]
        public int? YarnFaultCuts { get; set; }
        [Display(Name ="切疵次数(10km)")]
        public int? YarnFaultCutsPer10Km { get; set; }
        [Display(Name = "筒纱切纱次数")]
        public int? ConeCuts { get; set; }
        [Display(Name = "管纱切纱次数")]
        public int? BobbinCuts { get; set; }
        [Display(Name ="单锭产量(Kg)")]
        public double? YarnWeight { get; set; }
        [Display(Name ="单锭小车络筒成功数")]
        public int? SpoolSucceedCnt { get; set; }
        [Display(Name ="当前筒纱重量")]
        public double? SigleWeight { get; set; }
        [Display(Name ="当前筒纱长度")]
        public int? SigleLength { get; set; }
        [Display(Name ="打结平均时间")]
        public string TiedTimeAvg { get; set; }
        [Display(Name ="打结总数")]
        public int? TiedCnt { get; set; }
        [Display(Name = "打结总时间")]
        public string TiedTime { get; set; }
        [Display(Name ="捻接循环次数")]
        public int? SpliceCnt { get; set; }
        [Display(Name ="接头数")]
        public int? JointCnt { get; set; }
        [Display(Name ="接头数(10km)")]
        public int? JointCntPer10Km { get; set; }
        [Display(Name = "筒纱接头数")]
        public int? ConeJointCnt { get; set; }
        [Display(Name ="更换管纱数")]
        public int? BobbinChanges { get; set; }
        [Display(Name ="生产筒纱数")]
        public int? ConeCnt { get; set; }
        [Display(Name ="络纱时间")]
        public string WorkTime { get; set; }
        [Display(Name ="落纱平均时间")]
        public string DoffAvgTime { get; set; }
        [Display(Name ="落纱总数")]
        public int? DoffCnt { get; set; }
        [Display(Name ="落纱总时间")]
        public string DoffTime { get; set; }
        [Display(Name ="红灯平均时间")]
        public string AlarmTimeAvg { get; set; }
        [Display(Name ="红灯总数")]
        public int? AlarmCnt { get; set; }
        [Display(Name ="红灯总时间")]
        public string AlarmTime { get; set; }
        [Display(Name ="故障平均时间")]
        public string FaultTimeAvg { get; set; }
        [Display(Name ="故障总数")]
        public int? FaultCnt { get; set; }
        [Display(Name ="故障总时间")]
        public string FaultTime { get; set; }
        [Display(Name ="单锭机械效率")]
        public double? MechanicalEfc { get; set; }
        [Display(Name ="单锭生产效率")]
        public double? ProductionEfc  { get; set; }
        [Display(Name ="工艺报警平均时间")]
        public string TechnicalAlarmTimeAvg { get; set; }
        [Display(Name ="工艺报警总数")]
        public int? TechnicalAlarmCnt { get; set; }
        [Display(Name ="工艺报警总时间")]
        public string TechnicalAlarmTime { get; set; }
    }
}
