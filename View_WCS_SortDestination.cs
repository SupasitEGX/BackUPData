using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OutboundDataAccess.Models
{

    public partial class View_WCS_SortDestination
    {
        [Key]
        public Guid Transaction_Index { get; set; }

        public string PalletID { get; set; }

        public string WaveNo { get; set; }

        public int TotalBox { get; set; }

        public int BoxNo { get; set; }

        public string QRCode { get; set; }

        public string SKU { get; set; }

        //public string Hotline { get; set; }

        public string MobileNumber { get; set; }

        public string BillID { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string BranchCode { get; set; }

        public string BranchName { get; set; }

        public string DNNumber { get; set; }

        public int Drop_seq { get; set; }

        public int Order_seq { get; set; }

        //public string BranchAddress3 { get; set; }

        //public string InvoiceNo { get; set; }

        //public short Status { get; set; }

        //public short? WCSErrorCode { get; set; }

        public DateTime UpdateDT { get; set; }

        public string UpdateBy { get; set; }

    }
}
