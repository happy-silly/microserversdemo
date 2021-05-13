using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Business.DTOs.MachineTypes
{
    public class MachineTypeDto:AuditedEntityDto<int>
    {
        public int Id { get; set; }

        public string MachineTypeName { get; set; }

        public string MachineTypeAbbr { get; set; }

        public string MachineDescription { get; set; }

        public string MachineDescriptionEn { get; set; }

        public string MachinePicPrefix { get; set; }

        public string JingweiLink { get; set; }

        public string ProcessCode { get; set; }

        public float? RatedSpeed { get; set; }

        public string FontAwesomeIcon { get; set; }

        public int? ManufacturerId { get; set; }
    }
}
