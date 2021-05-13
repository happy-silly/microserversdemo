using Business.Models;
using Business.Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Business.WebBFFHttpApi.Service.ProductionMonitor
{
    public class SpinningSingleSpindleApp
    {
        //private readonly IRepository<ClassTable, Guid> _classTables;

        //public Task<DataTable> Getlist()
        //{
        //    var query = from classTable in _classTables
        //                join textileProcess in _textileProcesses on classTable.TextileProcessId equals textileProcess.Id
        //                //where book.Id == id
        //                select new { classTable, textileProcess };
        //    var queryResult = await AsyncExecuter.ToListAsync(query);

        //    var classTableDtos = queryResult.Select(x =>
        //    {
        //        var classTable = ObjectMapper.Map<ClassTable, ClassTableDto>(x.classTable);
        //        classTable.ProcessCode = x.textileProcess.ProcessCode;
        //        return classTable;
        //    }).ToList();
        //}
    }
}
