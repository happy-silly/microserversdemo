using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.ClassTables
{
    public class ClassTableQueryByTsIdProcess
    {
        public int TsId { get; set; }
        public Guid TextileProcessId { get; set; }
    }
}
