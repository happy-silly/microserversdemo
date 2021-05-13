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
    /// 上机工艺单参数
    /// </summary>
    public class ProgramCraftItem : AuditedEntity<Guid>
    {
        [Display(Name ="机型")]
        public Guid? MachineTypeId { get; set; }
        public MachineType  MachineType { get; set; }

        [Display(Name = "工艺节点")]
        public Guid? CraftNodeListId { get; set; }
        public CraftNodeList CraftNodeList { get; set; }

        [Display(Name ="工艺参数名称")]
        public string Name { get; set; }
    }
}
