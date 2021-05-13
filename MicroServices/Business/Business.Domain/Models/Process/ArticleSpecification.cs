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
    /// 品种（分工序）详细信息
    /// </summary>
    public class ArticleSpecification:AuditedEntity<Guid>
    {
        [Display(Name ="品种")]
        public Guid? ArticleRecordId { get; set; }
        public ArticleRecord ArticleRecord { get; set; }
        [Display(Name ="工序")]
        public Guid ProcessRecordId { get; set; }
        public ProcessRecord ProcessRecord { get; set; }
        [Display(Name ="品种别名")]
        public string ArticleNameAlias { get; set; }
        [Display(Name ="定量，单位统一为g/km")]
        public decimal WeightPerKm { get; set; }
        [Display(Name ="回潮率")]
        public decimal? MoistureRegain { get; set; }
        [Display(Name ="制成率")]
        public decimal? YieldRate { get; set; }
        //[Display(Name ="配比")]
        //public decimal MyProperty { get; set; }
    }
}
