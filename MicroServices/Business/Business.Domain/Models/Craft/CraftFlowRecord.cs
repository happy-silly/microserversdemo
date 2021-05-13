using Business.Enum;
using Business.Models.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.Craft
{
    /// <summary>
    /// 工艺流程记录
    /// </summary>
    public class CraftFlowRecord : AuditedEntity<Guid>
    {
        [Display(Name = "品种")]
        public Guid ArticleRecordId { get; set; }
        public ArticleRecord ArticleRecord { get; set; }

        //同一个成品品种可以同时（并列）拥有多个最新的工艺路线
        //例如，同一个细纱品种可以由不同的粗纱单独供应。这种情况可以理解为这个细纱品种有两个工艺流程（工艺大表）
        [Display(Name = "结束标记")]
        public CraftFlowFlagEnum CraftFlowFlag { get; set; }

        //TODO 可以设计一种根据工艺路线自动（或者手动）生成工艺路线名称的算法
        //当同一个品种同时存在多个工艺路线时，可以根据名称让用户选择
        [Display(Name = "工艺路线名称")]
        public string Name { get; set; }

        public ICollection<OrderCraftFlowAssociation> OrderCraftFlowAssociations { get; set; }
    }
}
