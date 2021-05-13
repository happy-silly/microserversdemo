using Business.DTOs.MachineDocuments;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.MachineDocuments
{
    public class MachineDocumentAppService:
        CrudAppService<MachineDocument,MachineDocumentDto,Guid, LimitedResultRequestDto, CreateUpdateMachineDocumentDto>
    {
        private readonly IRepository<MachineDocument, Guid> _machineDocuments;
        public MachineDocumentAppService(IRepository<MachineDocument,Guid> machineDocuments):
            base(machineDocuments)
        {
            _machineDocuments = machineDocuments;
        }
    }
}
