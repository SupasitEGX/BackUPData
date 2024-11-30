using InboundDataAccess;
using InterfaceBusiness.AutoNumber;
using InterfaceBusiness.Libs;
using InterfaceDataAccess;
using InterfaceDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TransferDataAccess;

namespace InterfaceBusiness.Tote
{
    public class CheckToteService
    {
        private InterfaceDbContext db;
        public CheckToteService()
        {
            db = new InterfaceDbContext();
        }

        public CheckToteService(InterfaceDbContext db)
        {
            this.db = db;
        }

        #region Check_Tote

        public Listmodel Check_Tote()
        {
            try
            {
                int PC = 0, PNC = 0, NP = 0;
                Listmodel listmodel = new Listmodel();
                TBL_IF_WMS_WAVE iF_WMS_WAVE = db.TBL_IF_WMS_WAVE.FirstOrDefault(c => c.Status == 40);
                if (iF_WMS_WAVE == null)
                {
                    listmodel.resultIsUse = false;
                    listmodel.resultMsg = "ไม่พบ GI ที่กำลัง Wave อยู่";
                    return listmodel;
                }
                else {
                    listmodel.Gi_NO = iF_WMS_WAVE.WaveNo;

                    var tBL_IF_WMS_PTL_PICKINGs = db.TBL_IF_WMS_PTL_PICKING.Where(c => c.Status != 60 && c.WaveNo == iF_WMS_WAVE.WaveNo)
                                                                                    .GroupBy(c=> new {
                                                                                        c.ToteID,
                                                                                        c.Status })
                                                                                    .Select(c=> new {
                                                                                        c.Key.ToteID,
                                                                                        c.Key.Status}).ToList();
                    var PICKINGs = tBL_IF_WMS_PTL_PICKINGs.GroupBy(c =>
                                                         c.ToteID)
                                                     .Select(c => new
                                                     {
                                                         ToteID = c.Key,
                                                         status = string.Join(",", c.Select(x => x.Status))
                                                     }).ToList();
                    if (PICKINGs.Count() > 0)
                    {
                        listmodel.resultIsUse = true;
                        
                        listmodel.total = PICKINGs.Count();
                        foreach (var item in PICKINGs.OrderByDescending(c=> c.status).ThenBy(c=> c.ToteID))
                        {
                            incomplete_tote incomplete_Tote = new incomplete_tote();
                            incomplete_Tote.incomplete_tagout_no = item.ToteID;
                            if (item.status == "30")
                            {
                                incomplete_Tote.message = "ยังไม่ได้ทำการหยิบ";
                                NP = NP + 1;
                            }
                            else if (item.status == "50")
                            {
                                incomplete_Tote.message = "หยิบครบแล้ว";
                                PC = PC + 1;
                            }
                            else if (item.status == "60")
                            {
                                continue;
                            }
                            else {
                                incomplete_Tote.message = "ยังทำการหยิบไม่เสร็จ";
                                PNC = PNC + 1;
                            }
                            
                            listmodel.incomplete_tote.Add(incomplete_Tote);
                        }
                        listmodel.Pick_PC = PC;
                        listmodel.Pick_PNC = PNC;
                        listmodel.Pick_NP = NP;

                    }
                    else {
                        listmodel.resultIsUse = false;
                        listmodel.resultMsg = listmodel.Gi_NO + " Tote ถูกแสกน ครบแล้ว";
                        return listmodel;
                    }
                }
                

                return listmodel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        #endregion
    }
}
