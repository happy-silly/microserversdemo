using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs
{
    public class TextileGroupDto:AuditedEntityDto<Guid>
    {
        public string GroupName { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string Slogan { get; set; }
    }
}
