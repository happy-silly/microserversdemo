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
    /// 工艺线状态
    /// </summary>
    public enum CraftFlowFlagEnum
    {
        [Description("历史工艺")]
        History = 0,
        [Description("最新工艺")]
        Latest = 1
    }
}
