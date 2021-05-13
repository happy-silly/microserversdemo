using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.TextileProcesses
{
    public class CreateUpdateTextileProcessDto
    {
        [Display(Name = "工序名")]
        [Required]
        [StringLength(20)]
        public string ProcessName { get; set; }
        [Display(Name = "序号")]
        [Required]
        public int Order { get; set; }
        [Display(Name = "工序编号")]
        [Required]
        [StringLength(20)]
        public string ProcessCode { get; set; }
        [Required]
        [Display(Name = "所属车间")]
        public Guid? SpinningMillId { get; set; }

    }
}
