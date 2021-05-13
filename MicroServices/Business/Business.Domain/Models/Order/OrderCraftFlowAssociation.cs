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
    /// 订单和工艺路线对应关系
    /// </summary>
    public class OrderCraftFlowAssociation:AuditedEntity<Guid>
    {
        [Display(Name ="订单")]
        public Guid FactoryProgramRecordId { get; set; }
        public FactoryProgramRecord FactoryProgramRecord { get; set; }
        [Display(Name ="工艺路线")]
        public Guid CraftFlowRecordId { get; set; }
        public CraftFlowRecord CraftFlowRecord { get; set; }
    }
}
