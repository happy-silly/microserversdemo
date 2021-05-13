using Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.Interfaces
{
    public interface ITextileGroupService :
        ICrudAppService< //Defines CRUD methods
            TextileGroupDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTextileGroupDto> //Used to create/update a book
    {

    }
}
