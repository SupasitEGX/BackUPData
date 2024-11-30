using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.PartialPalletPutAway;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InterfaceAPI.Controllers
{
    [Route("api/PartialPalletPutAway")]
    [ApiController]
    public class PartialPalletPutAwayController : Controller
    {
        #region TBL_IF_WCS_PP_PUTAWAY

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_PP_PUTAWAY")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_PP_PUTAWAY()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletPutAwayService();
                var result = service.UPDATE_WMS_TBL_IF_WCS_PP_PUTAWAY();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "Response : UPDATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_PP_PUTAWAY")]
        public IActionResult DELETE_TBL_IF_WCS_PP_PUTAWAY()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletPutAwayService();
                var result = service.DELETE_TBL_IF_WCS_PP_PUTAWAY();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PP_PUTAWAY", "TBL_IF_WCS_PP_PUTAWAY", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}