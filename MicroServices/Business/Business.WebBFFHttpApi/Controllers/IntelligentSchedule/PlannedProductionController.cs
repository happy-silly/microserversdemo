using Business.WebBFFHttpApi.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.WebBFFHttpApi.Controllers.IntelligentSchedule
{
    /// <summary>
    /// 计划排产模块处理API
    /// </summary>
    public class PlannedProductionController : ApiControllerBase
    {
        public PlannedProductionController(IOptions<HttpApiUrlStrs> httpApiUrlStrs)
        {
            _httpApiUrlStrs = httpApiUrlStrs;
            //请求XXX资源
            AjaxUrls.Add("GetTable", "api/business/MachineType");
        }
    }
}
