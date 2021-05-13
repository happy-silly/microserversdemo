using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;
using Business.DTOs;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Business.Interfaces;

namespace Business.Services
{
    public class TextileGroupAppService:
        CrudAppService<TextileGroup, TextileGroupDto, Guid, LimitedResultRequestDto, CreateUpdateTextileGroupDto>
        //ApplicationService
    {
        public TextileGroupAppService(IRepository<TextileGroup,Guid> repository)
            : base(repository)
        {

        }
    }
}
