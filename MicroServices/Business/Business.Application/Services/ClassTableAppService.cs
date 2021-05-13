using Business.DTOs.ClassTables;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Business.Services.ClassTables
{
    public class ClassTableAppService:
     CrudAppService<ClassTable, ClassTableDto, Guid, LimitedResultRequestDto, CreateUpdateClassTableDto>//,IClassTableService
    {
        private readonly IRepository<ClassTable, Guid>  _classTables;
        private readonly IRepository<TextileProcess, Guid> _textileProcesses;
        public ClassTableAppService(
            IRepository<ClassTable, Guid> classTables,
            IRepository<TextileProcess,Guid> textileProcesses) :
            base(classTables)
        {
            _classTables = classTables;
            _textileProcesses = textileProcesses;
        }

        public async Task<ClassTableDto> GetListByProcessIdAndTsIdAsync(ClassTableQueryByTsIdProcess input)
        {
            //Prepare a query to join books and authors
            var query = from classTable in _classTables
                        join textileProcess in _textileProcesses on classTable.TextileProcessId equals textileProcess.Id
                        where classTable.TsId == input.TsId && classTable.TextileProcessId == input.TextileProcessId
                        select new { classTable, textileProcess };

            //Execute the query and get the book with author
            var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);
            if (queryResult == null)
            {
                throw new EntityNotFoundException("指定的条件没有查到相关的班次记录");
            }

            var classTabLEDto = ObjectMapper.Map<ClassTable, ClassTableDto>(queryResult.classTable);
            classTabLEDto.ProcessCode = queryResult.textileProcess.ProcessCode;
            return classTabLEDto;
        }

        public async Task<ListResultDto<ClassTableDto>> GetListAllAsync(LimitedResultRequestDto input)
        {
            //Get the IQueryable<Book> from the repository
            //var queryable = await _classTables.GetListAsync();//Repository其实来自CrudAppService，类型是IRepository<Book,Guid>

            //Prepare a query to join books and authors
            var query = from classTable in _classTables
                        join textileProcess in _textileProcesses on classTable.TextileProcessId equals textileProcess.Id
                        //where book.Id == id
                        select new { classTable, textileProcess };
            var queryResult = await AsyncExecuter.ToListAsync(query);

            var classTableDtos = queryResult.Select(x =>
            {
                var classTable = ObjectMapper.Map<ClassTable, ClassTableDto>(x.classTable);
                classTable.ProcessCode = x.textileProcess.ProcessCode;
                return classTable;
            }).ToList();

            //var totalCount = await Repository.GetCountAsync();

            return new ListResultDto<ClassTableDto>();
        } 
    }
}
