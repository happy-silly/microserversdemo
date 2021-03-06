using Business.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.FactoryProgramRecord
{
    public class FactoryProgramRecordDto:AuditedEntityDto<Guid>
    {
        [Display(Name = "所属车间")]
        public Guid SpinningMillId { get; set; }
        //public SpinningMill SpinningMill { get; set; }
        [Display(Name = "订单号")]
        public string Code { get; set; }
        [Display(Name = "预计开始时间")]
        public DateTime? ScheduledStartDate { get; set; }
        [Display(Name = "制定日期")]
        public DateTime? MakeDate { get; set; }
        [Display(Name = "计划交期")]
        public DateTime? DueDate { get; set; }
        [Display(Name = "品种唯一标识")]
        public Guid? ArtilceRecordId { get; set; }
        //public ArticleRecord ArticleRecord { get; set; }
        [Display(Name = "订单总重量(吨)")]
        public double DueWeight { get; set; }

        [Display(Name = "状态")]
        public OrderFlagEnum OrderFlag { get; set; }

        // TODO 订单附加信息怎么保存
        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
