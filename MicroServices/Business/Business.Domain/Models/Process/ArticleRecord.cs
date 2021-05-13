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
    /// 成品品种记录
    /// </summary>
    public class ArticleRecord:AuditedEntity<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill SpinningMill { get; set; }
        [Display(Name ="品种名")]
        public string ArticleName { get; set; }
        [Display(Name ="品种颜色")]
        public char ArticleColor { get; set; }
        [Display(Name ="品种编码")]
        public string ArticleCode { get; set; }
        [Display(Name ="纱支")]
        public decimal? YarnCount { get; set; }
        [Display(Name ="配棉")]
        public string CottonAssorting { get; set; }
        [Display(Name = "最后一道工序")]
        public Guid? LastCraftNodeId { get; set; }
        public CraftNodeList LastCraftNode { get; set; }

    }
}
