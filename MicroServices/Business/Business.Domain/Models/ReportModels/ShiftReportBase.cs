using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Business.Models
{
    /// <summary>
    /// 班报基类
    /// </summary>
    public class ShiftReportBase:AuditedEntity<Guid> 
    {
        public ShiftReportBase()
        {

        }
        public ShiftReportBase(Guid id) : base(id)
        {

        }
        [Display(Name ="机台")]
        public Guid MachineDocumentId { get; set; }
        [Display(Name ="机台")]
        public MachineDocument MachineDocument { get; set; }

        [Display(Name ="机台号")]
        public string MachineName { get; set; }

        [Display(Name = "ShiftTimestampId")]
        public int? Tsid { get; set; }

        [Display(Name ="日期")]
        public DateTime? ShiftDate { get; set; }

        [Display(Name ="班次")]
        public string ShiftName { get; set; }

        [Display(Name ="班组")]
        public string TeamSet { get; set; }

        [Display(Name ="序号")]
        public int? ShiftNum { get; set; }

        [Display(Name = "开始时间")]
        public DateTime? Begin { get; set; }
        [Display(Name = "结束时间")]
        public DateTime? End { get; set; }
        [Display(Name ="平均速度1")]
        public double SpeedAvg1 { get; set; }
        [Display(Name ="平均速度2")]
        public double SpeedAvg2 { get; set; }
    }
}
