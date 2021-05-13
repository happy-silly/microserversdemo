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
    /// 工艺大表
    /// </summary>
    public class RecipeRecord:AuditedEntity<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill  SpinningMill { get; set; }

        [Display(Name ="品种")]
        public Guid ArticleRecordId { get; set; }
        public ArticleRecord  ArticleRecord { get; set; }

        [Display(Name ="工艺表编号")]
        public string TableName { get; set; }

        //TODO 人员信息
        [Display(Name ="编制人")]
        public string EmpCompile { get; set; }
        [Display(Name ="审核人")]
        public string EmpVerifier { get; set; }
        [Display(Name = "批准人")]
        public string EmpApprover { get; set; }

    }
}
