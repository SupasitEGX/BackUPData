using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OutboundDataAccess.Models
{

    public partial class View_WCS_ASRSIssuing_BypassSorter
    {
        [Key]
        public Guid Transaction_Index { get; set; }

        public int OrderType { get; set; }

        public string WaveNo { get; set; }

        public int TotalLineNo { get; set; }

        public int LineNo { get; set; }

        public string PalletID { get; set; }

        public string Location { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public string SKU { get; set; }

        public int RobotGroup { get; set; }

        public decimal IssueQuantity { get; set; }

        public int IsFullPalletOut { get; set; }

        public int WCSErrorCode { get; set; }

        public string RouteID { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int DeliveryRnd { get; set; }

        public string IssueType { get; set; }

        public int WMSDestStation { get; set; }

        public string WCSTransactionID { get; set; }

        public DateTime UpdateDT { get; set; }

        public string UpdateBy { get; set; }

    }
}
