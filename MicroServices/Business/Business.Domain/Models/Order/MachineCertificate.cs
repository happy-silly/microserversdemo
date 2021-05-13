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
    /// 开车合格通知单组成
    /// </summary>
    public class MachineCertificate: AuditedEntity<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill  SpinningMill { get; set; }

        [Display(Name ="名称")]
        public string Name { get; set; }
        [Display(Name ="单位")]
        public string Unit { get; set; }

        //TODO 未来需要完善合并订单和工艺工序的对应关系
        [Display(Name = "工艺节点")]
        public Guid? CraftNodeListId { get; set; }
        public CraftNodeList CraftNodeList { get; set; }
    }
}
