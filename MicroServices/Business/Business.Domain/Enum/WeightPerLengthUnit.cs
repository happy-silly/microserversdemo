using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enum
{
    /// <summary>
    /// 定量单位
    /// </summary>
    public enum WeightPerLengthUnit
    {
        [Description("g/Km")]
        gPerKm = 1,
        [Description("g/100m")]
        gPer100m = 10,
        [Description("g/10m")]
        gPer10m = 100,
        [Description("g/5m")]
        gPer5m = 200,
        [Description("g/m")]
        gPer1m = 1000
    }
}
