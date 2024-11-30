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
    public class CheckStockService
    {
        private BinbalanceDbContext dbBin;
        public CheckStockService()
        {
            dbBin = new BinbalanceDbContext();
        }

        public  CheckStockService(BinbalanceDbContext dbBin)
        {
            this.dbBin = dbBin;
        }

        public List<ListmodelCheckStock> CheckStock(Listmodelserch_GI getGi_no)
        {
            try
            {
                var result = new List<ListmodelCheckStock>();
                var outboundDbContext = new OutboundDbContext();
                var Gi_no = getGi_no.Goodsissue_no;
                // Parse the GUID once
                var targetGuid = Guid.Parse("24F36784-B6A8-4FA6-BD33-A94E9D516672");

                // Query to get the BinBalance records with the conditions
                var binBalanceQuery = dbBin.wm_BinBalance
                    .Where(bin => bin.BinBalance_QtyReserve > 0
                                  && bin.Location_Id != "WH7TOASRS"
                                  && !bin.Location_Name.StartsWith("RC")
                                  && !bin.Location_Name.StartsWith("STG")
                                  && !bin.Location_Name.StartsWith("KASCO_BLOCK_STOCK")
                                  && bin.Product_Id != "3000000")
                    .OrderBy(bin => bin.Location_Id)
                    .ToList();

                // Get the BinBalance_Index values from OutboundDbContext
                var outboundBinBalanceIndexes = outboundDbContext.im_GoodsIssueItemLocation
                    .Where(issue => issue.GoodsIssue_No == Gi_no)
                    .Select(issue => issue.BinBalance_Index)
                    .ToList();

                // Filter the BinBalance records to exclude those found in OutboundDbContext
                var filteredBinBalances = binBalanceQuery
                    .Where(bin => !outboundBinBalanceIndexes.Contains(bin.BinBalance_Index))
                    .ToList();

                // Map the filtered records to the result
                if (filteredBinBalances.Any())
                {
                    //var i = 0; // Start index from 0

                    foreach (var firstBin in filteredBinBalances)
                    {
                        var resultItem = new ListmodelCheckStock();
                        resultItem.Create_By = firstBin.Create_By;
                        resultItem.Cancel_Date = firstBin.Cancel_Date;
                        resultItem.Cancel_By = firstBin.Cancel_By;
                        resultItem.Update_Date = firstBin.Update_Date;
                        resultItem.Update_By = firstBin.Update_By;
                        resultItem.Location_Name = firstBin.Location_Name;
                        resultItem.BinBalance_QtyBal = firstBin.BinBalance_QtyBal;
                        resultItem.Tag_No = firstBin.Tag_No;
                        resultItem.GoodsReceive_No = firstBin.GoodsReceive_No;
                        resultItem.Product_Id = firstBin.Product_Id;
                        resultItem.Product_Name = firstBin.Product_Name;
                        resultItem.ProductConversion_Name = firstBin.ProductConversion_Name;
                        resultItem.Product_Lot = firstBin.Product_Lot;
                        resultItem.ItemStatus_Name = firstBin.ItemStatus_Name;
                        resultItem.BinBalance_QtyBegin = firstBin.BinBalance_QtyBegin;
                        resultItem.BinBalance_QtyReserve = firstBin.BinBalance_QtyReserve;
                        resultItem.ERP_Location = firstBin.ERP_Location;
                        resultItem.BinBalance_Index = firstBin.BinBalance_Index ?? Guid.Empty;
                        resultItem.GoodsReceiveItemLocation_Index = firstBin.GoodsReceiveItemLocation_Index ?? Guid.Empty;
                        resultItem.Tag_Index = firstBin.Tag_Index ?? Guid.Empty;

                        // Add to result list
                        result.Add(resultItem);
                        Console.WriteLine(result);
                            //i++;

                        // If there are more than 100 items, break out of the loop
                        //if (i >= 100) { break; }
                    }
                }

                return result.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        

    }
}
