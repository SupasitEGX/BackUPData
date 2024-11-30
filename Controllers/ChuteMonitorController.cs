using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ChuteMonitor;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/ChuteMonitor")]
    [ApiController]
    public class ChuteMonitorController : Controller
    {
        #region TBL_IF_WMS_CHUTE_Monitor

        [HttpPost("CREATE_WMS_TBL_IF_WMS_CHUTE_Monitor")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_CHUTE_Monitor([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ChuteMonitorService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_CHUTE_Monitor_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_CHUTE_Monitor(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_CHUTE_Monitor")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_CHUTE_Monitor()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ChuteMonitorService();
                //var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_CHUTE_Monitor_MODEL>(body.ToString());
                //LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WMS_CHUTE_Monitor();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_CHUTE_Monitor", "TBL_IF_WMS_CHUTE_Monitor", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }


        #endregion
    }
}