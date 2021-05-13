using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.DTOs.ClassTables
{
    public interface IClassTableService:
        ICrudAppService< //Defines CRUD methods
            ClassTableDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClassTableDto> //Used to create/update a book
    {
    }
}
