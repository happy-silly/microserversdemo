using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.Craft
{
    /// <summary>
    /// 工艺流程详细数据
    /// </summary>
    public class CraftFlowRecordDetail : AuditedEntity<Guid>
    {

        //[ForeignKey("Id")]
        [Display(Name = "工艺路线ID")]
        public Guid CraftFlowRecordId { get; set; }
        [Display(Name = "工艺路线ID")]
        public CraftFlowRecord CraftFlowRecord { get; set; }

        //[Display(Name = "品种")]
        //public Guid? ArticleRecordId { get; set; }
        //public ArticleRecord ArticleRecord { get; set; }
        [Display(Name = "前道物料")]
        public Guid? PreMaterialId { get; set; }
        public Material PreMaterial { get; set; }

        [Display(Name = "物料")]
        public Guid MaterialId { get; set; }
        public Material Material { get; set; }

        [Display(Name = "配比")]
        public double? Percenty { get; set; }

    }


}
