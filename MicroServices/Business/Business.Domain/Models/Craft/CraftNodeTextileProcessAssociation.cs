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
    /// 工艺节点和大机型的关系
    /// </summary>
    public class CraftNodeTextileProcessAssociation : AuditedEntity<Guid>
    {
        [Display(Name ="工艺节点")]
        public Guid CraftNodeListId { get; set; }
        public CraftNodeList CraftNodeList { get; set; }

        [Display(Name ="大机型")]
        public Guid TextileProcessId { get; set; }
        public TextileProcess TextileProcess { get; set; }
    }
}
