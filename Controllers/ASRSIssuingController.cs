using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ASRSIssuing;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/ASRSIssuing")]
    [ApiController]
    public class ASRSIssuingController : Controller
    {
        #region TBL_IF_WMS_ASRS_SO

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE_MAXMIN")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE_MAXMIN([FromBody] JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_BYPASS_SORTER_PICKFACE_MAXMIN(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_ASRS_SO_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_CALL104")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_CALL104([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<tmp_SuggestLocationCheckTF_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_CALL104(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_ASRS_SO_SEND104")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_ASRS_SO_SEND104([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var Models = JsonConvert.DeserializeObject<tmp_SuggestLocationCheckTF_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_ASRS_SO_SEND104(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
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

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var result = service.DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION();
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

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_ASRS_SO", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var result = service.DELETE_TBL_IF_WMS_ASRS_SO_RELOCATION_DYNAMIC_SLOTTING();
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

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var result = service.DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("BYPASS_PICKFACE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("BYPASS_PICKFACE", "TBL_IF_WMS_ASRS_SO", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN")]
        public IActionResult DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ASRSIssuingService();
                var result = service.DELETE_TBL_IF_WMS_ASRS_SO_BYPASS_PICKFACE_MAXMIN();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("BYPASS_PICKFACE_MAXMIN", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("BYPASS_PICKFACE_MAXMIN", "TBL_IF_WMS_ASRS_SO", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}