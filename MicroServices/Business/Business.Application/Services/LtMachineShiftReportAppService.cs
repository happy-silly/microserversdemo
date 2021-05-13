using Business.DTOs;
using Business.DTOs.LtMachineShiftReport;
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
    public class LtMachineShiftReportAppService:
        CrudAppService<LtMachineShiftReport, LtMachineShiftReportDto, Guid, LimitedResultRequestDto, CreateUpdateLtMachineShiftReportDto>
    {
        private readonly IRepository<LtMachineShiftReport, Guid> _ltMachineShiftReports;
        public LtMachineShiftReportAppService(IRepository<LtMachineShiftReport, Guid> ltMachineShiftReports) :
            base(ltMachineShiftReports)
        {
            _ltMachineShiftReports = ltMachineShiftReports;
        }
    }
}
