using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.ReportModels
{
    /// <summary>
    /// 采用E系统计算产量的方案需要使用的property
    /// </summary>
    public interface IProductionCalculate 
    {
        [Display(Name = "上机产量")]
        public long? ClassStartLength { get; set; }
        [Display(Name = "下机产量")]
        public long? ClassEndLength { get; set; }
        [Display(Name = "E系统计算的上机产量")]
        public long? TotalOutputCalStart { get; set; }
        [Display(Name = "E系统计算的下机产量")]
        public long? TotalOutputCalEnd { get; set; }
    }
}
