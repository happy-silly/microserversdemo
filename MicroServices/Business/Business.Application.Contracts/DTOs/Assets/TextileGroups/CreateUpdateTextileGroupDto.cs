using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs
{
    public class CreateUpdateTextileGroupDto
    {
        [Required]
        [StringLength(128)]
        public string GroupName { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string Slogan { get; set; }
    }
}
