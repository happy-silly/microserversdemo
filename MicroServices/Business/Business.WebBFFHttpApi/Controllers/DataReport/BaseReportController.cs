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

namespace Business.WebBFFHttpApi.Controllers.DataReport
{
    /// <summary>
    /// 基础报表页面处理API
    /// </summary>
    public class BaseReportController : ApiControllerBase
    {
        public BaseReportController(IOptions<HttpApiUrlStrs> httpApiUrlStrs)
        {
            _httpApiUrlStrs = httpApiUrlStrs;
            //请求络筒班报数据
            AjaxUrls.Add("GetMachineStatisticsList", "api/app/lt-machine-shift-report");
        }

        /// <summary>
        /// 查询机台统计列表
        /// </summary>
        /// <param name="process_Id">工序ID</param>
        /// <param name="variety_Id">品种ID</param>
        /// <param name="searchDate">查询日期</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMachineStatisticsList(string process_Id,string variety_Id,DateTime? searchDate)
        {
            try
            {
                string requestUrl = _httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetMachineStatisticsList"].ToString();
                var result = await HTTPMethods.Get(requestUrl);
                return Success(result);
            }
            catch (Exception e)
            {
                return Fail("未知错误");
            }
        }



    }
}
