using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.MachineTypes
{
    public class CreateUpdateMachineTypeDto
    {
        [Required]
        [StringLength(128)]
        [Display(Name = "机型")]
        public string MachineTypeName { get; set; }
        [StringLength(128)]
        [Display(Name = "缩写")]
        public string MachineTypeAbbr { get; set; }
        [StringLength(228)]
        [Display(Name = "全称")]
        public string MachineDescription { get; set; }
        [StringLength(128)]
        [Display(Name = "Description")]
        public string MachineDescriptionEn { get; set; }
        [Display(Name = "文件名")]
        public string MachinePicPrefix { get; set; }
        [Display(Name = "链接")]
        public string JingweiLink { get; set; }
        [Display(Name = "工序代码")]
        public string ProcessCode { get; set; }
        [Display(Name = "额定速度")]
        public float? RatedSpeed { get; set; }
        [Display(Name = "FA图标icon")]
        public string FontAwesomeIcon { get; set; }
        [Display(Name = "制造商ID")]
        [Required]
        public int? ManufacturerId { get; set; }
    }
}
