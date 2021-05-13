using Business.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    /// <summary>
    /// 络筒整车实时数据
    /// </summary>
    public class LtMachineRttemp:MachineRttempBase
    {
        public LtMachineRttemp()
        {

        }
        public LtMachineRttemp(Guid id) : base(id)
        {

        }
        [Display(Name = "整车产量(kg)")]
        public double? MachineWeight { get; set; }
        [Display(Name = "整车效率(%)")]
        public double? MachineEfc { get; set; }
        [Display(Name = "工作状态")]
        public int? WorkState { get; set; }
        //[Display(Name = "设备状态")]
        //public int? DeviceState { get; set; }
        [Display(Name = "进入单锭数(个)")]
        public int? SingleSpindleEnterNum { get; set; }
        [Display(Name = "当前班次号")]
        public int? CurrentShift { get; set; }
        [Display(Name = "空管回送数(个)")]
        public int? YarndepotEmptyTubeEcho { get; set; }
        [Display(Name = "残纱数量(个)")]
        public int? YarndepotResidualNum { get; set; }
        [Display(Name = "第一生头通过数(个)")]
        public int? FirstRawHeadPassNum { get; set; }
        [Display(Name = "第一生头成功数(个)")]
        public int? FirstRawHeadSuccessNum { get; set; }
        [Display(Name = "第二生头通过数(个)")]
        public int? SecondRawHeadPassNum { get; set; }
        [Display(Name = "第二生头成功数(个)")]
        public int? SecondRawHeadSuccessNum { get; set; }
        [Display(Name = "拔管处通过数(个)")]
        public int? TubeDrawingPassNum { get; set; }
        [Display(Name = "第一生头成功率(%)")]
        public double? FirstRawHeadRatio { get; set; }
        [Display(Name = "第二生头成功率(%)")]
        public double? SecondRawHeadRatio { get; set; }
        [Display(Name = "残纱率(%)")]
        public double? YarndepotResidualRatio { get; set; }
        [Display(Name = "空管率(%)")]
        public double? YarndepotEmptyTubeRatio { get; set; }
        [Display(Name = "总满筒个数(个)")]
        public int? TotalFullCylinder_num { get; set; }
        [Display(Name = "总落筒成功百分率(%)")]
        public double? TotalFallingCylinderSuccessRatio { get; set; }
        [Display(Name = "小车落筒成功个数(个)")]
        public int? FallingCylinderSuccessNum { get; set; }
        [Display(Name = "小车落筒个数(个)")]
        public int? FullCylinderNum { get; set; }
        [Display(Name = "小车落筒成功百分率(%)")]
        public double? FallingCylinderSuccessRatio { get; set; }
        [Display(Name = "整车报警")]
        public int? MachineFault { get; set; }
        [Display(Name = "直流电源报警")]
        public int? DirectPowerFault { get; set; }
        [Display(Name = "细络联报警")]
        public int? EsperoFault { get; set; }
        [Display(Name = "大纱库报警1")]
        public int? BigYarnLibFault1 { get; set; }
        [Display(Name = "大纱库报警2")]
        public int? BigYarnLibFault2 { get; set; }
        [Display(Name = "纱库盘报警")]
        public int? YarnLibPlateFault { get; set; }
        [Display(Name = "CAN总数")]
        public int? CanCnt { get; set; }
        [Display(Name = "CAN成功数")]
        public int? CanSucceedCount { get; set; }
        [Display(Name = "HMI硬件")]
        public string HmiHardware { get; set; }
        [Display(Name = "HMI软件版本")]
        public string HmiSoftwareVersion { get; set; }
    }
}
