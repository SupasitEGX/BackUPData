using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceBusiness.Tote
{
    public class ListmodelCheckTag_TagItem
    {
        public Guid? TagItem_Index { get; set; }
        public Guid? Tag_Index { get; set; }
        public string Tag_No { get; set; }
        public Guid? GoodsReceive_Index { get; set; }
        public Guid? GoodsReceiveItem_Index { get; set; }
        public Guid? Process_Index { get; set; }
        public Guid? Product_Index { get; set; }
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_SecondName { get; set; }
        public string Product_ThirdName { get; set; }
        public string Product_Lot { get; set; }
        public Guid? ItemStatus_Index { get; set; }
        public string ItemStatus_Id { get; set; }
        public string ItemStatus_Name { get; set; }
        public Guid? Suggest_Location_Index { get; set; }
        public string Suggest_Location_Id { get; set; }
        public string Suggest_Location_Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public Guid? ProductConversion_Index { get; set; }
        public string ProductConversion_Id { get; set; }
        public string ProductConversion_Name { get; set; }
        public DateTime? MFG_Date { get; set; }
        public DateTime? EXP_Date { get; set; }
        public string TagRef_No1 { get; set; }
        public string TagRef_No2 { get; set; }
        public string TagRef_No3 { get; set; }
        public string TagRef_No4 { get; set; }
        public string TagRef_No5 { get; set; }
        public int? Tag_Status { get; set; }
        public string UDF_1 { get; set; }
        public string UDF_2 { get; set; }
        public string UDF_3 { get; set; }
        public string UDF_4 { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public Guid? Weight_Index { get; set; }
        public string Weight_Id { get; set; }
        public string Weight_Name { get; set; }
        public decimal? WeightRatio { get; set; }
        public decimal? UnitGrsWeight { get; set; }
        public decimal? GrsWeight { get; set; }
        public Guid? GrsWeight_Index { get; set; }
        public string GrsWeight_Id { get; set; }
        public string GrsWeight_Name { get; set; }
        public decimal? GrsWeightRatio { get; set; }
        public decimal? UnitWidth { get; set; }
        public decimal? Width { get; set; }
        public Guid? Width_Index { get; set; }
        public string Width_Id { get; set; }
        public string Width_Name { get; set; }
        public decimal? WidthRatio { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? Length { get; set; }
        public Guid? Length_Index { get; set; }
        public string Length_Id { get; set; }
        public string Length_Name { get; set; }
        public decimal? LengthRatio { get; set; }
        public decimal? UnitHeight { get; set; }
        public decimal? Height { get; set; }
        public Guid? Height_Index { get; set; }
        public string Height_Id { get; set; }
        public string Height_Name { get; set; }
        public decimal? HeightRatio { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? Volume { get; set; }
        public Guid? Volume_Index { get; set; }
        public string Volume_Id { get; set; }
        public string Volume_Name { get; set; }
        public decimal? VolumeRatio { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public Guid? Currency_Index { get; set; }
        public string Currency_Id { get; set; }
        public string Currency_Name { get; set; }
        public string Ref_Code1 { get; set; }
        public string Ref_Code2 { get; set; }
        public string Ref_Code3 { get; set; }
        public string Ref_Code4 { get; set; }
        public string Ref_Code5 { get; set; }
        public string UDF_5 { get; set; }
        public string Create_By { get; set; }
        public DateTime? Create_Date { get; set; }
        public string Update_By { get; set; }
        public DateTime? Update_Date { get; set; }
        public string Cancel_By { get; set; }
        public DateTime? Cancel_Date { get; set; }
        public string UserAssign { get; set; }
        public string ERP_Location { get; set; }
        public decimal? IsScanDockToStaging { get; set; }
        public Guid? Location_Index { get; set; }
        public string Location_Id { get; set; }
        public string Location_Name { get; set; }
        public string UpdateDockToStaging_By { get; set; }
        public DateTime? UpdateDockToStaging_Date { get; set; }
        public decimal? IsPallet_Inspection { get; set; }
        public string UpdatePallet_Inspection_By { get; set; }
        public DateTime? UpdatePallet_Inspection_Date { get; set; }
        public string IsPallet_Inspection_Location_Name { get; set; }
        public string IsPallet_Inspection_Location_Id { get; set; }
        public Guid? IsPallet_Inspection_Location_Index { get; set; }

    }
    public class ListmodelCheckTag_GoodsReceiveItemLocation
    {
        public string Tag_No { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }
        public DateTime? Putaway_Date { get; set; }
    }
    public class ListmodelCheckTag_GoodsIssueItemLocation
    {
        public string Tag_No { get; set; }
        public string GoodsIssue_No { get; set; }
        public string Location_Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string ProductConversion_Name { get; set; }
    }
    public class ListmodelCheckTag_TaskItem
    {
        public string Picking_Status { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }
    }

    public class ListmodelCheckTag_TagOutItem
    {
        public string TagOut_Status { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }

    }
    public class ListmodelCheckTag_z_wm_BinCardReserve_GINOTCOMFIRM
    {
        public decimal? BinCardReserve_Status { get; set; }
        public decimal? BinCardReserve_QtyBal { get; set; }
    }
    public class ListmodelCheckTag_wm_BinCardReserve
    {
        public decimal? BinCardReserve_Status { get; set; }
        public decimal? BinCardReserve_QtyBal { get; set; }
    }
    public class ListmodelCheckTag_GoodsTransfer
    {
        public decimal DocumentStatus { get; set; }
        public decimal ItemDocumentStatus { get; set; }
        public string GoodsTransferNo { get; set; }
        public string DocumentTypeName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string TagNo { get; set; }
        public string TagNoTo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public decimal TotalQty { get; set; }
        public string ProductConversionName { get; set; }
        public string LocationName { get; set; }
        public string LocationNameTo { get; set; }
        public string ItemStatusName { get; set; }
        public string ItemStatusNameTo { get; set; }
        public string ERPLocation { get; set; }
        public string ERPLocationTo { get; set; }
        public decimal GoodsReceiveItemLocationIndex { get; set; }
        public decimal GoodsTransferItemIndex { get; set; }
	
    }
    public class ListmodelCheckTag_Binbalance
    {
       public string Create_By { get; set; }
       public DateTime? Cancel_Date                        {get;set;}
       public string Cancel_By                             {get;set;}
       public DateTime?  Update_Date                       {get;set;}
       public string Update_By                             {get;set;}
       public string Location_Name                         {get;set;}
       public decimal? BinBalance_QtyBal                   {get;set;}
       public string Tag_No                                {get;set;}
       public string GoodsReceive_No                       {get;set;}
       public string Product_Id                {get;set;}
       public string Product_Name              {get;set;}
       public string ProductConversion_Name    {get;set;}
       public string Product_Lot               {get;set;}
       public string ItemStatus_Name { get;set;}
       public decimal? BinBalance_QtyBegin                  {get;set;}
       public decimal? BinBalance_QtyReserve               {get;set;}
       public string ERP_Location                          {get;set;}
       public Guid? BinBalance_Index                       {get;set;}
       public Guid? GoodsReceiveItemLocation_Index         {get;set;}
       public Guid? Tag_Index                              {get;set;}
    }
    public class ListmodelSendTag
    {
        public string Tag_no { get; set; }
        public Guid? Binbalacne_Index { get; set; }
    }

}



