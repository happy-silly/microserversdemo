using Business.DTOs.Order.OrderProgramRecord;
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
    /// 调度单记录
    /// </summary>
    public class OrderProgramRecordAppService:
        CrudAppService<OrderProgramRecord,OrderProgramRecordDto,Guid,LimitedResultRequestDto,CreateUpdateOrderProgramRecordDto>
    {
        public OrderProgramRecordAppService(IRepository<OrderProgramRecord,Guid> orderProgramRecords)
            : base(orderProgramRecords)
        {

        }
    }
}
