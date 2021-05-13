using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.ClassTables
{
    public class CreateUpdateClassTableDto
    {
        [Display(Name = "所属工序")]
        public Guid? TextileProcessId { get; set; }
        [Display(Name = "班次号")]
        [Required]
        public int TsId { get; set; }
        [Display(Name = "日期")]
        public DateTime? Date { get; set; }
        [Required]
        [Display(Name = "班次开始时间")]
        public DateTime ClassStartTime { get; set; }
        [Required]
        [Display(Name = "班次结束时间")]
        public DateTime ClassEndTime { get; set; }
        [Display(Name = "班组")]
        public string TeamSet { get; set; }
        [Display(Name = "班别")]
        public string OrdClass { get; set; }
        [Display(Name = "班次")]
        public int? ClassNum { get; set; }
    }
}
