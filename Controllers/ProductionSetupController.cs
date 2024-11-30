using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ProductionSetup;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/ProductionSetup")]
    [ApiController]
    public class ProductionSetupController : Controller
    {
        #region TBL_IF_WMS_PRODUCTION_SETUP

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PRODUCTION_SETUP")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PRODUCTION_SETUP([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionSetupService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PRODUCTION_SETUP_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "Request : " + JsonConvert.SerializeObject(body));
                //var result = service.CREATE_WMS_TBL_IF_WMS_PRODUCTION_SETUP(Models);
                var result = service.CREATE_WMS_TBL_IF_WMS_PRODUCTION_SETUP();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_DRYMIX_TBL_IF_WMS_PRODUCTION_SETUP")]
        public IActionResult CREATE_WMS_DRYMIX_TBL_IF_WMS_PRODUCTION_SETUP(Material_DocRequestViewModel model)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionSetupService();
                //var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PRODUCTION_SETUP_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "Request : " + JsonConvert.SerializeObject(model));
                //var result = service.CREATE_WMS_DRYMIX_TBL_IF_WMS_PRODUCTION_SETUP(Models);
                var result = service.CREATE_WMS_DRYMIX_TBL_IF_WMS_PRODUCTION_SETUP(model);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_PRODUCTION_SETUP")]
        public IActionResult DELETE_TBL_IF_WMS_PRODUCTION_SETUP()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionSetupService();
                var result = service.DELETE_TBL_IF_WMS_PRODUCTION_SETUP();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PRODUCTION_SETUP", "TBL_IF_WMS_PRODUCTION_SETUP", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("getData")]
        public IActionResult getData(Material_DocRequestViewModel model)
        {
            try
            {
                var service = new ProductionSetupService();
                var result = service.getDataProductionSetup(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        #endregion
     }
}