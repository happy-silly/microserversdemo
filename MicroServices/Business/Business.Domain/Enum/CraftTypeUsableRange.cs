using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enum
{
    /// <summary>
    /// 工艺参数使用范围
    /// </summary>
    [Flags]
    public enum CraftTypeUsableRange
    {   
        [Description("都不适用")]
        None = 0b_0000_0000,  // 0
        [Description("适用于工艺大表")]
        UseAsCraftFlow = 0b_0000_0001,  // 1
        [Description("适用于车间工艺")]
        UseAsCraftInWorkShop = 0b_0000_0010,  // 2
        [Description("同时适用于工艺大表和车间工艺单")]
        BothUseInCraftFlowAndWorkShop = UseAsCraftFlow + UseAsCraftInWorkShop
    }
}
