using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDealPeriod
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class 分组数据
    {
       // public DateTime 班次开始时间 { get; set; }
        public DateTime? End { get; set; }
        [JsonProperty("组产量(kg)")]
        public double 组产量Kg { get; set; }
        public int 组号 { get; set; }

        [JsonProperty("组效率(%)")]
        public double 组效率 { get; set; }
    }


    public class GroupDB
    {
        public DateTime Begin { get; set; }
        public DateTime? End { get; set; }
        public DateTime BeginTimeFromUpComputer { get; set; }
        public DateTime UpdateTimeFromUpComputer { get; set; }
        public double ActualYarnWeight { get; set; }
        public int Num { get; set; }

        public double EfcRun { get; set; }
    }
    public class 机台单锭数据
    {
        public string DSP软件版本 { get; set; }
        public string FPGA软件版本 { get; set; }
        public int 切疵次数 { get; set; }

        [JsonProperty("切疵次数/10km")]
        public double 切疵次数10km { get; set; }

        [JsonProperty("切纱次数/筒纱")]
        public double 切纱次数筒纱 { get; set; }

        [JsonProperty("切纱次数/管纱")]
        public double 切纱次数管纱 { get; set; }

        [JsonProperty("单锭产量(kg)")]
        public double? 单锭产量Kg { get; set; }
        public int 单锭小车络筒成功数 { get; set; }
        public int 单锭报警信息1 { get; set; }
        public int 单锭报警信息2 { get; set; }
        public double? 单锭机械效率 { get; set; }
        public double? 单锭生产效率 { get; set; }
        public string 工艺报警平均时间 { get; set; }
        public double 工艺报警总数 { get; set; }
        public string 工艺报警总时间 { get; set; }
        public double 当前筒纱重量 { get; set; }
        public int? 当前筒纱长度 { get; set; }
        public string 打结平均时间 { get; set; }
        public double 打结总数 { get; set; }
        public string 打结总时间 { get; set; }
        public int 捻接循环次数 { get; set; }
        public int 接头数 { get; set; }

        [JsonProperty("接头数/10km")]
        public double 接头数10km { get; set; }

        [JsonProperty("接头数/筒纱")]
        public double 接头数筒纱 { get; set; }
        public string 故障平均时间 { get; set; }
        public double 故障总数 { get; set; }
        public string 故障总时间 { get; set; }
        public int 更换管纱数 { get; set; }
        public int 清纱器切疵信息 { get; set; }
        public int 清纱器报警信息 { get; set; }
        public int 生产筒纱数 { get; set; }
        public string 红灯平均时间 { get; set; }
        public double 红灯总数 { get; set; }
        public string 红灯总时间 { get; set; }
        public string 络纱时间 { get; set; }
        public string 落纱平均时间 { get; set; }
        public double 落纱总数 { get; set; }
        public string 落纱总时间 { get; set; }
        public int 锭号 { get; set; }
    }

    public class Root
    {
        public int CAN总数 { get; set; }
        public int CAN成功数 { get; set; }
        public string HMI硬件 { get; set; }
        public string HMI软件版本 { get; set; }
        public List<object> RFID { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public List<分组数据> 分组数据 { get; set; }
        public int 大纱库报警1 { get; set; }
        public int 大纱库报警2 { get; set; }

        [JsonProperty("小车落筒个数(个)")]
        public int 小车落筒个数个 { get; set; }

        [JsonProperty("小车落筒成功个数(个)")]
        public int 小车落筒成功个数个 { get; set; }

        [JsonProperty("小车落筒成功百分率(%)")]
        public double 小车落筒成功百分率 { get; set; }
        public int 工作状态 { get; set; }
        public int? 当前班次号 { get; set; }

        [JsonProperty("总满筒个数(个)")]
        public int 总满筒个数个 { get; set; }

        [JsonProperty("总落筒成功百分率(%)")]
        public double 总落筒成功百分率 { get; set; }

        [JsonProperty("拔管处通过数(个)")]
        public int 拔管处通过数个 { get; set; }
        public string 数据组 { get; set; }

        [JsonProperty("整车产量(kg)")]
        public double? 整车产量Kg { get; set; }
        public int 整车报警 { get; set; }

        [JsonProperty("整车效率(%)")]
        public double? 整车效率 { get; set; }
        public List<机台单锭数据> 机台单锭数据 { get; set; }
        public string 机台时间 { get; set; }

        [JsonProperty("残纱数量(个)")]
        public string 残纱数量个 { get; set; }

        [JsonProperty("残纱率(%)")]
        public double? 残纱率 { get; set; }
        public string 班组 { get; set; }
        public int 直流电源报警 { get; set; }

        [JsonProperty("空管回送数(个)")]
        public int 空管回送数个 { get; set; }

        [JsonProperty("空管率(%)")]
        public double? 空管率 { get; set; }

        [JsonProperty("第一生头成功数(个)")]
        public int 第一生头成功数个 { get; set; }

        [JsonProperty("第一生头成功率(%)")]
        public double? 第一生头成功率 { get; set; }

        [JsonProperty("第一生头通过数(个)")]
        public int 第一生头通过数个 { get; set; }

        [JsonProperty("第二生头成功数(个)")]
        public int 第二生头成功数个 { get; set; }

        [JsonProperty("第二生头成功率(%)")]
        public double? 第二生头成功率 { get; set; }

        [JsonProperty("第二生头通过数(个)")]
        public int 第二生头通过数个 { get; set; }
        public int 纱库盘报警 { get; set; }
        public int 细络联报警 { get; set; }
        public int 设备状态 { get; set; }

        [JsonProperty("进入单锭数(个)")]
        public int 进入单锭数个 { get; set; }

        [JsonProperty("进管数(个)")]
        public int 进管数个 { get; set; }
    }
}
