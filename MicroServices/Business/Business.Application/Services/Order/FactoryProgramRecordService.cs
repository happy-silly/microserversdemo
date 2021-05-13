using Business.DTOs.FactoryProgramRecord;
using Business.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.Order
{
    /// <summary>
    /// 订单记录
    /// </summary>
    public class FactoryProgramRecordService
        :CrudAppService<FactoryProgramRecord, FactoryProgramRecordDto,Guid,LimitedResultRequestDto,CreateUpdateFactoryProgramRecordDto>
    {
        public FactoryProgramRecordService(IRepository<FactoryProgramRecord,Guid> factoryProgramRecords)
            : base(factoryProgramRecords)
        {

        }
    }
}
