using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.PalletInspection;
using InterfaceDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterfaceAPI.Controllers
{
    [Route("api/PalletInspection")]
    [ApiController]
    public class PalletInspectionController : Controller
    {

        #region TBL_IF_WMS_PALLET_INSPECTION

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_INSPECTION_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION_PUTAWAY")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION_PUTAWAY([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_INSPECTION_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION_PUTAWAY(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CHECK_REWORK")]
        public IActionResult CHECK_REWORK([FromBody]JObject body)
        {
            try
            {
                var service = new PalletInspectionService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_INSPECTION_MODEL>(body.ToString());
                var result = service.CHECK_REWORK(Models);
                var response = JsonConvert.SerializeObject(result);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("REWORK_CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION")]
        public IActionResult REWORK_CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- REWORK CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_INSPECTION_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.REWORK_CREATE_WMS_TBL_IF_WMS_PALLET_INSPECTION(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Response : REWORK CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- REWORK CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_PALLET_INSPECTION")]
        public IActionResult DELETE_TBL_IF_WMS_PALLET_INSPECTION()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var result = service.DELETE_TBL_IF_WMS_PALLET_INSPECTION();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        //[HttpGet("DELETE_TBL_IF_WMS_PALLET_INSPECTION_BY_ID/{id}")]
        //public IActionResult DELETE_TBL_IF_WMS_PALLET_INSPECTION_BY_ID(string id)
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new PalletInspectionService();
        //        var result = service.DELETE_TBL_IF_WMS_PALLET_INSPECTION(id);
        //        var jsonResult = JsonConvert.SerializeObject(result);
        //        LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Response : DELETE SUCCESS = " + jsonResult.ToString());
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        #endregion

        #region TBL_IF_WCS_ASRS_SI

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_ASRS_SI")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_ASRS_SI()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var result = service.UPDATE_WMS_TBL_IF_WCS_ASRS_SI();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var result = service.DELETE_TBL_IF_WCS_ASRS_SI();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI_Manual")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI_Manual()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var result = service.DELETE_TBL_IF_WCS_ASRS_SI_Manual();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI")]
        public IActionResult MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PalletInspectionService();
                var Models = JsonConvert.DeserializeObject<TASK_TBL_IF_WCS_ASRS_SI>(body.ToString());
                LoggingService.DataLogLines("MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.SavePutawayAuto(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("MANUAL_PUTAWAY_TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("MANUAL_PUTAWAY", "TBL_IF_WMS_PALLET_INSPECTION", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}
