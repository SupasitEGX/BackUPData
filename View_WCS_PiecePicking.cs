using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OutboundDataAccess.Models
{

    public partial class View_WCS_PiecePicking
    {

        [Key]
        public Guid Transaction_Index { get; set; }

        public string ToteID { get; set; }

        public int TotalToteLineNo { get; set; }

        public int ToteLineNo { get; set; }

        public int CarouselPick { get; set; }

        public int FlowRackPick { get; set; }

        public int OrderType { get; set; }

        public string WaveNo { get; set; }

        public string Location { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public string SKU { get; set; }

        public string LotNo { get; set; }

        public DateTime EXPDate { get; set; }

        public string UOM { get; set; }

        public decimal IssueQuantity { get; set; }

        public int PickedQuantity { get; set; }

        public int WCSErrorCode { get; set; }

        public DateTime UpdateDT { get; set; }

        public string UpdateBy { get; set; }

    }
}
