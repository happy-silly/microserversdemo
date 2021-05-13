using Business.DTOs.TextileProcesses;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.TextileProcesses
{
    public class TextileProcessAppService:
        CrudAppService<TextileProcess,TextileProcessDto,Guid, LimitedResultRequestDto, CreateUpdateTextileProcessDto>
    {
        private IRepository<TextileProcess, Guid> _textileProcesses;

        public TextileProcessAppService(IRepository<TextileProcess,Guid> textileProcesses)
            : base(textileProcesses)
        {
            _textileProcesses = textileProcesses;
        }
    }
}
