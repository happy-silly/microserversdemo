using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models.Order
{
    /// <summary>
    /// 开车合格通知单记录
    /// </summary>
    public class MachineCertificateRecord:AuditedEntity<Guid>
    {
        [Display(Name ="合格单字段")]
        public Guid MachineCertificateId { get; set; }
        public MachineCertificate  MachineCertificate { get; set; }

        [Display(Name ="调度记录")]
        public Guid ProcessDispatchQueueId { get; set; }
        public ProcessDispatchQueue  ProcessDispatchQueue{ get; set; }

        [Display(Name ="值")]
        public string Value { get; set; }
    }
}
