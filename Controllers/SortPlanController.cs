using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.SortPlan;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/SortPlan")]
    [ApiController]
    public class SortPlanController : Controller
    {
        #region TBL_IF_WMS_SORT_PLAN

        [HttpPost("CREATE_WMS_TBL_IF_WMS_SORT_PLAN")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_SORT_PLAN([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new SortPlanService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_SORT_PLAN_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_SORT_PLAN(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_SORT_PLAN")]
        public IActionResult DELETE_TBL_IF_WMS_SORT_PLAN()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new SortPlanService();
                var result = service.DELETE_TBL_IF_WMS_SORT_PLAN();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SORT_PLAN", "TBL_IF_WMS_SORT_PLAN", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}