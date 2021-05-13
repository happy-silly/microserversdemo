using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.SpinningMills
{
    public class SpinningMillDto:AuditedEntityDto<Guid>
    {
        public string MillName { get; set; }
        public string Address { get; set; }
        public string Coordinates { get; set; }
        public Guid? TextileGroupId { get; set; }
    }
}
