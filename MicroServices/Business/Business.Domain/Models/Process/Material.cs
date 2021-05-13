using Business.Enum;
using Business.Models.Craft;
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
    /// 物料详细信息
    /// </summary>
    public class Material:AuditedEntity<Guid>
    {
        [Display(Name ="工艺节点")]
        public Guid CraftNodeListId { get; set; }
        public CraftNodeList CraftNodeList { get; set; }

        [Display(Name ="物料名称")]
        public string Name { get; set; }

        // TODO 配棉
        [Display(Name = "配棉")]
        public string CottonAssort { get; set; }

        [Display(Name ="定量")]
        public double WeightPerLength { get; set; }
        [Display(Name ="单位")]
        public WeightPerLengthUnit WeightPerLengthUnit { get; set; }

        [Display(Name ="回潮率")]
        public double? MoistureRegain { get; set; }
        [Display(Name ="制成率")]
        public double? YieldRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<CraftFlowRecordDetail>  CraftFlowRecordDetails { get; set; }
    }
}
