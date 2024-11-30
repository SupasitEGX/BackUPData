using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ASRSIssuing;
using InterfaceBusiness.CallEmptyPalletStack;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/CallEmptyPalletStack")]
    [ApiController]
    public class CallEmptyPalletStackController : Controller
    {
        #region TBL_IF_WCS_CALL_EP_STACK 

        //[HttpPost("CREATE_WCS_TBL_IF_WCS_CALL_EP_STACK")]
        //public IActionResult CREATE_WCS_TBL_IF_WCS_CALL_EP_STACK()
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new CallEmptyPalletStackService();
        //        var result = service.CREATE_WCS_TBL_IF_WCS_CALL_EP_STACK();
        //        LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "Response : CREATE SUCCESS = " + result.ToString());
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_CALL_EP_STACK")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_CALL_EP_STACK()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new CallEmptyPalletStackService();
                var result = service.UPDATE_WMS_TBL_IF_WCS_CALL_EP_STACK();
                LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "Response : UPDATE SUCCESS = " + result.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_CALL_EP_STACK", "TBL_IF_WCS_CALL_EP_STACK", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion

        #region TBL_IF_WMS_ASRS_SO

        //[HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO")]
        //public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO([FromBody]JObject body)
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new CallEmptyPalletStackService();
        //        var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
        //        LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
        //        var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO(Models);
        //        var response = JsonConvert.SerializeObject(result);
        //        LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new CallEmptyPalletStackService();
                var result = service.DELETE_TBL_IF_WMS_ASRS_SO();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}