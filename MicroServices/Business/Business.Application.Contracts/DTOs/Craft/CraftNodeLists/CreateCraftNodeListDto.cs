using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.CraftNodeLists
{
    public class CreateCraftNodeListDto
    {
        public Guid SpinningMillId { get; set; }

        public string Name { get; set; }

        //public Guid? TextileProcessId { get; set; }

        public int SortNum { get; set; }
    }
}
