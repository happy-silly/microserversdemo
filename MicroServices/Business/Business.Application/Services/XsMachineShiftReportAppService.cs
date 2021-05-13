using Business.DTOs.XsMachineShiftReport;
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
    public class XsMachineShiftReportAppService : CrudAppService<XsMachineShiftReport,XsMachineShiftReportDto,Guid, LimitedResultRequestDto,CreateUpdateXsMachineShiftReportDto>
    {
        //private readonly IRepository<XsMachineShiftReport, Guid> _xsMachineShiftReports;
        public XsMachineShiftReportAppService(IRepository<XsMachineShiftReport,Guid> xsMachineShiftReports)
            : base(xsMachineShiftReports)
        {
            //_xsMachineShiftReports = xsMachineShiftReports;
        }
    }
}
