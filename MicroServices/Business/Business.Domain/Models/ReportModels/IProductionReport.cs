using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.ReportModels
{
    /// <summary>
    /// 班报所需的产量和效率接口
    /// </summary>
    public interface IProductionReport: IEfc
    {
        [Display(Name = "班产(米)")]
        public double? YarnLength { get; set; }

        [Display(Name = "理论重量(Kg)")]
        public double? TheoreticalYarnWeight { get; set; }

        [Display(Name = "实际重量(Kg)")]
        public double? ActualYarnWeight { get; set; }

        [Display(Name = "修正系数")]
        public double? Coe { get; set; }

        [Display(Name ="调度记录")]
        public Guid? ProductionDispatchId { get; set; }

    }
}
