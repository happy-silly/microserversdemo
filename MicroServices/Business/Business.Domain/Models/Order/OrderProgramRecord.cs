using Business.Models.Craft;
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
    public class OrderProgramRecord:AuditedEntity<Guid>
    {
        [Display(Name ="订单")]
        public Guid FactoryProgramRecordId { get; set; }
        public FactoryProgramRecord FactoryProgramRecord { get; set; }

        [Display(Name ="调度单制定日期")]
        public DateTime MakeTime { get; set; }
        //TODO 标识物

        [Display(Name = "工艺节点")]
        public Guid? CraftNodeListId { get; set; }
        public CraftNodeList CraftNodeList { get; set; }

        [Display(Name = "调度单总重(Kg)")]
        public double MergedOrderWeight { get; set; }
        [Display(Name = "制成率")]
        public double? YieldRate { get; set; }
        [Display(Name ="期望产量")]
        public double? ExpectedOutput { get; set; }

        [Display(Name = "物料")]
        public Guid? MaterialId { get; set; }
        public Material Material { get; set; }

        //TODO 调度单来源，枚举
        [Display(Name ="调度单来源")]
        public string Origin { get; set; }

        [Display(Name ="批次")]
        public string Lot { get; set; }

        //TODO 调度单速度单位，枚举
        [Display(Name = "速度")]
        public double? Speed { get; set; }
        [Display(Name = "速度单位")]
        public int? SpeedUnit { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
