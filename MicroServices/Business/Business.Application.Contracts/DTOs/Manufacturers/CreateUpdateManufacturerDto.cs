using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Manufacturers
{
    public class CreateUpdateManufacturerDto
    {
        [Display(Name ="唯一编号")]
        public int id { get; set; }
        [Display(Name = "公司")]
        [Required]
        [StringLength(128)]
        public string CompanyName { get; set; }
        [Display(Name = "电话")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(128)]
        [Display(Name = "企业全名")]
        public string Description { get; set; }
        [Display(Name = "客服")]
        public string ServiceEngineer { get; set; }
        [Display(Name = "客服电话")]
        public string SEPhoneNumber { get; set; }
        [Display(Name = "主营业务")]
        public string MainProducts { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "坐标")]
        public string Coordinates { get; set; }
    }
}
