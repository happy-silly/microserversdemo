using Business.DTOs.MachineTypes;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.MachineTypes
{
    public class MachineTypeAppService:
        CrudAppService<MachineType,MachineTypeDto,int, LimitedResultRequestDto, CreateUpdateMachineTypeDto>
    {
        private IRepository<MachineType, int> _machineTypes;
        public MachineTypeAppService(IRepository<MachineType,int> machineTypes)
            :base(machineTypes)
        {
            _machineTypes = machineTypes;
        }
    }
}
