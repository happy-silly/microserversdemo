using Business.DTOs;
using Business.DTOs.LtMachineRttemp;
using Business.Models;
using Business.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services
{
    /// <summary>
    /// 络筒整车实时数据
    /// </summary>
    //[Authorize(BusinessPermissions.LtMachineShiftReport.Default)]
    public class LtMachineRttempAppService:
        CrudAppService<LtMachineRttemp,LtMachineRttempDto,Guid,LimitedResultRequestDto,CreateUpdateLtMachineRttempDto>
    {
        public LtMachineRttempAppService(IRepository<LtMachineRttemp,Guid> ltMachineRttemps)
            : base(ltMachineRttemps)
        {

        }
    }
}
