using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.MoveRollCage;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/MoveRollCage")]
    [ApiController]
    public class MoveRollCageController : Controller
    {
        #region TBL_IF_WMS_MOVE_ROLL_CAGE

        [HttpPost("CREATE_WMS_TBL_IF_WMS_MOVE_ROLL_CAGE")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_MOVE_ROLL_CAGE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new MoveRollCageService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_MOVE_ROLL_CAGE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_MOVE_ROLL_CAGE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_MOVE_ROLL_CAGE")]
        public IActionResult DELETE_TBL_IF_WMS_MOVE_ROLL_CAGE()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new MoveRollCageService();
                var result = service.DELETE_TBL_IF_WMS_MOVE_ROLL_CAGE();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MOVE_ROLL_CAGE", "TBL_IF_WMS_MOVE_ROLL_CAGE", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPD_TBL_IF_WMS_ROLLCAGE_STATUS")]
        public IActionResult UPD_TBL_IF_WMS_ROLLCAGE_STATUS()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ROLLCAGE_STATUS", "TBL_IF_WMS_ROLLCAGE_STATUS", "-- UPD START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new MoveRollCageService();
                var result = service.UPD_TBL_IF_WMS_ROLLCAGE_STATUS();
                //var jsonResult = JsonConvert.SerializeObject(result);
                //LoggingService.DataLogLines("TBL_IF_WMS_ROLLCAGE_STATUS", "TBL_IF_WMS_ROLLCAGE_STATUS", "Response : UPD SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ROLLCAGE_STATUS", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ROLLCAGE_STATUS", "TBL_IF_WMS_ROLLCAGE_STATUS", "-- UPD END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("GET_TBL_IF_WMS_ROLLCAGE_STATUS")]
        public IActionResult GET_TBL_IF_WMS_ROLLCAGE_STATUS([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            try
            {
                var service = new MoveRollCageService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_MOVE_ROLL_CAGE_MODEL>(body.ToString());
                var result = service.GET_TBL_IF_WMS_ROLLCAGE_STATUS(Models);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            finally
            {

            }
        }

        #endregion
    }
}