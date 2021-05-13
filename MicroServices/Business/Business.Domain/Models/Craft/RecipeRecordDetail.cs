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
    /// 工艺大表详细数据
    /// </summary>
    public class RecipeRecordDetail:AuditedEntity<Guid>
    {
        [Display(Name ="工艺大表")]
        public Guid RecipeRecordId { get; set; }
        public RecipeRecord  RecipeRecord { get; set; }

        [Display(Name ="工艺参数")]
        public Guid CraftTypeListId { get; set; }
        public CraftTypeList CraftTypeList { get; set; }

        [Display(Name ="参数值")]
        public string Value { get; set; }
    }
}
