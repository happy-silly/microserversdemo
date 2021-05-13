using Business.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.Production
{
    /// <summary>
    /// 络筒单锭实时数据
    /// </summary>
    public class LtPositionRttemp:AuditedEntity<Guid>
    {
        public LtPositionRttemp()
        {

        }
        public LtPositionRttemp(Guid id) : base(id)
        {

        }
        [Display(Name = "机台ID")]
        public Guid MachineDocumentId { get; set; }   
        public MachineDocument MachineDocument { get; set; }
        [Display(Name = "机台号")]
        public string MachineName { get; set; }
        [Display(Name = "ShiftTimestampId")]
        public int? Tsid { get; set; }
        [Display(Name = "班次")]
        public string ShiftName { get; set; }
        [Display(Name = "班次序号")]
        public int? ShiftNum { get; set; }
        [Display(Name = "班组")]
        public string TeamSet { get; set; }
        [Display(Name = "当前班产")]
        public double? CurrentShiftLength { get; set; }
        [Display(Name = "当前长度")]
        public double? CurrentLength { get; set; }
        [Display(Name = "定长")]
        public int? FixLength { get; set; }
        [Display(Name = "剩余长度")]
        public double? RemainLength { get; set; }
        [Display(Name = "总产")]
        public double? TotalLength { get; set; }
        [Display(Name = "开始时间")]
        public DateTime? Start { get; set; }
        [Display(Name = "结束时间")]
        public DateTime? End { get; set; }
        [Display(Name = "设备状态")]
        public int? DeviceState { get; set; }
        [Display(Name = "运行状态")]
        public int? StateCode { get; set; }
        [Display(Name = "总产(E系统计算)")]
        public double? TotalLengthCal { get; set; }
        [Display(Name = "调度记录")]
        public Guid? ProductionDispatchId { get; set; }
        [Display(Name = "上机产量")]
        public double? OutputLengthStart { get; set; }
        [Display(Name = "开车时间")]
        public int? RunTimes { get; set; }
        [Display(Name = "运转效率(%)")]
        public double? EfcRun { get; set; }
        [Display(Name = "通信异常次数")]
        public int? CommunicateErrorCnt { get; set; }


        [Display(Name = "锭号")]
        public int? Num { get; set; }

        [Display(Name = "切疵次数")]
        public int? YarnFaultCuts { get; set; }
        [Display(Name = "切疵次数(10km)")]
        public int? YarnFaultCutsPer10Km { get; set; }
        [Display(Name = "筒纱切纱次数")]
        public int? ConeCuts { get; set; }
        [Display(Name = "管纱切纱次数")]
        public int? BobbinCuts { get; set; }
        [Display(Name = "单锭产量(Kg)")]
        public double? YarnWeight { get; set; }
        [Display(Name = "单锭小车络筒成功数")]
        public int? SpoolSucceedCnt { get; set; }
        [Display(Name = "当前筒纱重量")]
        public double? SigleWeight { get; set; }
        [Display(Name = "当前筒纱长度")]
        public int? SigleLength { get; set; }
        [Display(Name = "打结平均时间")]
        public string TiedTimeAvg { get; set; }
        [Display(Name = "打结总数")]
        public int? TiedCnt { get; set; }
        [Display(Name = "打结总时间")]
        public string TiedTime { get; set; }
        [Display(Name = "捻接循环次数")]
        public int? SpliceCnt { get; set; }
        [Display(Name = "接头数")]
        public int? JointCnt { get; set; }
        [Display(Name = "接头数(10km)")]
        public int? JointCntPer10Km { get; set; }
        [Display(Name = "筒纱接头数")]
        public int? ConeJointCnt { get; set; }
        [Display(Name = "更换管纱数")]
        public int? BobbinChanges { get; set; }
        [Display(Name = "生产筒纱数")]
        public int? ConeCnt { get; set; }
        [Display(Name = "络纱时间")]
        public string WorkTime { get; set; }
        [Display(Name = "落纱平均时间")]
        public string DoffAvgTime { get; set; }
        [Display(Name = "落纱总数")]
        public int? DoffCnt { get; set; }
        [Display(Name = "落纱总时间")]
        public string DoffTime { get; set; }
        [Display(Name = "红灯平均时间")]
        public string AlarmTimeAvg { get; set; }
        [Display(Name = "红灯总数")]
        public int? AlarmCnt { get; set; }
        [Display(Name = "红灯总时间")]
        public string AlarmTime { get; set; }
        [Display(Name = "故障平均时间")]
        public string FaultTimeAvg { get; set; }
        [Display(Name = "故障总数")]
        public int? FaultCnt { get; set; }
        [Display(Name = "故障总时间")]
        public string FaultTime { get; set; }
        [Display(Name = "单锭机械效率")]
        public double? MechanicalEfc { get; set; }
        [Display(Name = "单锭生产效率")]
        public double? ProductionEfc { get; set; }
        [Display(Name = "工艺报警平均时间")]
        public string TechnicalAlarmTimeAvg { get; set; }
        [Display(Name = "工艺报警总数")]
        public int? TechnicalAlarmCnt { get; set; }
        [Display(Name = "工艺报警总时间")]
        public string TechnicalAlarmTime { get; set; }
    }
}
