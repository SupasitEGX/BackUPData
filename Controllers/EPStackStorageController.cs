using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.EPStackStorage;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InterfaceAPI.Controllers
{
    [Route("api/EPStackStorage")]
    [ApiController]
    public class EPStackStorageController : Controller
    {
        #region TBL_IF_WCS_ASRS_SI

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_ASRS_SI")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_ASRS_SI()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new EPStackStorageService();
                var result = service.UPDATE_WMS_TBL_IF_WCS_ASRS_SI();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new EPStackStorageService();
                var result = service.DELETE_TBL_IF_WCS_ASRS_SI();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI_TaskManual")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI_TaskManual()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new EPStackStorageService();
                var result = service.DELETE_TBL_IF_WCS_ASRS_SI_TaskManual();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI_REPAIR")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI_REPAIR()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "Repair_PutawayAuto", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new EPStackStorageService();
                var result = service.DELETE_TBL_IF_WCS_ASRS_SI_REPAIR();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "Repair_PutawayAuto", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "Repair_PutawayAuto", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}