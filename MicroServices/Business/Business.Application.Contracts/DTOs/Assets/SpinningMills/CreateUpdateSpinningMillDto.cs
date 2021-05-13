using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.SpinningMills
{
    public class CreateUpdateSpinningMillDto
    {
        [Required]
        [StringLength(128)]
        public string MillName { get; set; }
        public string Address { get; set; }
        public string Coordinates { get; set; }
        [Required]
        public Guid? TextileGroupId { get; set; }
    }
}
