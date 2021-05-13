using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.WebBFFHttpApi.Extensions
{
    [ApiController]
    [Route("webapi/[controller]/[action]")]
    public class ApiControllerBase : Controller
    {
        protected IOptions<HttpApiUrlStrs> _httpApiUrlStrs;

        protected Dictionary<string, string> AjaxUrls = new Dictionary<string, string>();

        /// <summary>
        /// 返回成功数据
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        protected virtual IActionResult Success(object data)
        {
            return Content(new ResParameter { code = ResponseCode.success, info = "响应成功", data = data }.ToJson());
        }
        /// <summary>
        /// 返回成功消息
        /// </summary>
        /// <param name="info">信息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        protected virtual IActionResult Success(string info, object data)
        {
            return Content(new ResParameter { code = ResponseCode.success, info = info, data = data }.ToJson());
        }
        /// <summary>
        /// 返回成功数据
        /// </summary>
        /// <param name="info">信息</param>
        /// <returns></returns>
        protected virtual IActionResult SuccessInfo(string info)
        {
            return Content(new ResParameter { code = ResponseCode.success, info = info }.ToJson());
        }

        /// <summary>
        /// 返回失败消息
        /// </summary>
        /// <param name="info">消息</param>
        /// <returns></returns>
        protected virtual IActionResult Fail(string info)
        {
            return Content(new ResParameter { code = ResponseCode.fail, info = info }.ToJson());
        }
    }
}
