using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.PiecePicking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/PiecePicking")]
    [ApiController]
    public class PiecePickingController : Controller
    {
        #region TBL_IF_WMS_PTL_PICKING

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PTL_PICKING")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PTL_PICKING([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PiecePickingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PTL_PICKING_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PTL_PICKING(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_PTL_PICKING")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_PTL_PICKING([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PiecePickingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PTL_PICKING_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WMS_PTL_PICKING(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PTL_PICKING", "TBL_IF_WMS_PTL_PICKING", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CHECK_INSPECTION_TOTE")]
        public IActionResult CHECK_INSPECTION_TOTE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("CHECK_DATA", "CHECK_INSPECTION_TOTE", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PiecePickingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PTL_PICKING_MODEL>(body.ToString());
                var result = service.CHECK_INSPECTION_TOTE(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("CHECK_DATA", "CHECK_INSPECTION_TOTE", "Response : UPDATE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("CHECK_DATA", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("CHECK_DATA", "CHECK_INSPECTION_TOTE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }


        #endregion
    }
}