using AutoMapper;
using Business.DTOs;
using Business.DTOs.BtMachineShiftReport;
using Business.DTOs.ClassTables;
using Business.DTOs.CraftNodeLists;
using Business.DTOs.CsMachineShiftReport;
using Business.DTOs.FactoryProgramRecord;
using Business.DTOs.LtMachineRttemp;
using Business.DTOs.LtMachineShiftReport;
using Business.DTOs.MachineDocuments;
using Business.DTOs.MachineTypes;
using Business.DTOs.Manufacturers;
using Business.DTOs.SpinningMills;
using Business.DTOs.TextileProcesses;
using Business.DTOs.XsMachineShiftReport;
using Business.Models;
using Business.Models.Craft;
using Business.Models.Order;

namespace Business
{
    public class BusinessApplicationAutoMapperProfile : Profile
    {
        public BusinessApplicationAutoMapperProfile()
        {
            CreateMap<TextileGroup, TextileGroupDto>();
            CreateMap<CreateUpdateTextileGroupDto, TextileGroup>();

            CreateMap<SpinningMill, SpinningMillDto>();
            CreateMap<CreateUpdateSpinningMillDto, SpinningMill>();

            CreateMap<Manufacturer, ManufacturerDto>();
            CreateMap<CreateUpdateManufacturerDto, Manufacturer>();

            CreateMap<MachineType, MachineTypeDto>();
            CreateMap<CreateUpdateMachineTypeDto, MachineType>();

            CreateMap<TextileProcess, TextileProcessDto>();
            CreateMap<CreateUpdateTextileProcessDto, TextileProcess>();

            CreateMap<MachineDocument, MachineDocumentDto>();
            CreateMap<CreateUpdateMachineDocumentDto, MachineDocument>();

            CreateMap<ClassTable, ClassTableDto>();
            CreateMap<CreateUpdateClassTableDto, ClassTable>();

            CreateMap<LtMachineShiftReport, LtMachineShiftReportDto>();
            CreateMap<CreateUpdateLtMachineShiftReportDto, LtMachineShiftReport>();

            CreateMap<XsMachineShiftReport, XsMachineShiftReportDto>();
            CreateMap<CreateUpdateXsMachineShiftReportDto, XsMachineShiftReport>();

            CreateMap<CsMachineShiftReport, CsMachineShiftReportDto>();
            CreateMap<CreateUpdateCsMachineShiftReportDto, CsMachineShiftReport>();

            CreateMap<BtMachineShiftReport, BtMachineShiftReportDto>();
            CreateMap<CreateUpdateBtMachineShiftReportDto, BtMachineShiftReport>();

            CreateMap<LtMachineRttemp, LtMachineRttempDto>();
            CreateMap<CreateUpdateLtMachineRttempDto, LtMachineRttemp>();

            CreateMap<FactoryProgramRecord, FactoryProgramRecordDto>();
            CreateMap<CreateUpdateFactoryProgramRecordDto, FactoryProgramRecord>();

            CreateMap<CreateCraftNodeListDto, CraftNodeList>();
        }
    }
}
