using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.ReportModels
{
    /// <summary>
    /// 报班所需的电量接口
    /// </summary>
    public interface IPowerReport
    {
        [Display(Name = "耗电")]
        public double? Power { get; set; }
        [Display(Name = "吨纱耗电")]
        public double? PowerPerWeight { get; set; }
    }
}
