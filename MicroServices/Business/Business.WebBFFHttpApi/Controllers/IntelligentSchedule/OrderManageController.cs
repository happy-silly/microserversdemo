using Business.DTOs.FactoryProgramRecord;
using Business.WebBFFHttpApi.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Business.WebBFFHttpApi.Controllers.IntelligentSchedule
{
    /// <summary>
    /// 订单管理模块处理API
    /// </summary>
    public class OrderManageController : ApiControllerBase
    {
        public OrderManageController(IOptions<HttpApiUrlStrs> httpApiUrlStrs)
        {
            _httpApiUrlStrs = httpApiUrlStrs;
            //获取车间信息
            AjaxUrls.Add("GetSpinningMillData", "api/business/spinning-mill/");

            //新增订单表单
            AjaxUrls.Add("AddOrderForm", "api/business/factory-program-record");
            //修改订单表单
            AjaxUrls.Add("ModifyOrderForm", "api/business/factory-program-record/");
            //删除订单表单
            AjaxUrls.Add("DeleteOrderForm", "api/business/factory-program-record/");
            //获取订单表单
            AjaxUrls.Add("GetOrderData", "api/business/factory-program-record/");
            //获取订单列表
            AjaxUrls.Add("GetOrderList", "api/business/factory-program-record");
        }

        #region 订单录入页面处理
        /// <summary>
        /// 保存订单数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOrderForm(CreateUpdateFactoryProgramRecordDto entity)
        {
            #region 字段合法性验证
            //所属车间 必填
            if (entity.SpinningMillId == Guid.Empty)
            {
                return Fail("车间信息必传！");
            }
            //所属车间 有效
            HttpResponseMessage SpinningMillResult = await HTTPMethods.Get(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetSpinningMillData"].ToString() + entity.SpinningMillId);
            if (SpinningMillResult.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return Fail("车间信息不存在！");
            }
            //订单号 必填
            if (!string.IsNullOrEmpty(entity.Code)) {
                return Fail("订单号必填！");
            }
            #endregion
            HttpResponseMessage result = await HTTPMethods.Post(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["AddOrderForm"].ToString(), entity.ToJson());
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return SuccessInfo("新增成功！");
            }
            else
            {
                return Fail("未知错误！");
            }
        }
        /// <summary>
        /// 修改订单数据
        /// </summary>
        /// <param name="keyvalue">主键</param>
        /// <param name="entity">修改</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ModifyOrderForm(string keyValue, CreateUpdateFactoryProgramRecordDto entity)
        {
            #region 字段合法性验证
            //主键必填 
            if (!string.IsNullOrEmpty(keyValue))
            {
                return Fail("订单ID必填！");
            }
            //所属车间 必填
            if (entity.SpinningMillId == Guid.Empty)
            {
                return Fail("车间信息必传！");
            }
            //所属车间 有效
            HttpResponseMessage SpinningMillResult = await HTTPMethods.Get(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetSpinningMillData"].ToString() + entity.SpinningMillId);
            if (SpinningMillResult.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return Fail("车间信息不存在！");
            }
            //订单号 必填
            if (!string.IsNullOrEmpty(entity.Code))
            {
                return Fail("订单号必填！");
            }
            #endregion
            HttpResponseMessage result = await HTTPMethods.Put(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["ModifyOrderForm"].ToString() + keyValue, entity.ToJson());
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return SuccessInfo("修改成功！");
            }
            else
            {
                return Fail("未知错误！");
            }
        }
        /// <summary>
        /// 删除订单数据
        /// </summary>
        /// <param name="keyvalue">主键</param>
        /// <param name="entity">修改</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DeleteOrderForm(string keyValue)
        {
            #region 字段合法性验证
            //主键必填 
            if (!string.IsNullOrEmpty(keyValue))
            {
                return Fail("订单ID必填！");
            }
            #endregion
            HttpResponseMessage result = await HTTPMethods.Delete(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["DeleteOrderForm"].ToString() + keyValue);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return SuccessInfo("删除成功！");
            }
            else
            {
                return Fail("未知错误！");
            }
        }
        /// <summary>
        /// 获取订单数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetOrderData(string keyValue)
        {
            #region 字段合法性验证
            //主键必填 
            if (!string.IsNullOrEmpty(keyValue))
            {
                return Fail("订单ID必填！");
            }
            #endregion
            HttpResponseMessage result = await HTTPMethods.Get(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetOrderData"].ToString() + keyValue);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return SuccessInfo(await result.Content.ReadAsStringAsync());
            }
            else
            {
                return Fail("未知错误！");
            }
        }
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetOrderList()
        {
            HttpResponseMessage result = await HTTPMethods.Get(_httpApiUrlStrs.Value.BusinessApiUrl + AjaxUrls["GetOrderList"].ToString());
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return SuccessInfo(await result.Content.ReadAsStringAsync());
            }
            else
            {
                return Fail("未知错误！");
            }
        }
        #endregion

        #region 订单调度页面处理


        #endregion

        #region 开工艺单页面处理


        #endregion


        #region 开合格单页面处理


        #endregion

        #region 订单跟踪页面处理


        #endregion

        #region 订单完结页面处理


        #endregion

        #region 调度查询页面处理


        #endregion


        #region 配台配置页面处理


        #endregion


        #region 查询
        //1. 根据订单号 品种 订单日期 获取数据列表
        //2.获取ERP同步数据

        #endregion

        #region 新增 修改 删除 同步 
        //1.新增数据
        //2.根据id修改数据
        //3.删除数据
        //4.同步ERP数据
        #endregion
    }
}
