using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceBusiness.Tote
{
    public class ListmodelLogArchiveWMS
    {
        public Guid ArchiveData_Index { get; set; }
        public string ArchiveData_Name { get; set; }
        public int? ArchiveData_Status { get; set; }
        public string ArchiveData_Table_Name { get; set; }
        public int? ArchiveData_Period { get; set; }
        public int? ArchiveData_BeforeCount { get; set; }
        public int? ArchiveData_Count { get; set; }
        public int? ArchiveData_Balance_Count { get; set; }
        public DateTime? ArchiveData_Min_Date { get; set; }
        public DateTime? ArchiveData_Start_Date { get; set; }
        public DateTime? ArchiveData_End_Date { get; set; }
        public string Remark { get; set; }

    }
    public class ListmodelLogArchiveTMS{
        public Guid ArchiveData_Index { get; set; }
        public string ArchiveData_Name { get; set; }
        public int? ArchiveData_Status { get; set; }
        public string ArchiveData_Table_Name { get; set; }
        public int? ArchiveData_Period { get; set; }
        public int? ArchiveData_BeforeCount { get; set; }
        public int? ArchiveData_Count { get; set; }
        public int? ArchiveData_Balance_Count { get; set; }
        public DateTime? ArchiveData_Min_Date { get; set; }
        public DateTime? ArchiveData_Start_Date { get; set; }
        public DateTime? ArchiveData_End_Date { get; set; }
        public string Message { get; set; }

    }
    public class ListmodelLogArchiveOMS
    {
        public Guid ArchiveData_Index { get; set; }
        public string ArchiveData_Name { get; set; }
        public int? ArchiveData_Status { get; set; }
        public string ArchiveData_Table_Name { get; set; }
        public int? ArchiveData_Period { get; set; }
        public int? ArchiveData_BeforeCount { get; set; }
        public int? ArchiveData_Count { get; set; }
        public int? ArchiveData_Balance_Count { get; set; }
        public DateTime? ArchiveData_Min_Date { get; set; }
        public DateTime? ArchiveData_Start_Date { get; set; }
        public DateTime? ArchiveData_End_Date { get; set; }
        public string Message { get; set; }
    }
    public class ListmodelLogArchive_SearchDate
    {
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        //public int? export { get; set; }
    }
}
