using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enum
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderFlagEnum
    {
        [Description("待纺")]
        Waiting = 0,
        [Description("在纺")]
        InProcess = 1,
        [Description("完结")]
        Accomplish = 2
    }
}
