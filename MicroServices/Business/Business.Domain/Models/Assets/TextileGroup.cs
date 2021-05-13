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
    /// 纺纱集团
    /// </summary>
    public class TextileGroup: AuditedEntity<Guid>
    {
        [Display(Name = "名称")]
        public string GroupName { get; set; }
        [Display(Name = "公司主页")]
        public string WebSite { get; set; }

        [Display(Name = "地址")]
        public string Address { get; set; }

        //[Display(Name = "集团Logo")]
        //public FileAttachment CompanyLogo { get; set; }

        //[Display(Name = "集团Logo")]
        //public Guid? CompanyLogoId { get; set; }

        [Display(Name = "集团口号")]
        public string Slogan { get; set; }


        public ICollection<SpinningMill> SpinningMills { get; set; }

        public TextileGroup()
        {

        }
        public TextileGroup(Guid id) : base(id)
        {

        }
    }
}
