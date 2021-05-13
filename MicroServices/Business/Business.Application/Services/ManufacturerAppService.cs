using Business.DTOs.Manufacturers;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.Manufacturers
{
    public class ManufacturerAppService:
        CrudAppService<Manufacturer, ManufacturerDto,int, LimitedResultRequestDto, CreateUpdateManufacturerDto>
    {
        private IRepository<Manufacturer, int> _manufacturers;
        public ManufacturerAppService(IRepository<Manufacturer,int> manufacturers)
            :base(manufacturers)
        {
            _manufacturers = manufacturers;
        }

    }
}
