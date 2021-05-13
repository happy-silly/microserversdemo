using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.ReportModels
{
    public interface IEfc
    {
        [Display(Name = "运转效率")]
        public double? EfcRun { get; set; }
    }
}
