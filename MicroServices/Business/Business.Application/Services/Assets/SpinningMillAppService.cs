using Business.DTOs.SpinningMills;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.SpinningMills
{
    public class SpinningMillAppService:
        CrudAppService<SpinningMill,SpinningMillDto,Guid, LimitedResultRequestDto, CreateUpdateSpinningMillDto>
    {
        private IRepository<SpinningMill, Guid> _spinningMills;
        public SpinningMillAppService(IRepository<SpinningMill,Guid> spinningMills)
            :base(spinningMills)
        {
            _spinningMills = spinningMills;
        }
    }
}
