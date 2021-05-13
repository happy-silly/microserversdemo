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
    /// 机型
    /// </summary>
    public class MachineType : AuditedEntity<int>
    {
        [Display(Name = "机型")]
        public string MachineTypeName { get; set; }
        // 缩写，在远程运维可能用不上
        [Display(Name = "缩写")]
        public string MachineTypeAbbr { get; set; }
        [Display(Name = "全称")]
        public string MachineDescription { get; set; }
        [Display(Name = "Description")]
        public string MachineDescriptionEn { get; set; }

        // 图片Url
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
        public int? ManufacturerId { get; set; }
        [Display(Name = "制造商")]
        public Manufacturer Manufacturer { get; set; }

        //[Display(Name = "外观图")]
        //public Guid? ImageAttachmentId { get; set; }
        //[Display(Name = "外观图")]
        //public FileAttachment ImageAttachment { get; set; }

        [Display(Name = "所属工序")]
        public Guid? TextileProcessId { get; set; }
        public TextileProcess TextileProcess { get; set; }

        public ICollection<MachineDocument> MachineDocuments { get; set; }

        protected MachineType()
        {

        }
        public MachineType(int id)
            : base(id)
        {

        }
    }
}
