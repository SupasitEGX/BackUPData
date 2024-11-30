using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OutboundDataAccess.Models
{

    public partial class View_WCS_SortPlan
    {
        [Key]
        public Guid Transaction_Index { get; set; }

        public DateTime Date { get; set; }

        public string WaveNo { get; set; }

        public int WaveNoOfTheDay { get; set; }

        public string BranchCode { get; set; }

        public decimal? Quantity { get; set; }

        public int ChuteNo { get; set; }

        public int Status { get; set; }

        public DateTime UpdateDT { get; set; }

        public string UpdateBy { get; set; }

    }
}
