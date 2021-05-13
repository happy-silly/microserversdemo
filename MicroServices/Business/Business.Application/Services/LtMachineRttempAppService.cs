using Business.DTOs;
using Business.DTOs.LtMachineRttemp;
using Business.Models;
using Business.Permissions;
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
    public class LtMachineRttempAppService:
        CrudAppService<LtMachineRttemp,LtMachineRttempDto,Guid,LimitedResultRequestDto,CreateUpdateLtMachineRttempDto>
    {
        public LtMachineRttempAppService(IRepository<LtMachineRttemp,Guid> ltMachineRttemps)
            : base(ltMachineRttemps)
        {
            GetPolicyName = BusinessPermissions.Book.Default;
            GetListPolicyName = BusinessPermissions.Book.Default;
            CreatePolicyName = BusinessPermissions.Book.Create;
           // UpdatePolicyName = BusinessPermissions.Book.Edit;
            DeletePolicyName = BusinessPermissions.Book.Delete;
        }
    }
}
