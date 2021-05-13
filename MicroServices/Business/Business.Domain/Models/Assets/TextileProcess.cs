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
    /// 纺纱大机型，和工序有些区别
    /// </summary>
    public class TextileProcess :AuditedEntity<Guid>
    {
        [Display(Name = "工序名")]
        public string ProcessName { get; set; }
        [Display(Name = "序号")]
        public int Order { get; set; }
        [Display(Name = "工序编号")]
        public string ProcessCode { get; set; }

        //[Display(Name = "所属车间")]
        //public Guid? SpinningMillId { get; set; }
        //[Display(Name = "所属车间")]
        //public SpinningMill SpinningMill { get; set; }

        public ICollection<MachineType> MachineTypes { get; set; }
       
        protected TextileProcess()
        {

        }
        public TextileProcess(Guid id)
            : base(id)
        {

        }
    }
}
