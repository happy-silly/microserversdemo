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
    /// 工艺路线中的工序
    /// </summary>
    public class ProcessRecord:AuditedEntity<Guid>
    {
        [Display(Name ="所属车间")]
        public Guid MillId { get; set; }
        public SpinningMill SpinningMill { get; set; }
        [Display(Name ="工序名")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="排序")]
        public int? Sorter { get; set; }
        [Display(Name ="标识物")]
        //外键，TODO 未来要完善外键关系
        public Guid? MarkerId { get; set; }
        [Display(Name="机型列表")]
        public string MachineTypeList { get; set; }
        public ProcessRecord()
        {

        }
        public ProcessRecord(Guid id) : base(id)
        {

        }
    }
}
