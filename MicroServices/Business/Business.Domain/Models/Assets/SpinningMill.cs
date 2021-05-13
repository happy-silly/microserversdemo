using Business.Models.Craft;
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
    /// 纺纱车间
    /// </summary>
    public class SpinningMill: AuditedEntity<Guid>
    {
        [Display(Name = "名称")]
        public string MillName { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "坐标")]
        public string Coordinates { get; set; }

        [Display(Name = "所属集团ID")]
        public Guid? TextileGroupId { get; set; }
        [Display(Name = "所属集团")]
        public TextileGroup TextileGroup { get; set; }

        public ICollection<MachineDocument> MachineDocuments { get; set; }
        public ICollection<RecipeRecord> RecipeRecords { get; set; }
        //public ICollection<TextileProcess> TextileProcesses { get; set; }

        protected SpinningMill()
        {

        }
        public SpinningMill(Guid id)
            : base(id)
        {

        }
    }
}
