using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.TextileProcesses
{
    public class TextileProcessDto:AuditedEntityDto<Guid>
    {
        [Display(Name = "工序名")]
        public string ProcessName { get; set; }
        [Display(Name = "序号")]
        public int Order { get; set; }
        [Display(Name = "工序编号")]
        public string ProcessCode { get; set; }

        [Display(Name = "所属车间")]
        public Guid? SpinningMillId { get; set; }
    }
}
