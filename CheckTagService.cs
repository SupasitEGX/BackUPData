using InboundDataAccess;
using InterfaceBusiness.AutoNumber;
using InterfaceBusiness.Libs;
using BinbalanceDataAccess;
using InterfaceDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TransferDataAccess;
using OutboundDataAccess;

namespace InterfaceBusiness.Tote
{
    public class CheckTagService
    {
       
        public dynamic CheckTag_TagItem(ListmodelSendTag GetTag_No)
        {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var db = new InboundDbContext();
                var result = db.wm_TagItem
                    .Where(q => q.Tag_No == tag_no)
                    .Select(tq => new
                    {
                        TagItem_Index = tq.TagItem_Index,
                       Tag_Index = tq.Tag_Index,
                       Tag_No = tq.Tag_No,
                       GoodsReceive_Index = tq.GoodsReceive_Index,
                       GoodsReceiveItem_Index = tq.GoodsReceiveItem_Index,
                       Process_Index = tq.Process_Index,
                       Product_Index = tq.Product_Index,
                       Product_Id = tq.Product_Id,
                       Product_Name = tq.Product_Name,
                       Product_SecondName = tq.Product_SecondName,
                       Product_ThirdName = tq.Product_ThirdName,
                       Product_Lot = tq.Product_Lot,
                       ItemStatus_Index = tq.ItemStatus_Index,
                       ItemStatus_Id = tq.ItemStatus_Id,
                       ItemStatus_Name = tq.ItemStatus_Name,
                       Suggest_Location_Index = tq.Suggest_Location_Index,
                       Suggest_Location_Id = tq.Suggest_Location_Id,
                       Suggest_Location_Name = tq.Suggest_Location_Name,
                       Qty = Convert.ToDecimal(tq.Qty ?? 0),
                       Ratio = Convert.ToDecimal(tq.Ratio ?? 0),
                       TotalQty = Convert.ToDecimal(tq.TotalQty ?? 0),
                       ProductConversion_Index = tq.ProductConversion_Index,
                       ProductConversion_Id = tq.ProductConversion_Id,
                       ProductConversion_Name = tq.ProductConversion_Name,
                       MFG_Date = tq.MFG_Date,
                       EXP_Date = tq.EXP_Date,
                       TagRef_No1 = tq.TagRef_No1,
                       TagRef_No2 = tq.TagRef_No2,
                       TagRef_No3 = tq.TagRef_No3,
                       TagRef_No4 = tq.TagRef_No4,
                       TagRef_No5 = tq.TagRef_No5,
                       Tag_Status = tq.Tag_Status,
                       UDF_1 = tq.UDF_1,
                       UDF_2 = tq.UDF_2,
                       UDF_3 = tq.UDF_3,
                       UDF_4 = tq.UDF_4,
                       Weight = Convert.ToDecimal(tq.Weight ?? 0),
                       UnitWeight = Convert.ToDecimal(tq.UnitWeight ?? 0),
                       NetWeight = Convert.ToDecimal(tq.NetWeight ?? 0),
                       Weight_Index = tq.Weight_Index,
                       Weight_Id = tq.Weight_Id,
                       Weight_Name = tq.Weight_Name,
                       WeightRatio = Convert.ToDecimal(tq.WeightRatio ?? 0),
                       UnitGrsWeight = Convert.ToDecimal(tq.UnitGrsWeight ?? 0),
                       GrsWeight = Convert.ToDecimal(tq.GrsWeight ?? 0),
                       GrsWeight_Index = tq.GrsWeight_Index,
                       GrsWeight_Id = tq.GrsWeight_Id,
                       GrsWeight_Name = tq.GrsWeight_Name,
                       GrsWeightRatio = Convert.ToDecimal(tq.GrsWeightRatio ?? 0),
                       UnitWidth = Convert.ToDecimal(tq.UnitWidth ?? 0),
                       Width = Convert.ToDecimal(tq.Width ?? 0),
                       Width_Index = tq.Width_Index,
                       Width_Id = tq.Width_Id,
                       Width_Name = tq.Width_Name,
                       WidthRatio = Convert.ToDecimal(tq.WidthRatio ?? 0),
                       UnitLength = Convert.ToDecimal(tq.UnitLength ?? 0),
                       Length = Convert.ToDecimal(tq.Length ?? 0),
                       Length_Index = tq.Length_Index,
                       Length_Id = tq.Length_Id,
                       Length_Name = tq.Length_Name,
                       LengthRatio = Convert.ToDecimal(tq.LengthRatio ?? 0),
                       UnitHeight = Convert.ToDecimal(tq.UnitHeight ?? 0),
                       Height = Convert.ToDecimal(tq.Height ?? 0),
                       Height_Index = tq.Height_Index,
                       Height_Id = tq.Height_Id,
                       Height_Name = tq.Height_Name,
                       HeightRatio = Convert.ToDecimal(tq.HeightRatio ?? 0),
                       UnitVolume = Convert.ToDecimal(tq.UnitVolume ?? 0),
                       Volume = Convert.ToDecimal(tq.Volume ?? 0),
                       Volume_Index = tq.Volume_Index,
                       Volume_Id = tq.Volume_Id,
                       Volume_Name = tq.Volume_Name,
                       VolumeRatio = Convert.ToDecimal(tq.VolumeRatio ?? 0),
                       UnitPrice = Convert.ToDecimal(tq.UnitPrice ?? 0),
                       Price = Convert.ToDecimal(tq.Price ?? 0),
                       TotalPrice = Convert.ToDecimal(tq.TotalPrice ?? 0),
                       Currency_Index = tq.Currency_Index,
                       Currency_Id = tq.Currency_Id,
                       Currency_Name = tq.Currency_Name,
                       Ref_Code1 = tq.Ref_Code1,
                       Ref_Code2 = tq.Ref_Code2,
                       Ref_Code3 = tq.Ref_Code3,
                       Ref_Code4 = tq.Ref_Code4,
                       Ref_Code5 = tq.Ref_Code5,
                       UDF_5 = tq.UDF_5,
                       Create_By = tq.Create_By,
                       Create_Date = tq.Create_Date,
                       Update_By = tq.Update_By,
                       Update_Date = tq.Update_Date,
                       Cancel_By = tq.Cancel_By,
                       Cancel_Date = tq.Cancel_Date,
                       UserAssign = tq.UserAssign,
                       ERP_Location = tq.ERP_Location,
                       IsScanDockToStaging = Convert.ToDecimal(tq.IsScanDockToStaging ?? 0),
                       Location_Index = tq.Location_Index,
                       Location_Id = tq.Location_Id,
                       Location_Name = tq.Location_Name,
                       UpdateDockToStaging_By = tq.UpdateDockToStaging_By,
                       UpdateDockToStaging_Date = tq.UpdateDockToStaging_Date,
                       IsPallet_Inspection = Convert.ToDecimal(tq.IsPallet_Inspection ?? 0),
                       UpdatePallet_Inspection_By = tq.UpdatePallet_Inspection_By,
                       UpdatePallet_Inspection_Date = tq.UpdatePallet_Inspection_Date,
                       IsPallet_Inspection_Location_Name = tq.IsPallet_Inspection_Location_Name,
                       IsPallet_Inspection_Location_Id = tq.IsPallet_Inspection_Location_Id,
                       IsPallet_Inspection_Location_Index = tq.IsPallet_Inspection_Location_Index,
               
                    }).ToList();
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public dynamic CheckTag_BinBalance(ListmodelSendTag GetTag_No)
        {
            try
            {
                var result = new List<ListmodelCheckTag_Binbalance>();
                var db = new BinbalanceDbContext();
                var Query = db.wm_BinBalance.AsQueryable();
                string tag_no = GetTag_No.Tag_no;
                Query = Query.Where(q => q.Tag_No == tag_no);
                if (Query.Any())
                {
                    foreach (var q in Query)
                    {
                        ListmodelCheckTag_Binbalance resultItem = new ListmodelCheckTag_Binbalance();
                        resultItem.Create_By = q.Create_By;
                        resultItem.Cancel_Date                     = q.Cancel_Date                    ;
                        resultItem.Cancel_By                       = q.Cancel_By                      ;
                        resultItem.Update_Date                     = q.Update_Date                    ;
                        resultItem.Update_By                       = q.Update_By                      ;
                        resultItem.Location_Name                   = q.Location_Name                  ;
                        resultItem.BinBalance_QtyBal               = q.BinBalance_QtyBal              ;
                        resultItem.Tag_No                          = q.Tag_No                         ;
                        resultItem.GoodsReceive_No                 = q.GoodsReceive_No                ;
                        resultItem.Product_Id                      = q.Product_Id                     ;
                        resultItem.Product_Name                    = q.Product_Name                   ;
                        resultItem.ProductConversion_Name          = q.ProductConversion_Name         ;
                        resultItem.Product_Lot                     = q.Product_Lot                    ;
                        resultItem.ItemStatus_Name                 = q.ItemStatus_Name          ;
                        resultItem.BinBalance_QtyBegin             = q.BinBalance_QtyBegin            ;
                        resultItem.BinBalance_QtyReserve           = q.BinBalance_QtyReserve          ;
                        resultItem.ERP_Location                    = q.ERP_Location                   ;
                        resultItem.BinBalance_Index                = q.BinBalance_Index               ;
                        resultItem.GoodsReceiveItemLocation_Index  = q.GoodsReceiveItemLocation_Index ;
                        resultItem.Tag_Index                       = q.Tag_Index                      ;
                        result.Add(resultItem);
                    }
                }
                else
                {
                    return new { message = "No Data" };
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        
        public dynamic CheckTag_GoodsReceiveItemLocation(ListmodelSendTag GetTag_No)
        {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GRILConn = new InboundDbContext();
                var BinConn = new BinbalanceDbContext();
                var binBalanceIndexes = BinConn.wm_BinBalance
                .Where(bin => bin.Tag_No == tag_no)
                .Select(bin => bin.GoodsReceiveItemLocation_Index)
                .ToList();

                var result = GRILConn.IM_GoodsReceiveItemLocation
                .Where(gril => binBalanceIndexes.Contains(gril.GoodsReceiveItemLocation_Index))
                .GroupBy(gril => gril.Tag_No)
                .Select(grouped => new
                {
                    Tag_No = grouped.Key,
                    GRLQty = grouped.Sum(gril => gril.Qty ?? 0),
                    GRLTotalQty = grouped.Sum(gril => gril.TotalQty ?? 0),
                    MaxPutaway_Date = grouped.Max(gril => gril.Putaway_Date)
                })
                .ToList();

                //return new { message = "Test" };
                if (result.Any())
                    {
                        return result;
                    }
                    else
                    {
                        return new { message = "No Data" };
                    }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        public dynamic CheckTag_GoodsIssueItemLocation(ListmodelSendTag GetTag_No)
        {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GILConn = new OutboundDbContext();
                //var BinConn = new BinbalanceDbContext();
                /*var binBalanceIndexes = BinConn.wm_BinBalance
                .Where(bin => bin.Tag_No == tag_no)
                .Select(bin => bin.GoodsReceiveItemLocation_Index)
                .ToList();*/

                var result = GILConn.im_GoodsIssueItemLocation
                    .Where(issue => issue.Tag_No == tag_no)
                    .GroupBy(issue => new
                    {
                        issue.Tag_No,
                        issue.GoodsIssue_No,
                        issue.Location_Name,
                        issue.Product_Id,
                        issue.Product_Name,
                        issue.ProductConversion_Name
                    })
                    .Select(grouped => new
                    {
                        Tag_No = grouped.Key.Tag_No,
                        GoodsIssue_No = grouped.Key.GoodsIssue_No,
                        Location_Name = grouped.Key.Location_Name,
                        Product_Id = grouped.Key.Product_Id,
                        Product_Name = grouped.Key.Product_Name,
                        ProductConversion_Name = grouped.Key.ProductConversion_Name,
                        GIQty = grouped.Sum(x => x.Qty),
                        GITotalQty = grouped.Sum(x => x.TotalQty)
                    })
                    .OrderByDescending(queryResult => queryResult.GoodsIssue_No)
                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        public dynamic CheckTag_GoodsIssueItemLocationSQTY(ListmodelSendTag GetTag_No)
        {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GILConn = new OutboundDbContext();
                //var BinConn = new BinbalanceDbContext();
                /*var binBalanceIndexes = BinConn.wm_BinBalance
                .Where(bin => bin.Tag_No == tag_no)
                .Select(bin => bin.GoodsReceiveItemLocation_Index)
                .ToList();*/

                var result = GILConn.im_GoodsIssueItemLocation
                    .Where(issue => issue.Tag_No == tag_no)
                    .GroupBy(issue => new
                    {
                        issue.Tag_No,  
                    })
                    .Select(grouped => new
                    {
                        Tag_No = grouped.Key.Tag_No,
                        GIQty = grouped.Sum(x => x.Qty),
                        GITotalQty = grouped.Sum(x => x.TotalQty)
                    })
                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }


        }

        
         public dynamic CheckTag_TaskItem(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var db = new OutboundDbContext();
                //var Tiq = db.im_TaskItem;
                var GILq = db.im_GoodsIssueItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsIssueItemLocation_Index )
                .ToList();

                var result = db.im_TaskItem
                    .Where(tiq => GILq.Contains(tiq.Ref_DocumentItem_Index ?? Guid.Empty))
                    .GroupBy(tiq => new
                    {
                        tiq.Picking_Status,

                    })
                    .Select(grouped => new
                    {

                        Picking_Status = grouped.Key.Picking_Status,
                        TIQty = grouped.Sum(x => x.Qty),
                        TotalQty = grouped.Sum(x => x.TotalQty)
                    })
                    .OrderBy(queryResult => queryResult.Picking_Status)
                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }


        }

        
         public dynamic CheckTag_TagOutItem(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var db = new OutboundDbContext();
                //var Tiq = db.im_TaskItem;
                var GILq = db.im_GoodsIssueItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsIssueItemLocation_Index)
                .ToList();

                var result = db.wm_TagOutItem
                    .Where(toq => GILq.Contains(toq.GoodsIssueItemLocation_Index ?? Guid.Empty))
                    .GroupBy(toq => new
                    {
                        toq.TagOut_Status,
                        toq.Ref_Document_No
                    })
                    .Select(grouped => new
                    {

                        TagOut_Status = grouped.Key.TagOut_Status,
                        Qty = grouped.Sum(x => x.Qty),
                        TotTotalQtyalQty = grouped.Sum(x => x.TotalQty)
                    })
              
                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        
         public dynamic CheckTag_BinCardReserve_GINOTCOMFIRM(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GILdb = new OutboundDbContext();
                var Bindb = new BinbalanceDbContext();
                //var Tiq = db.im_TaskItem;
                var GILq = GILdb.im_GoodsIssueItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsIssueItemLocation_Index)
                .ToList();

                var result = Bindb.z_wm_BinCardReserve_GINOTCOMFIRM
                    .Where(bincq => GILq.Contains(bincq.Ref_DocumentItem_Index ?? Guid.Empty))
                    .GroupBy(bincq => new
                    {
                        bincq.BinCardReserve_Status,
                    })
                    .Select(grouped => new
                    {

                        BinCardReserve_Status = grouped.Key.BinCardReserve_Status,
                        BinCardReserve_QtyBal = grouped.Sum(x => x.BinCardReserve_QtyBal),

                    })

                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
         public dynamic CheckTag_BinCardReserve(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GILdb = new OutboundDbContext();
                var Bindb = new BinbalanceDbContext();
                //var Tiq = db.im_TaskItem;
                var GILq = GILdb.im_GoodsIssueItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsIssueItemLocation_Index)
                .ToList();

                var result = Bindb.wm_BinCardReserve
                    .Where(bincq => GILq.Contains(bincq.Ref_DocumentItem_Index ?? Guid.Empty))
                    .GroupBy(bincq => new
                    {
                        bincq.BinCardReserve_Status
                    })
                    .Select(grouped => new
                    {

                        BinCardReserve_Status = grouped.Key.BinCardReserve_Status,
                        BinCardReserve_QtyBal = grouped.Sum(x => x.BinCardReserve_QtyBal),

                    })

                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
    
         public dynamic CheckTag_BinBalanceGI(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var OBdb = new OutboundDbContext();
                var Bindb = new BinbalanceDbContext();
                //var Tiq = db.im_TaskItem;
                var GILq = OBdb.im_GoodsIssueItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsIssueItemLocation_Index)
                .ToList();

                var Tiq = OBdb.im_TaskItem
                    .Where(q => GILq.Contains(q.Ref_DocumentItem_Index ?? Guid.Empty))
                    .Select(q => q.BinBalance_Index_New)
                    .ToList();

                var result = Bindb.wm_BinBalance
                    .Where(binq => Tiq.Contains(binq.BinBalance_Index ?? Guid.Empty))
                    .GroupBy(binq => new
                    { 
                        binq.Location_Name,
                    })
                    .Select(grouped => new
                    {

                        Location_Name = grouped.Key.Location_Name,
                        BinBalance_QtyBal = grouped.Sum(s => s.BinBalance_QtyBal),
                        BinBalance_QtyReserve = grouped.Sum(s => s.BinBalance_QtyReserve)
                    })

                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
         public dynamic CheckTag_BinBalanceGR(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var GRdb = new InboundDbContext();
                var Bindb = new BinbalanceDbContext();
                //var Tiq = db.im_TaskItem;
                var GRq = GRdb.IM_GoodsReceiveItemLocation
                .Where(q => q.Tag_No == tag_no)
                .Select(q => q.GoodsReceiveItemLocation_Index)
                .ToList();

                var result = Bindb.wm_BinBalance
                    .Where(binq => GRq.Contains(binq.GoodsReceiveItemLocation_Index ?? Guid.Empty))
                    .GroupBy(binq => new
                    {
                        binq.Tag_No,
                        binq.Location_Name,
                        binq.ERP_Location
                    })
                    .Select(grouped => new
                    {

                        Tag_No = grouped.Key.Tag_No,
                        Location_Name = grouped.Key.Location_Name,
                        BinBalance_QtyBal = grouped.Sum(s => s.BinBalance_QtyBal),
                        BinBalance_QtyReserve = grouped.Sum(s => s.BinBalance_QtyReserve),
                        ERP_Location = grouped.Key.ERP_Location,
                        
                    })

                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
         public dynamic CheckTag_GoodsTransferItemWT(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var db = new TransferDbContext();

                var result = db.im_GoodsTransferItem
                    .Where(GTFI => GTFI.Tag_No == tag_no && GTFI.Document_Status != -1)
                    .Join(db.im_GoodsTransfer,
                        GTFI => GTFI.GoodsTransfer_Index,
                        GTF => GTF.GoodsTransfer_Index,
                        (GTFI, GTF)=> new
                        {
                           GTF.Document_Status,
                           Item_Document_Status = GTFI.Document_Status,
                           GTF.GoodsTransfer_No,
                           GTF.DocumentType_Name,
                           GTFI.Create_Date,
                           GTFI.Create_By,
                           GTFI.Tag_No,
                           GTFI.Tag_No_To,
                           GTFI.Product_Id,
                           GTFI.Product_Name,
                           GTFI.Qty,
                           GTFI.TotalQty,
                           GTFI.ProductConversion_Name,
                           GTFI.Location_Name,
                           GTFI.Location_Name_To,
                           GTFI.ItemStatus_Name,
                           GTFI.ItemStatus_Name_To,
                           GTFI.ERP_Location,
                           GTFI.ERP_Location_To,
                           GTFI.GoodsReceiveItemLocation_Index,
                           GTFI.GoodsTransferItem_Index
                        }

                    )
                    .OrderBy(GTF =>GTF.Create_Date)
                  

                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
         public dynamic CheckTag_GoodsTransferItemWGITL(ListmodelSendTag GetTag_No)
         {
            try
            {
                var tag_no = GetTag_No.Tag_no;
                var db = new TransferDbContext();
                var Bindb = new BinbalanceDbContext();
                var Binq = Bindb.wm_BinBalance
                    .Where(q => q.Tag_No == tag_no)
                    .Select(q => q.GoodsReceiveItemLocation_Index).ToList();

                var result = db.im_GoodsTransferItem
                    .Where(GTFI => GTFI.Document_Status != -1 && Binq.Contains(GTFI.GoodsReceiveItemLocation_Index))
                    .Join(db.im_GoodsTransfer,
                        GTFI => GTFI.GoodsTransfer_Index,
                        GTF => GTF.GoodsTransfer_Index,
                        (GTFI, GTF) => new
                        {
                            GTF.Document_Status,
                            Item_Document_Status = GTFI.Document_Status,
                            GTF.GoodsTransfer_No,
                            GTF.DocumentType_Name,
                            GTFI.Create_Date,
                            GTFI.Create_By,
                            GTFI.Tag_No,
                            GTFI.Tag_No_To,
                            GTFI.Product_Id,
                            GTFI.Product_Name,
                            GTFI.Qty,
                            GTFI.TotalQty,
                            GTFI.ProductConversion_Name,
                            GTFI.Location_Name,
                            GTFI.Location_Name_To,
                            GTFI.ItemStatus_Name,
                            GTFI.ItemStatus_Name_To,
                            GTFI.ERP_Location,
                            GTFI.ERP_Location_To,
                            GTFI.GoodsReceiveItemLocation_Index,
                            GTFI.GoodsTransferItem_Index
                        }

                    )
                    .OrderBy(GTF => GTF.Create_Date)//.ThenBy(GTF => GTF.Product_Id)
                    .ToList();

                //return new { message = "Test" };
                if (result.Any())
                {
                    return result;
                }
                else
                {
                    return new { message = "No Data" };
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public dynamic CheckTag_CutStock(ListmodelSendTag getData)
        {
            try
            {
                var tag_no = getData.Tag_no;

                //return new { message = "Check", tag_no, BinIndex };
                if (!string.IsNullOrEmpty(tag_no))
                {

                    var db = new BinbalanceDbContext();
                    var Binindex = db.wm_BinBalance
                        .Where(q => q.Tag_No == tag_no)
                        .Select(q => q.BinBalance_Index)
                        .ToList();
                    var BinUpdate = db.wm_BinBalance
                        .Where(q => Binindex.Contains( q.BinBalance_Index) && q.Tag_No == tag_no);

                    if (BinUpdate.Any())
                    {
                        foreach (var bin in BinUpdate)
                        {
                            bin.Location_Id = "WH7TOASRS";
                            bin.Location_Name = "WH7TOASRS";
                            bin.Location_Index = Guid.Parse("DF3D2410-FCBD-4C82-9F2E-65EE51A83F51");
                        }
                        db.SaveChanges();
                        return new { tag_no, Binindex, message = "Update Success", };
                    }
                    else
                    {
                        return new { message = "No records found to update", tag_no, Binindex };
                    }
                }
                else
                {
                    return new { message = "No input data", tag_no };
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       }
}
