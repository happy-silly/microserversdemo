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
    /// 工艺节点配置
    /// </summary>
    public class CraftNodeList : AuditedEntity<Guid>
    {
        [Display(Name = "车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill SpinningMill { get; set; }

        [Display(Name = "工艺节点名称")]
        public string Name { get; set; }

        [Display(Name = "机型")]
        //public Guid? TextileProcessId { get; set; }
        //public TextileProcess TextileProcess { get; set; }
        public ICollection<CraftNodeTextileProcessAssociation> CraftNodeTextileProcessAssociations { get; set; }

        //TODO 确定是升序还是降序
        [Display(Name = "排序")]
        public int SortNum { get; set; }
        // TODO 清花的问题
    }
}
