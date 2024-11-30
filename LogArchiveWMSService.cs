using InboundDataAccess;
using InterfaceBusiness.AutoNumber;
using InterfaceBusiness.Libs;
using BinbalanceDataAccess;
using InterfaceDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MasterDataAccess;
using Comone.Utils;
using System.Globalization;
using ClosedXML.Excel;
using System.IO;

namespace InterfaceBusiness.Tote
{
    public class LogArchiveWMSService
    {
        
        public dynamic LogArchive(ListmodelLogArchive_SearchDate Search)
        {
            try
            {
                var result = new List<ListmodelLogArchiveWMS>();
                var db = new MasterArWMSDbContext();
                //var search = new ListmodelLogArchive_SearchDate();

               
                var WMSArchiveData = db.sy_LogArchiveData.AsQueryable();
                
                if (!string.IsNullOrEmpty(Search.Start_Date) && !string.IsNullOrEmpty(Search.End_Date))
                {
                    string dateFormat = "yyyy-MM-dd";
                    DateTime startDate = DateTime.ParseExact(Search.Start_Date, dateFormat, new CultureInfo("en-US"));
                    DateTime endDate = DateTime.ParseExact(Search.End_Date, dateFormat, new CultureInfo("en-US"));
                    WMSArchiveData = WMSArchiveData.Where(c => c.ArchiveData_Start_Date >= startDate && c.ArchiveData_End_Date <= endDate); 
                    //return new { message = startDate, endDate};
                    // Map the filtered records to the result
                    if (WMSArchiveData.Any())
                    {
                        
                        foreach (var ar in WMSArchiveData)
                        {
                            var resultItem = new ListmodelLogArchiveWMS();

                            resultItem.ArchiveData_Index = ar.ArchiveData_Index;
                            resultItem.ArchiveData_Name = ar.ArchiveData_Name;
                            resultItem.ArchiveData_Status = ar.ArchiveData_Status;
                            resultItem.ArchiveData_Table_Name = ar.ArchiveData_Table_Name;
                            resultItem.ArchiveData_Period = ar.ArchiveData_Period;
                            resultItem.ArchiveData_BeforeCount = ar.ArchiveData_BeforeCount;
                            resultItem.ArchiveData_Count = ar.ArchiveData_Count;
                            resultItem.ArchiveData_Balance_Count = ar.ArchiveData_Balance_Count;
                            resultItem.ArchiveData_Min_Date = ar.ArchiveData_Min_Date;
                            resultItem.ArchiveData_Start_Date = ar.ArchiveData_Start_Date;
                            resultItem.ArchiveData_End_Date = ar.ArchiveData_End_Date;
                            resultItem.Remark = ar.Remark;

                            result.Add(resultItem);
                        }

                    }

                }
                else
                {
                    foreach (var ar in WMSArchiveData)
                    {
                        var resultItem = new ListmodelLogArchiveWMS();

                        resultItem.ArchiveData_Index = ar.ArchiveData_Index;
                        resultItem.ArchiveData_Name = ar.ArchiveData_Name;
                        resultItem.ArchiveData_Status = ar.ArchiveData_Status;
                        resultItem.ArchiveData_Table_Name = ar.ArchiveData_Table_Name;
                        resultItem.ArchiveData_Count = ar.ArchiveData_Count;
                        resultItem.ArchiveData_Start_Date = ar.ArchiveData_Start_Date;
                        resultItem.ArchiveData_End_Date = ar.ArchiveData_End_Date;
                        // Add to result list
                        result.Add(resultItem);

                    }
                }

                return result.Take(100).ToList();


            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}