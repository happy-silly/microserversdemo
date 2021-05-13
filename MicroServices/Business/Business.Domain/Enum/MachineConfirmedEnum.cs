using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enum
{
    /// <summary>
    /// 开车合格单状态
    /// </summary>
    public enum MachineConfirmedEnum
    {
        [Description("未开合格单")]
        NotObtain = 0,
        [Description("下发合格单(实验室)")]
        ObtainFromLib = 1,
        [Description("车间开车确认")]
        ObtainToMill = 2
    }
}
