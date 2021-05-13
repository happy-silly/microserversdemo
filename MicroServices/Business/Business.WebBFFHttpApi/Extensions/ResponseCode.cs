using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.WebBFFHttpApi.Extensions
{
    /// <summary>
    /// 创建人：鲁加庆
    /// 日 期：2021.04.20
    /// 描 述：接口响应码
    /// </summary>
    public enum ResponseCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        success = 200,
        /// <summary>
        /// 失败
        /// </summary>
        fail = 400,
        /// <summary>
        /// 异常
        /// </summary>
        exception = 500,
        /// <summary>
        /// 没有登录信息
        /// </summary>
        nologin = 410
    }
}
