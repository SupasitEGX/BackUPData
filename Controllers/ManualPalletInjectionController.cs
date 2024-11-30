using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ManualPalletInjection;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/ManualPalletInjection")]
    [ApiController]
    public class ManualPalletInjectionController : Controller
    {
        #region TBL_IF_WMS_MANUAL_PALLET

        [HttpPost("CREATE_WMS_TBL_IF_WMS_MANUAL_PALLET")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_MANUAL_PALLET([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ManualPalletInjectionService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_MANUAL_PALLET_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_MANUAL_PALLET(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_MANUAL_PALLET")]
        public IActionResult DELETE_TBL_IF_WMS_MANUAL_PALLET()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ManualPalletInjectionService();
                var result = service.DELETE_TBL_IF_WMS_MANUAL_PALLET();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_MANUAL_PALLET", "TBL_IF_WMS_MANUAL_PALLET", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}