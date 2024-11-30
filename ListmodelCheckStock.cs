using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceBusiness.Tote
{
    public class ListmodelCheckStock
    {
        public string Create_By { get; set; }
        public DateTime? Cancel_Date                    { get; set; }
        public string Cancel_By                      { get; set; }
        public DateTime? Update_Date                    { get; set; }
        public string Update_By                      { get; set; }
        public string Location_Name                  { get; set; }
        public decimal? BinBalance_QtyBal              { get; set; }
        public string Tag_No                         { get; set; }
        public string GoodsReceive_No                { get; set; }
        public string Product_Id                     { get; set; }
        public string Product_Name                   { get; set; }
        public string ProductConversion_Name         { get; set; }
        public string Product_Lot                    { get; set; }
        public string ItemStatus_Name                { get; set; }
        public decimal? BinBalance_QtyBegin            { get; set; }
        public decimal? BinBalance_QtyReserve          { get; set; }
        public string ERP_Location                   { get; set; }
        public Guid BinBalance_Index               { get; set; }
        public Guid GoodsReceiveItemLocation_Index { get; set; }
        public Guid Tag_Index { get; set; }
    }
    public class Listmodelserch_GI
    {
        public string Goodsissue_no { get; set; }
    }
}
