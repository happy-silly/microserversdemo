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
    /// 生产调度管理 API
    /// </summary>
    public class ProductSchduleController : ApiControllerBase
    {
        public ProductSchduleController(IOptions<HttpApiUrlStrs> httpApiUrlStrs)
        {
            _httpApiUrlStrs = httpApiUrlStrs;
            //请求XXX资源
            AjaxUrls.Add("GetTable", "api/business/MachineType");
        }
    }
}
