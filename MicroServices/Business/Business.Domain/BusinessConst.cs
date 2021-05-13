using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessConst
    {
        /// <summary>
        /// 通用的相对静态的描述资产和基础设施的表格。像机型、工序、车间、机台、锭号。
        /// </summary>
        public const string AssetsDbTablePrefix = "Assets_";
        /// <summary>
        /// 人员管理
        /// </summary>
        public const string HumanResourceDbTablePrefix = "HumanResource_";
        /// <summary>
        /// 班次设置、品种信息等。
        /// </summary>
        public const string ProcessDbTablePrefix = "Process_";
        /// <summary>
        /// 基础生产报表相关，例如班报、周报、月报、开停等
        /// </summary>
        public const string ProductionDbTablePrefix = "Production_"; 
        /// <summary>
        /// 订单、调度相关
        /// </summary>
        public const string OrderDbTablePrefix = "Order_";
        /// <summary>
        /// 电量相关
        /// </summary>
        public const string EnergyDbTablePrefix = "Energy_";
        /// <summary>
        /// 质量管理相关
        /// </summary>
        public const string QualityDbTablePrefix = "Quality_";
        /// <summary>
        /// 工艺配棉相关
        /// </summary>
        public const string CraftDbTablePrefix = "Craft_";
        /// <summary>
        /// 预留的应对来自设备的难以通用化处理的数据。
        /// </summary>
        public const string MachineDataDbTablePrefix = "MachineData_";
        /// <summary>
        /// 默认架构名
        /// </summary>
        public const string DbSchema = "dbo";
        

    }
}
