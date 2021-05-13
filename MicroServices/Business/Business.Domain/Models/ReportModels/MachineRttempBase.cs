using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.ReportModels
{
    /// <summary>
    /// 实时数据记录
    /// </summary>
    public class MachineRttempBase:AuditedEntity<Guid>
    {
        public MachineRttempBase()
        {

        }
        public MachineRttempBase(Guid id) : base(id)
        {

        }
        //[Display(Name = "机台ID")]
        //public Guid MachineDocumentId { get; set; }
        [Display(Name = "机台ID")]
        [ForeignKey("Id")]
        public MachineDocument MachineDocument { get; set; }
        [Display(Name = "机台号")]
        public string MachineName { get; set; }
        [Display(Name = "ShiftTimestampId")]
        public int? Tsid { get; set; }
        [Display(Name ="班次")]
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

        //public override object[] GetKeys()
        //{
        //    return new object[] { MachineDocumentId };
        //}
    }
}
