using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OutboundDataAccess.Models
{
   
    public partial class im_GoodsIssueItem
    {
        [Key]
        public Guid GoodsIssueItem_Index { get; set; }
        public Guid GoodsIssue_Index { get; set; }
        public Guid Product_Index { get; set; }
        [Required]
        [StringLength(50)]
        public string Product_Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Product_Name { get; set; }
        [StringLength(200)]
        public string Product_SecondName { get; set; }
        [StringLength(200)]
        public string Product_ThirdName { get; set; }
        [StringLength(50)]
        public string Product_Lot { get; set; }
        public Guid? ItemStatus_Index { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemStatus_Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ItemStatus_Name { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? QtyPlan { get; set; }
        [Column(TypeName = "numeric")]
        public decimal Qty { get; set; }
        [Column(TypeName = "numeric")]
        public decimal Ratio { get; set; }
        [Column(TypeName = "numeric")]
        public decimal TotalQty { get; set; }
        public Guid ProductConversion_Index { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductConversion_Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductConversion_Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MFG_Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EXP_Date { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? UnitWeight { get; set; }
        [Column(TypeName = "numeric")]
        public decimal Weight { get; set; }
        [Column(TypeName = "numeric")]
        public decimal UnitWidth { get; set; }
        [Column(TypeName = "numeric")]
        public decimal UnitLength { get; set; }
        [Column(TypeName = "numeric")]
        public decimal UnitHeight { get; set; }
        [Column(TypeName = "numeric")]
        public decimal UnitVolume { get; set; }
        [Column(TypeName = "numeric")]
        public decimal Volume { get; set; }
        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }
        [StringLength(200)]
        public string DocumentRef_No1 { get; set; }
        [StringLength(200)]
        public string DocumentRef_No2 { get; set; }
        [StringLength(200)]
        public string DocumentRef_No3 { get; set; }
        [StringLength(200)]
        public string DocumentRef_No4 { get; set; }
        [StringLength(200)]
        public string DocumentRef_No5 { get; set; }
        public int? Document_Status { get; set; }
        [StringLength(200)]
        public string UDF_1 { get; set; }
        [StringLength(200)]
        public string UDF_2 { get; set; }
        [StringLength(200)]
        public string UDF_3 { get; set; }
        [StringLength(200)]
        public string UDF_4 { get; set; }
        [StringLength(200)]
        public string UDF_5 { get; set; }
        public Guid? Ref_Process_Index { get; set; }
        [StringLength(200)]
        public string Ref_Document_No { get; set; }
        [StringLength(200)]
        public string Ref_Document_LineNum { get; set; }
        public Guid? Ref_Document_Index { get; set; }
        public Guid? Ref_DocumentItem_Index { get; set; }
        public Guid GoodsReceiveItem_Index { get; set; }
        [StringLength(200)]
        public string Create_By { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_Date { get; set; }
        [StringLength(200)]
        public string Update_By { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Update_Date { get; set; }
        [StringLength(200)]
        public string Cancel_By { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Cancel_Date { get; set; }
        public int? Cancel_Status { get; set; }
        [StringLength(200)]
        public string GoodsIssue_No { get; set; }
        public virtual im_GoodsIssue im_GoodsIssue { get; set; }
    }
}
