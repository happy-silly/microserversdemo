﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Models
{
    /// <summary>
    /// 机台
    /// </summary>
    public class MachineDocument :Entity<Guid>
    {
        [Display(Name = "工序代码")]
        public string ProcessCode { get; set; }
        // 这个和process code有不同
        [Display(Name = "工序")]
        public string ProcessName { get; set; }

        [Display(Name = "机台排序")]
        public int MachineNo { get; set; }
        [Display(Name = "机台号")]
        public string MachineName { get; set; }

        [Display(Name = "出厂序号")]
        public string Serial { get; set; }
        [Display(Name = "IP")]
        public string Ip { get; set; }
        [Display(Name = "站号")]
        public byte? ModbusAddr { get; set; }
        [Display(Name = "子型号")]
        public string Subtype { get; set; }
        [Display(Name = "上位机版本")]
        public string UpcVersion { get; set; }
        [Display(Name = "锭数")]
        public int? TotalSpindles { get; set; }
        [Display(Name = "段")]
        public int? Segments { get; set; }
        [Display(Name = "断纱检测")]
        public int? YarnBreakDetection { get; set; }
        [Display(Name = "记录时间")]
        public DateTime RecordTimestamp { get; set; }

        [Display(Name = "机型ID")]
        public int? MachineTypeId { get; set; }
        [Display(Name = "机型")]
        public MachineType MachineType { get; set; }

        public Guid? SpinningMillId { get; set; }
        [Display(Name = "所属车间")]
        public SpinningMill SpinningMill { get; set; }

        //[Display(Name ="所属工序")]
        //public  Guid? TextileProcessId { get; set; }
        //public TextileProcess TextileProcess { get; set; }

        public MachineDocument()
        {

        }
        public MachineDocument(Guid id)
            : base(id)
        {

        }
    }
}