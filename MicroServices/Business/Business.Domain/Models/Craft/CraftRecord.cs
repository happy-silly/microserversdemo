using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models
{
    /// <summary>
    /// 工艺记录
    /// </summary>
    public class CraftRecord:AuditedEntity<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill SpinningMill { get; set; }
        [Display(Name ="工艺流程名称")]
        public string CraftName { get; set; }
        [Display(Name ="工艺流程原始json")]
        public string CraftProcessJson { get; set; }
    }
    /// <summary>
    /// 工艺流程详细数据
    /// </summary>
    public class CraftProcessAssociation : AuditedEntity<Guid>
    {
        [Display(Name ="工艺流程名称")]
        public Guid CraftRecordId { get; set; }
        public CraftRecord  CraftRecord { get; set; }
        [Display(Name ="工艺工序")]
        public Guid ProcessRecordId { get; set; }
        public ProcessRecord ProcessRecord { get; set; }
        [Display(Name ="左编号")]
        public int Left { get; set; }
        [Display(Name ="右编号")]
        public int Right { get; set; }
    }
}
