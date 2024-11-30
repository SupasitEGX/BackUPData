using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.PartialPalletRetrieval;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/PartialPalletRetrieval")]
    [ApiController]
    public class PartialPalletRetrievalController : Controller
    {
        #region TBL_IF_WMS_PP_RETRIEVAL

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletRetrievalService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PP_RETRIEVAL_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL_BYPASS_SORTER")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL_BYPASS_SORTER([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletRetrievalService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_PP_RETRIEVAL_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_PP_RETRIEVAL_BYPASS_SORTER(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_PP_RETRIEVAL")]
        public IActionResult DELETE_TBL_IF_WMS_PP_RETRIEVAL()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletRetrievalService();
                var result = service.DELETE_TBL_IF_WMS_PP_RETRIEVAL();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_PP_RETRIEVAL_TaskManual")]
        public IActionResult DELETE_TBL_IF_WMS_PP_RETRIEVAL_TaskManual()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- DELETE Task Manual START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new PartialPalletRetrievalService();
                var result = service.DELETE_TBL_IF_WMS_PP_RETRIEVAL_TaskManual();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_PP_RETRIEVAL", "TBL_IF_WMS_PP_RETRIEVAL", "-- DELETE Task Manual END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}