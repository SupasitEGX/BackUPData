using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.Wave;
using InterfaceDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/Wave")]
    [ApiController]
    public class WaveController : Controller
    {
        #region TBL_IF_WMS_WAVE

        [HttpPost("CREATE_WMS_TBL_IF_WMS_WAVE")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_WAVE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_WAVE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CREATE_WMS_TBL_IF_WMS_WAVE_BYPASS_SORTER")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_WAVE_BYPASS_SORTER([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CREATE_WMS_TBL_IF_WMS_WAVE_BYPASS_SORTER(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_WAVE")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_WAVE()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var result = service.UPDATE_WMS_TBL_IF_WMS_WAVE();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : UPDATE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_ACTION")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_ACTION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_ACTION(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : UPDATE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- WAVE CLOSE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : WAVE CLOSE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- WAVE CLOSE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE_STATUS45")]
        public IActionResult UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE_STATUS45([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE_Close45", "TBL_IF_WMS_WAVE", "-- WAVE CLOSE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE_Close45", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WMS_TBL_IF_WMS_WAVE_STATUS_CLOSE_STATUS45(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE_Close45", "TBL_IF_WMS_WAVE", "Response : WAVE CLOSE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE_Close45", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE_Close45", "TBL_IF_WMS_WAVE", "-- WAVE CLOSE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CheckWaveWorkInProcess")]
        public IActionResult CheckWaveWorkInProcess()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CHECKWAVE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var result = service.CheckWaveWorkInProcess();
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : CHECKWAVE SUCCESS = " + result);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- CHECKWAVE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("UPDATE_WAVE_STATUS")]
        public IActionResult UPDATE_WAVE_STATUS([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE_WAVE_STATUS START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.UPDATE_WAVE_STATUS(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : UPDATE_WAVE_STATUS SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("CheckBeforeRunWave")]
        public IActionResult CheckBeforeRunWave([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE_WAVE_STATUS START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE>(body.ToString());
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.CheckBeforeRunWave(Models);
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : UPDATE_WAVE_STATUS SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("Get_Wave_WIP")]
        public IActionResult Get_Wave_WIP()
        {
            try
            {
                var service = new WaveService();
                var result = service.Get_Wave_WIP();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[HttpPost("UpdateWaveCompletePercent")]
        //public IActionResult UpdateWaveCompletePercent([FromBody]JObject body)
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE_WAVE_COMPLETED_PERCENT START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new WaveService();
        //        var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE>(body.ToString());
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
        //        var result = service.UpdateWaveCompletePercent(Models);
        //        var jsonResult = JsonConvert.SerializeObject(result);
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : UPDATE_WAVE_COMPLETED_PERCENT SUCCESS = " + jsonResult.ToString());
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        //[HttpPost("DELETE_TBL_IF_WMS_WAVE")]
        //public IActionResult DELETE_TBL_IF_WMS_WAVE()
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        var service = new WaveService();
        //        var result = service.DELETE_TBL_IF_WMS_WAVE();
        //        var jsonResult = JsonConvert.SerializeObject(result);
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "Response : DELETE SUCCESS = " + jsonResult.ToString());
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("TBL_IF_WMS_WAVE", "TBL_IF_WMS_WAVE", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}

        #endregion
    }
}