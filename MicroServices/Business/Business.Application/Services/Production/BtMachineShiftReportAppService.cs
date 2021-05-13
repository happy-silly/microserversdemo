using Business.DTOs.BtMachineShiftReport;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

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
    public class BtMachineShiftReportAppService : ApplicationService
    {
        private readonly IRepository<BtMachineShiftReport, Guid> _btMachineShiftReports;
        public BtMachineShiftReportAppService(IRepository<BtMachineShiftReport, Guid> btMachineShiftReports) 
        {
            _btMachineShiftReports = btMachineShiftReports;
        }

        public async Task CreateAsync(CreateUpdateBtMachineShiftReportDto input)
        {
            var BtMachineShiftReport = ObjectMapper.Map<CreateUpdateBtMachineShiftReportDto, BtMachineShiftReport>(input);

            await _btMachineShiftReports.InsertAsync(BtMachineShiftReport);
        }

        public async Task<BtMachineShiftReportDto> GetAsync(Guid id)
        {
            var book = await _btMachineShiftReports.GetAsync(id);
            return ObjectMapper.Map<BtMachineShiftReport, BtMachineShiftReportDto>(book);
        }
        public async Task<ActionResult<IEnumerable<BtMachineShiftReport>>> GetAllAsync()
        {
            return await _btMachineShiftReports.GetListAsync();
            //return IObjectMapper<BtMachineShiftReport, BtMachineShiftReportDto>(book);
        }

    }
}
