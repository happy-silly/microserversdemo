using Business.Models.Craft;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.Craft.CraftNodeLists
{
    public class CraftNodeListDTo:AuditedEntityDto<Guid>
    {
        [Display(Name ="车间")]
        public Guid SpinningMillId { get; set; }

        [Display(Name ="工艺节点名称")]
        public string Name { get; set; }

        [Display(Name = "机型")]
        public ICollection<CraftNodeTextileProcessAssociation> CraftNodeTextileProcessAssociations { get; set; }

        public int SortNum { get; set; }
    }
}
