using Business.DTOs.ClassTables;
using Business.Services.ClassTables;
using Business.WebBFFHttpApi.Extensions;
using Business.WebBFFHttpApi.Service.ProductionMonitor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;
using System.ComponentModel;

namespace Business.WebBFFHttpApi.Controllers.ProductionMonitor
{
    /// <summary>
    /// 细纱单锭页面处理API
    /// </summary>
    public class SpinningSingleSpindleController : ApiControllerBase
    {
        

        public SpinningSingleSpindleController(IOptions<HttpApiUrlStrs> httpApiUrlStrs)
        {
            _httpApiUrlStrs = httpApiUrlStrs;
            //请求XXX资源
            AjaxUrls.Add("GetTable", "api/business/MachineType");
        }

      
        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Getlist()
        {
            var result = await HTTPMethods.Get(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetTable"].ToString() );
            return Success(result);
        }
    }
}
