using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Business.Models
{
    class MachinePosition:Entity<Guid>
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        protected MachinePosition()
        {
        }
        public MachinePosition(Guid id)
         : base(id)
        {

        }
    }
}
