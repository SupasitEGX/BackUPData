using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.SortDestination;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/SortDestination")]
    [ApiController]
    public class SortDestinationController : Controller
    {
        #region TBL_IF_WMS_PALLET_SORT_DESTINAT

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PALLET_SORT_DESTINAT")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PALLET_SORT_DESTINAT([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new SortDestinationService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_SORT_DESTINAT_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PALLET_SORT_DESTINAT(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_PALLET_SORT_DESTINAT")]
        public IActionResult DELETE_TBL_IF_WMS_PALLET_SORT_DESTINAT()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new SortDestinationService();
                var result = service.DELETE_TBL_IF_WMS_PALLET_SORT_DESTINAT();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPD_SCAN_TAGOUT")]
        public IActionResult UPD_SCAN_TAGOUT([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new SortDestinationService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PALLET_SORT_DESTINAT_MODEL>(body.ToString());
                var result = service.UPD_SCAN_TAGOUT(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "Response : UPDATE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PALLET_SORT_DESTINAT", "TBL_IF_WMS_PALLET_SORT_DESTINAT", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }


        #endregion
    }
}