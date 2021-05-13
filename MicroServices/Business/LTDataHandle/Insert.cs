using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using log4net;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Threading;
using Newtonsoft.Json;
using System.Linq;
using System.Diagnostics;
using LTDealPeriod;
using System.IO;
using Business.Models;
using Business.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Business.Models.Production;
//using System.Text.Json.Serialization;

namespace mqttclientForm
{
    class InsertSqlServer
    {
        public static readonly ILog _log = LogManager.GetLogger("");
        public static Dictionary<string, Guid> IP_GUID = new Dictionary<string, Guid>();
        static GloalVariables gVs = new GloalVariables();//一个全局变量类，主要包含连接字符串

        public bool SqlConnect(ref SqlConnection con)
        {
            try
            {
                ini();
                var optionsBuilder = new DbContextOptionsBuilder<BusinessDbContext>();
                optionsBuilder.UseSqlServer(gVs.connectString);
                using (BusinessDbContext dbContext = new BusinessDbContext(optionsBuilder.Options))
                {

                    if (IP_GUID.Count < 1)
                    {
                        var IpList = dbContext.MachineDocuments.Where(t => t.ProcessCode == "11").Select(o => o);
                        foreach (MachineDocument MachineDocuments in IpList)
                        {
                            IP_GUID.Add(MachineDocuments.Ip.ToString().Replace(" ", ""), MachineDocuments.Id);
                        }
                    }
                    List<LtMachineRttemp> LtMachineRttemp = new List<LtMachineRttemp>();
                    LtMachineRttemp = dbContext.LtMachineRttemps.Select(t => t).ToList();


                    return true;
                }
            }
            catch (System.Exception ex)
            {
                _log.Error(ex.Message);
                return false;
            }
        }

        public bool ExecuteInsertPeriod(string topic, string msg, int state)
        {
            //var jobject = JsonConvert.DeserializeObject<dynamic>(msg);
            var jobject = JsonConvert.DeserializeObject<Root>(msg);

            //var jobject = JObject.Parse(jsonObject);
            string ip = jobject.ip;
            try
            {
                ini();
                if (state == 2001 && topic == "Period")
                {
                    var optionsBuilder = new DbContextOptionsBuilder<BusinessDbContext>();
                    optionsBuilder.UseSqlServer(gVs.connectString);
                    using (BusinessDbContext dbContext = new BusinessDbContext(optionsBuilder.Options))
                    {
                        var dev_guid = IP_GUID.Where(t => t.Key == ip).Select(o => o.Value).FirstOrDefault();

                        // List<LtMachineRttemp> LtMachineRttemp = new List<LtMachineRttemp>();

                        //整车数据
                        var temp = dbContext.LtMachineRttemps.Where(t => t.Id == dev_guid).Select(t => t).First();

                        var ChangeClassFlag = 0;
                        if (jobject.当前班次号 != temp.CurrentShift)
                            ChangeClassFlag = 1;
                        else
                            ChangeClassFlag = 0;
                        //当实时表中没有该机台数据时，往表里插入一条数据
                        if (temp.MachineName == null)
                        {
                            List<LtMachineRttemp> LtMachine = new List<LtMachineRttemp>();
                            LtMachine.Add(new LtMachineRttemp
                            {
                                //Id = dev_guid
                            }); ;
                        }
                        //当班次号发生变化，则换班
                        if (ChangeClassFlag == 1)
                        {
                            //插入数据到Production_LtMachineShiftReport
                            List<LtMachineShiftReport> LtMachineShiftReport = new List<LtMachineShiftReport>();
                            LtMachineShiftReport.Add(new LtMachineShiftReport
                            {
                                //Id                                   =temp.Id                                 ,
                                SingleSpindleEnterNum = temp.SingleSpindleEnterNum,
                                YarndepotEmptyTubeEcho = temp.YarndepotEmptyTubeEcho,
                                YarndepotResidualNum = temp.YarndepotResidualNum,
                                FirstRawHeadPassNum = temp.FirstRawHeadPassNum,
                                FirstRawHeadSuccessNum = temp.FirstRawHeadSuccessNum,
                                SecondRawHeadPassNum = temp.SecondRawHeadPassNum,
                                SecondRawHeadSuccessNum = temp.SecondRawHeadSuccessNum,
                                TubeDrawingPassNum = temp.TubeDrawingPassNum,
                                FirstRawHeadRatio = temp.FirstRawHeadRatio,
                                SecondRawHeadRatio = temp.SecondRawHeadRatio,
                                YarndepotResidualRatio = temp.YarndepotResidualRatio,
                                YarndepotEmptyTubeRatio = temp.YarndepotEmptyTubeRatio,
                                FallingCylinderSuccessNum = temp.FallingCylinderSuccessNum,
                                FullCylinderNum = temp.FullCylinderNum,
                                FallingCylinderSuccessRatio = temp.FallingCylinderSuccessRatio,
                                TotalFullCylinder_num = temp.TotalFullCylinder_num,
                                TotalFallingCylinderSuccessRatio = temp.TotalFallingCylinderSuccessRatio,
                                //ClassStartLength                     =temp.ClassStartLength                   ,
                                //ClassEndLength                       =temp.ClassEndLength                     ,
                                //TotalOutputCalStart                  =temp.TotalOutputCalStart                ,
                                //TotalOutputCalEnd                    =temp.TotalOutputCalEnd                  ,
                                //YarnLength                           =temp.YarnLength                         ,
                                //TheoreticalYarnWeight                =temp.TheoreticalYarnWeight              ,
                                //ActualYarnWeight                     =temp.ActualYarnWeight                   ,
                                Coe = 1,
                                EfcRun = temp.EfcRun,
                                //Power                                =temp.Power                              ,
                                //PowerPerWeight                       =temp.PowerPerWeight                     ,
                                ProductionDispatchId = temp.ProductionDispatchId,
                                LastModificationTime = temp.LastModificationTime,
                                LastModifierId = temp.LastModifierId,
                                MachineDocumentId = temp.Id,
                                MachineName = temp.MachineName,
                                Tsid = temp.Tsid,
                                ShiftDate = DateTime.Today,
                                ShiftName = temp.ShiftName,
                                TeamSet = temp.TeamSet,
                                ShiftNum = temp.ShiftNum,
                                Begin = temp.Start,
                                End = temp.End
                            });

                            //更新实时表的班次信息
                            //temp.Tsid = jobject[""];
                            //temp.ShiftName = jobject[""];
                            //temp.ShiftNum = jobject[""];
                            //temp.TeamSet = jobject[""];
                            //temp.Start = jobject[""];
                            //temp.End = jobject[""];
                            //temp.OutputLengthStart =jobject[""];
                        }

                        temp.MachineWeight = jobject.整车产量Kg;
                        temp.MachineEfc = jobject.整车效率;
                        temp.WorkState = jobject.工作状态;
                        temp.SingleSpindleEnterNum = jobject.进入单锭数个;
                        temp.CurrentShift = jobject.当前班次号;
                        temp.YarndepotEmptyTubeEcho = jobject.空管回送数个;
                        temp.FirstRawHeadPassNum = jobject.第一生头通过数个;
                        temp.FirstRawHeadSuccessNum = jobject.第一生头成功数个;
                        temp.SecondRawHeadPassNum = jobject.第二生头通过数个;
                        temp.SecondRawHeadSuccessNum = jobject.第二生头成功数个;
                        temp.TubeDrawingPassNum = jobject.拔管处通过数个;
                        temp.FirstRawHeadRatio = jobject.第一生头成功率;
                        temp.SecondRawHeadRatio = jobject.第二生头成功率;
                        temp.YarndepotResidualRatio = jobject.残纱率;
                        temp.YarndepotEmptyTubeRatio = jobject.空管率;
                        temp.TotalFullCylinder_num = jobject.总满筒个数个;
                        temp.TotalFallingCylinderSuccessRatio = jobject.总落筒成功百分率;
                        temp.FallingCylinderSuccessNum = jobject.小车落筒成功个数个;
                        temp.FullCylinderNum = jobject.小车落筒个数个;
                        temp.FallingCylinderSuccessRatio = jobject.小车落筒成功百分率;
                        temp.MachineFault = jobject.整车报警;
                        temp.DirectPowerFault = jobject.直流电源报警;
                        temp.EsperoFault = jobject.细络联报警;
                        temp.BigYarnLibFault1 = jobject.大纱库报警1;
                        temp.BigYarnLibFault2 = jobject.大纱库报警2;
                        temp.YarnLibPlateFault = jobject.纱库盘报警;
                        temp.CanCnt = jobject.CAN总数;
                        temp.CanSucceedCount = jobject.CAN成功数;
                        temp.HmiHardware = jobject.HMI硬件;
                        temp.HmiSoftwareVersion = jobject.HMI软件版本;
                        //temp.LastModificationTime             =jobject[""];
                        //temp.LastModifierId                   =jobject[""];
                        //temp.MachineName = jobject[""];
                        //temp.Tsid = jobject[""];
                        //temp.ShiftName = jobject[""];
                        //temp.ShiftNum = jobject[""];
                        //temp.TeamSet = jobject[""];
                        //temp.Start = jobject[""];
                        //temp.End = jobject[""];
                        //temp.OutputLengthStart                =jobject[""];
                        temp.CurrentShiftLength = jobject.整车产量Kg;
                        //temp.CurrentLength = jobject[""];
                        //temp.FixLength = jobject[""];
                        //temp.RemainLength = jobject[""];
                        //temp.TotalLength = jobject[""];
                        temp.DeviceState = jobject.设备状态;
                        int DeviceState = jobject.设备状态;
                        int WorkState = jobject.工作状态;
                        temp.StateCode = GetStatecode(DeviceState, WorkState);
                        //temp.TotalLengthCal                   =jobject[""];
                        //temp.ProductionDispatchId             =jobject[""];

                        //temp.RunTimes                         =jobject[""];
                        //temp.EfcRun                           =jobject[""];
                        temp.CommunicateErrorCnt = 0;

                        //分组数据
                        List<分组数据> GroupDatas = jobject.分组数据;
                        if (GroupDatas != null)
                        {
                            foreach (分组数据 GroupData in GroupDatas)
                            {
                                var GroupTemp = dbContext.LtGroupShiftReports.Where(t => t.MachineDocumentId == dev_guid && t.Num == GroupData.组号).Select(t => t).First();


                                if (GroupTemp != null)
                                {
                                  //  GroupTemp.BeginTimeFromUpComputer = GroupData.班次开始时间;
                                    GroupTemp.UpdateTimeFromUpComputer = DateTime.Now;
                                    GroupTemp.ActualYarnWeight = GroupData.组产量Kg;
                                    GroupTemp.Num = GroupData.组号;
                                    GroupTemp.EfcRun = GroupData.组效率;
                                    GroupTemp.End = GroupData.End;
                                }
                                else
                                {
                                    List<GroupDB> GroupNew = new List<GroupDB>();
                                    GroupNew.Add(new GroupDB
                                    {
                                      //  BeginTimeFromUpComputer = GroupData.班次开始时间,
                                        UpdateTimeFromUpComputer = DateTime.Now,
                                        ActualYarnWeight = GroupData.组产量Kg,
                                        Num = GroupData.组号,
                                        EfcRun = GroupData.组效率,
                                        End = GroupData.End
                                    });
                                }
                            }
                        }

                        //机台单锭数据
                        List<机台单锭数据> PositionDatas = jobject.机台单锭数据;
                        if (PositionDatas != null)
                        {
                            var PositionRttemps = dbContext.LtPositionRttemps.Where(t => t.MachineDocumentId == dev_guid).Select(t => t);
                            foreach (机台单锭数据 PositionData in PositionDatas)
                            {
                                var PositionRttemp = PositionRttemps.Where(t => t.Num == PositionData.锭号).Select(t => t).First();
                                //当没有该锭数据，就插入一条
                                if (PositionRttemp == null)
                                {
                                    List<LtPositionRttemp> PositonNew = new List<LtPositionRttemp>();
                                    PositonNew.Add(new LtPositionRttemp
                                    {
                                        MachineDocumentId = dev_guid,
                                        Num = PositionData.锭号
                                        //补全班次数据，例如tsid、teamset等
                                    });
                                }
                                //更新该锭数据
                                else
                                {
                                    PositionRttemp.YarnFaultCuts = PositionData.切疵次数;
                                    PositionRttemp.YarnFaultCutsPer10Km = (int?)PositionData.切疵次数10km;
                                    PositionRttemp.ConeCuts = (int?)PositionData.切纱次数筒纱;
                                    PositionRttemp.BobbinCuts = (int?)PositionData.切纱次数管纱;
                                    PositionRttemp.YarnWeight = PositionData.单锭产量Kg;
                                    PositionRttemp.SpoolSucceedCnt = PositionData.单锭小车络筒成功数;
                                    PositionRttemp.SigleWeight = PositionData.当前筒纱重量;
                                    PositionRttemp.SigleLength = PositionData.当前筒纱长度;
                                    PositionRttemp.TiedTimeAvg = PositionData.打结平均时间;
                                    PositionRttemp.TiedCnt = (int?)PositionData.打结总数;
                                    PositionRttemp.TiedTime = PositionData.打结总时间;
                                    PositionRttemp.SpliceCnt = PositionData.捻接循环次数;
                                    PositionRttemp.JointCnt = PositionData.接头数;
                                    PositionRttemp.JointCntPer10Km = (int?)PositionData.接头数10km;
                                    PositionRttemp.ConeJointCnt = (int?)PositionData.接头数筒纱;
                                    PositionRttemp.BobbinChanges = PositionData.更换管纱数;
                                    PositionRttemp.ConeCnt = PositionData.生产筒纱数;
                                    PositionRttemp.WorkTime = PositionData.络纱时间;
                                    PositionRttemp.DoffAvgTime = PositionData.落纱平均时间;
                                    PositionRttemp.DoffCnt = (int?)PositionData.落纱总数;
                                    PositionRttemp.DoffTime = PositionData.落纱总时间;
                                    PositionRttemp.AlarmTimeAvg = PositionData.红灯平均时间;
                                    PositionRttemp.AlarmCnt = (int?)PositionData.红灯总数;
                                    PositionRttemp.AlarmTime = PositionData.红灯总时间;
                                    PositionRttemp.FaultTimeAvg = PositionData.故障平均时间;
                                    PositionRttemp.FaultCnt = (int?)PositionData.故障总数;
                                    PositionRttemp.FaultTime = PositionData.故障总时间;
                                    PositionRttemp.MechanicalEfc = PositionData.单锭机械效率;
                                    PositionRttemp.ProductionEfc = PositionData.单锭生产效率;
                                    PositionRttemp.TechnicalAlarmTimeAvg = PositionData.工艺报警平均时间;
                                    PositionRttemp.TechnicalAlarmCnt = (int?)PositionData.工艺报警总数;
                                    PositionRttemp.TechnicalAlarmTime = PositionData.工艺报警总时间;
                                    PositionRttemp.LastModificationTime = DateTime.Now;
                                }

                                //当班次号发生变化，则换班
                                if (ChangeClassFlag == 1)
                                {
                                    List<LtPositionProductionReport> PositonShift = new List<LtPositionProductionReport>();
                                    PositonShift.Add(new LtPositionProductionReport
                                    {
                                        //Id= PositionRttemp.Id,
                                        Num = PositionRttemp.Num,
                                        //补全班次数据，例如tsid、teamset等

                                        YarnFaultCuts = PositionRttemp.YarnFaultCuts,
                                        YarnFaultCutsPer10Km = PositionRttemp.YarnFaultCutsPer10Km,
                                        ConeCuts = PositionRttemp.ConeCuts,
                                        BobbinCuts = PositionRttemp.BobbinCuts,
                                        YarnWeight = PositionRttemp.YarnWeight,
                                        SpoolSucceedCnt = PositionRttemp.SpoolSucceedCnt,
                                        SigleWeight = PositionRttemp.SigleWeight,
                                        SigleLength = PositionRttemp.SigleLength,
                                        TiedTimeAvg = PositionRttemp.TiedTimeAvg,
                                        TiedCnt = PositionRttemp.TiedCnt,
                                        TiedTime = PositionRttemp.TiedTime,
                                        SpliceCnt = PositionRttemp.SpliceCnt,
                                        JointCnt = PositionRttemp.JointCnt,
                                        JointCntPer10Km = PositionRttemp.JointCntPer10Km,
                                        ConeJointCnt = PositionRttemp.ConeJointCnt,
                                        BobbinChanges = PositionRttemp.BobbinChanges,
                                        ConeCnt = PositionRttemp.ConeCnt,
                                        WorkTime = PositionRttemp.WorkTime,
                                        DoffAvgTime = PositionRttemp.DoffAvgTime,
                                        DoffCnt = PositionRttemp.DoffCnt,
                                        DoffTime = PositionRttemp.DoffTime,
                                        AlarmTimeAvg = PositionRttemp.AlarmTimeAvg,
                                        AlarmCnt = PositionRttemp.AlarmCnt,
                                        AlarmTime = PositionRttemp.AlarmTime,
                                        FaultTimeAvg = PositionRttemp.FaultTimeAvg,
                                        FaultCnt = PositionRttemp.FaultCnt,
                                        FaultTime = PositionRttemp.FaultTime,
                                        MechanicalEfc = PositionRttemp.MechanicalEfc,
                                        ProductionEfc = PositionRttemp.ProductionEfc,
                                        TechnicalAlarmTimeAvg = PositionRttemp.TechnicalAlarmTimeAvg,
                                        TechnicalAlarmCnt = PositionRttemp.TechnicalAlarmCnt,
                                        TechnicalAlarmTime = PositionRttemp.TechnicalAlarmTime
                                    });
                                }

                            }
                        }
                        dbContext.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception exception)
            {
                _log.ErrorFormat("数据插入异常IP={0}", exception.Message);
                //if (con.State == ConnectionState.Closed)
                //{
                //    try
                //    {
                //        con.Open();
                //        _log.ErrorFormat("数据库重连成功}", Array.Empty<object>());
                //    }
                //    catch (Exception exception2)
                //    {
                //        _log.ErrorFormat("数据库重连异常IP={0}", exception2.Message);
                //    }
                //}
                Process[] processes = Process.GetProcessesByName("mqttclientForm");
                foreach (Process p in processes)
                {
                    try
                    {
                        p.Kill();
                        p.Close();
                    }
                    catch (Exception ex)
                    {
                        _log.Error("进程停止失败" + ex.Message);
                    }
                }
                return false;
            }
        }

        public static bool ini()
        {
            try
            {
                Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()//等级
               .CreateLogger();

                var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

                var configuration = builder.Build();

                gVs.connectString = configuration.GetConnectionString("localDatabase");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ini初始化失败");
                return false;
            }
            return true;
        }

        public int GetStatecode(int devicestate, int workstate)
        {
            try
            {
                int statecode;
                if (devicestate == 2001)
                    statecode = 1;
                else
                    if (devicestate == 2002)
                {
                    if (workstate == 3001)
                        statecode = 2;
                    else if (workstate == 3002)
                        statecode = 4;
                    else
                        statecode = 5;
                }
                else
                    statecode = 5;

                return statecode;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "statecode解析失败");
                return 5;
            }
        }
    }
}