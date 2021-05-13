using Business.Enum;
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
    /// 工艺参数字典
    /// </summary>
    public class CraftTypeList:AuditedEntity<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }
        public SpinningMill  SpinningMill { get; set; }

        [Display(Name ="工艺节点")]
        public Guid? CraftNodeListId { get; set; }
        public CraftNodeList  CraftNodeList { get; set; }

        [Display(Name ="机型")]
        public Guid? MachineTypeId { get; set; }
        public MachineType  MachineType { get; set; }

        [Display(Name ="参数描述")]
        public string TypeDescription { get; set; }

        [Display(Name ="排序")]
        public int? SortNum { get; set; }

        [Display(Name ="适用范围")]
        public CraftTypeUsableRange UsageRange { get; set; }

        [Display(Name ="上限")]
        public double? LimitUp { get; set; }

        [Display(Name ="下限")]
        public double? LimitLow { get; set; }

        public ICollection<RecipeRecordDetail> RecipeRecordDetails { get; set; }
        //TODO 机上工艺

    }
}
