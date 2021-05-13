using Business.DTOs.CsMachineShiftReport;
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
    public class CsMachineShiftReportAppService:
        CrudAppService<CsMachineShiftReport,CsMachineShiftReportDto,Guid,LimitedResultRequestDto,CreateUpdateCsMachineShiftReportDto>
    {
        public CsMachineShiftReportAppService(IRepository<CsMachineShiftReport,Guid> csMachineShiftReports)
            : base(csMachineShiftReports)
        {

        }
    }
}
