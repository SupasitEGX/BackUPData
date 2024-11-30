using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterDataDataAccess.Models
{
    public class sy_LogArchiveData
    {
        [Key]
        public Guid ArchiveData_Index       { get; set; }
        public string ArchiveData_Name        { get; set; }
        public int? ArchiveData_Status      { get; set; }
        public string ArchiveData_Table_Name  { get; set; }
        public int? ArchiveData_Period { get; set; }
        public int? ArchiveData_BeforeCount { get; set; }
        public int? ArchiveData_Count       { get; set; }
        public int? ArchiveData_Balance_Count { get; set; }
        public DateTime? ArchiveData_Min_Date { get; set; }
        public DateTime? ArchiveData_Start_Date  { get; set; }
        public DateTime? ArchiveData_End_Date    { get; set; }
        public string Remark   { get; set; }
    }
    public class sy_LogArchiveDataOMS
    {
        [Key]
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
}
