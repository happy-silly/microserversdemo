using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models
{
    /// <summary>
    /// 设备主机厂
    /// </summary>
    public class Manufacturer : AuditedEntity<int>
    {
        [Display(Name = "公司")]
        public string CompanyName { get; set; }
        [Display(Name = "电话")]
        public string PhoneNumber { get; set; }
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

        //[Display(Name = "企业照片")]
        //public Guid? ImageAttachmentId { get; set; }
        //[Display(Name = "企业照片")]
        //public FileAttachment ImageAttachment { get; set; }

        //[Display(Name = "微信二维码")]
        //public Guid? QRCodeAttachmentId { get; set; }
        //[Display(Name = "微信二维码")]
        //public FileAttachment QRCodeAttachment { get; set; }

        [Display(Name = "坐标")]
        public string Coordinates { get; set; }

        public ICollection<MachineType> MachineTypes { get; set; }

        protected Manufacturer()
        {

        }
        public Manufacturer(int id)
            :base(id)
        {

        }
    }
}
