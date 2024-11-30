using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.CarouselPutAway;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/CarouselPutAway")]
    [ApiController]
    public class CarouselPutAwayController : Controller
    {
        #region TBL_IF_WMS_VC_PUTAWAY

        [HttpPost("CREATE_WMS_TBL_IF_WMS_VC_PUTAWAY")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_VC_PUTAWAY([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new CarouselPutAwayService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_VC_PUTAWAY_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_VC_PUTAWAY(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_VC_PUTAWAY")]
        public IActionResult DELETE_TBL_IF_WMS_VC_PUTAWAY()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new CarouselPutAwayService();
                var result = service.DELETE_TBL_IF_WMS_VC_PUTAWAY();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_VC_PUTAWAY", "TBL_IF_WMS_VC_PUTAWAY", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}