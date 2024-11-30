using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OutboundDataAccess.Models
{

    public partial class View_WCS_ChuteMonitor
    {
        [Key]
        public Guid Transaction_Index { get; set; }

        public string WaveNo { get; set; }

        public int Quantity { get; set; }

        public int ChuteNo { get; set; }

        public decimal? Target { get; set; }

        public decimal? Actual { get; set; }

        public decimal? CompletePercent { get; set; }

        public DateTime UpdateDT { get; set; }

        public string UpdateBy { get; set; }

    }
}
