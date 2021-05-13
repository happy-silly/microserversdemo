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
    /// 上机工艺记录
    /// </summary>
    public class ProgramCraftItemRecord:AuditedEntity<Guid>
    {
        [Display(Name = "调度记录")]
        public Guid ProcessDispatchQueueId { get; set; }
        public ProcessDispatchQueue ProcessDispatchQueue { get; set; }

        [Display(Name ="工艺参数")]
        public Guid ProgramCraftItemId { get; set; }
        public ProgramCraftItem  ProgramCraftItem { get; set; }

        [Display(Name ="值")]
        public string Value { get; set; }
    }
}
