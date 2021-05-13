using Business.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.Order
{
    /// <summary>
    /// 调度记录
    /// </summary>
    public class ProcessDispatchQueue:AuditedEntity<Guid>
    {
        [Display(Name = "机台")]
        public Guid MachineDocumentId { get; set; }
        public MachineDocument MachineDocument { get; set; }

        [Display(Name ="调度单")]
        public Guid? OrderProgramRecordId { get; set; }
        public OrderProgramRecord OrderProgramRecord { get; set; }

        [Display(Name ="计划开始日期")]
        public DateTime? ScheduledStartDate { get; set; }
        [Display(Name = "计划结束日期")]
        public DateTime? ScheduledEndDate { get; set; }

        [Display(Name ="期望产量(Kg)")]
        public double? ExpectedOutput { get; set; }

        [Display(Name ="是否完结标记")]
        public OrderFlagEnum AccomplishFlag { get; set; }
        [Display(Name = "完结时间")]
        public DateTime? AccomplishTime { get; set; }

        [Display(Name ="是否确认开车标记")]
        public MachineConfirmedEnum ConfirmedFlag { get; set; }
        [Display(Name = "确认开车时间")]
        public DateTime? ConfirmedTime { get; set; }

        [Display(Name ="打印标记")]
        public int PrintedFlag { get; set; }

        [Display(Name ="开车合格通知单")]
        public ICollection<MachineCertificateRecord>  MachineCertificateRecords { get; set; }
         
        [Display(Name ="上机工艺单")]
        public ICollection<ProgramCraftItemRecord>  ProgramCraftItemRecords { get; set; }

        //[Display(Name ="工艺路线")]

        [Display(Name ="当前翻改物料")]
        public Guid MaterialId { get; set; }
        public Material Material { get; set; }
        [Display(Name = "上次翻改物料")]
        public Guid? MaterialPreId { get; set; }
        public Material MaterialPre { get; set; }
        // TODO 原料

        [Display(Name = "批次")]
        public string Lot { get; set; }

        [Display(Name = "定量")]
        public double? WeightPerLength { get; set; }
        [Display(Name = "单位")]
        public WeightPerLengthUnit? WeightPerLengthUnit { get; set; }

        

        [Display(Name ="回潮率")]
        public double? MoistureRegain { get; set; }

        [Display(Name ="实验员")]
        public string LabTechnicianName { get; set; }

        [Display(Name = "估计开车时间")]
        public DateTime? ApproximateStartTime { get; set; }

    }
}
