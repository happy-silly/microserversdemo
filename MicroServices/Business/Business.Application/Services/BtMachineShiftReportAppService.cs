using Business.DTOs.BtMachineShiftReport;
using Business.Models;
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
    /// 并条班报
    /// </summary>
    //public class BtMachineShiftReportAppService:
    //    CrudAppService<BtMachineShiftReport,BtMachineShiftReportDto,Guid,LimitedResultRequestDto,CreateUpdateBtMachineShiftReportDto>
    //{
    //    public BtMachineShiftReportAppService(IRepository<BtMachineShiftReport,Guid> btMachineShiftReports):
    //        base(btMachineShiftReports)
    //    {

    //    }
    //}
    public class BtMachineShiftReportAppService : IApplicationService
    {
        private readonly IRepository<BtMachineShiftReport, Guid> _btMachineShiftReports;
        public BtMachineShiftReportAppService(IRepository<BtMachineShiftReport, Guid> btMachineShiftReports) 
        {
            _btMachineShiftReports = btMachineShiftReports;
        }
    }
}
