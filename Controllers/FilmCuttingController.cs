using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.FilmCutting;
using InterfaceDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/FilmCutting")]
    [ApiController]
    public class FilmCuttingController : Controller
    {
        #region TBL_IF_WCS_FILMCUT

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_FILMCUT")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_FILMCUT([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new FilmCuttingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WCS_FILMCUT_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_INSPECTION", "TBL_IF_WMS_PALLET_INSPECTION", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WCS_FILMCUT(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("findtagno_filmcut")]
        public IActionResult findtagno_filmcut([FromBody]JObject body)
        {
            try
            {
                var service = new FilmCuttingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WCS_FILMCUT_MODEL>(body.ToString());
                var result = service.findtagno_filmcut(Models);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("UPDATE_WMS_TBL_IF_WCS_FILMCUT")]
        //public IActionResult UPDATE_WMS_TBL_IF_WCS_FILMCUT()
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new FilmCuttingService();
        //        var result = service.UPDATE_WMS_TBL_IF_WCS_FILMCUT();
        //        var response = JsonConvert.SerializeObject(result);
        //        LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "Response : UPDATE SUCCESS = " + response);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        [HttpPost("DELETE_TBL_IF_WCS_FILMCUT")]
        public IActionResult DELETE_TBL_IF_WCS_FILMCUT()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new FilmCuttingService();
                var result = service.DELETE_TBL_IF_WCS_FILMCUT();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_FILMCUT", "TBL_IF_WCS_FILMCUT", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}