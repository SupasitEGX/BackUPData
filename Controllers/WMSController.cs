using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.Interface;
using InterfaceBusiness.Wave;
using InterfaceBusiness.WMS;
using InterfaceDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/WMS")]
    [ApiController]
    public class WMSController : Controller
    {
        #region AFTER_WAVE

        [HttpPost("WMS_WAVE")]
        public IActionResult WMS_WAVE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));

                var response_WAVE = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_WAVE"), JsonConvert.SerializeObject(Models));
                var response_SORT_PLAN = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_SORT_PLAN"), JsonConvert.SerializeObject(Models));
                var response_ASRS_SO = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_ASRS_SO"), JsonConvert.SerializeObject(Models));
                var response_PALLET_SORT_DESTINAT = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PALLET_SORT_DESTINAT"), JsonConvert.SerializeObject(Models));
                var response_PTL_PICKING = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PTL_PICKING"), JsonConvert.SerializeObject(Models));
                var response_PP_RETRIEVAL = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PP_RETRIEVAL"), JsonConvert.SerializeObject(Models));

                //var result = service.CREATE_WMS_WMS_WAVE(Models);
                //var response = JsonConvert.SerializeObject(result);
                //LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Response : CREATE SUCCESS = " + response);
                return Ok("create_success");
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region PREPARE_WAVE
        [HttpPost("PREPARE_WAVE")]
        public IActionResult PREPARE_WAVE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE WAVE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.PREPARE_WAVE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Response : PREPARE WAVE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE WAVE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region REPAIR_PREPARE_WAVE
        [HttpPost("REPAIR_PREPARE_WAVE")]
        public IActionResult REPAIR_REPAIR_PREPARE_WAVE([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("REPAIR_PREPARE_WAVE", "WMS_WAVE", "-- REPAIR PREPARE WAVE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("REPAIR_PREPARE_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.REPAIR_PREPARE_WAVE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("REPAIR_PREPARE_WAVE", "WMS_WAVE", "Response : REPAIR PREPARE WAVE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("REPAIR_PREPARE_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("REPAIR_PREPARE_WAVE", "WMS_WAVE", "-- REPAIR PREPARE WAVE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region PREPARE_TRANSFER
        [HttpPost("PREPARE_TRANSFER")]
        public IActionResult PREPARE_TRANSFER([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.PREPARE_TRANSFER(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Response : PREPARE TRANSFER SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region PREPARE_TRANSFER_PICKFACE_MAXMIN
        [HttpPost("PREPARE_TRANSFER_PICKFACE_MAXMIN")]
        public IActionResult PREPARE_TRANSFER_PICKFACE_MAXMIN([FromBody] JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER PICKFACE MAXMIN START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.PREPARE_TRANSFER_PICKFACE_MAXMIN(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Response : PREPARE TRANSFER PICKFACE MAXMIN SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER PICKFACE MAXMIN END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region PREPARE_TRANSFER_RELOCATION
        [HttpPost("PREPARE_TRANSFER_RELOCATION")]
        public IActionResult PREPARE_TRANSFER_RELOCATION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.PREPARE_TRANSFER_RELOCATION(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "Response : PREPARE TRANSFER SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_WAVE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_WAVE", "WMS_WAVE", "-- PREPARE TRANSFER END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region WMS_TRANSFER_BYPASS_SORTER
        [HttpPost("WMS_TRANSFER_BYPASS_SORTER")]
        public IActionResult WMS_TRANSFER_BYPASS_SORTER([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_TRANSFER_BYPASS_SORTER", "WMS_WAVE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_TRANSFER_BYPASS_SORTER", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));

                var response_TRANSFER = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_WAVE_BYPASS_SORTER"), JsonConvert.SerializeObject(Models));
                var response_ASRS_SO_BYPASS_SORTER = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_ASRS_SO_BYPASS_SORTER"), JsonConvert.SerializeObject(Models));
                var response_PTL_PICKING_BYPASS_SORTER = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PP_RETRIEVAL_BYPASS_SORTER"), JsonConvert.SerializeObject(Models));

                return Ok("create_success");
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_TRANSFER_BYPASS_SORTER", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_TRANSFER_BYPASS_SORTER", "WMS_WAVE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region WMS_TRANSFER_RELOCATION
        [HttpPost("WMS_TRANSFER_RELOCATION")]
        public IActionResult WMS_TRANSFER_RELOCATION([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("WMS_TRANSFER_RELOCATION", "WMS_WAVE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WaveService();
                var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
                LoggingService.DataLogLines("WMS_TRANSFER_RELOCATION", "WMS_WAVE", "Request : " + JsonConvert.SerializeObject(body));

                var response_ASRS_SO = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_ASRS_SO_RELOCATION"), JsonConvert.SerializeObject(Models));

                return Ok();
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("WMS_TRANSFER_RELOCATION", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("WMS_TRANSFER_RELOCATION", "WMS_WAVE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region get Equipment

        [HttpPost("getEquipment")]
        public IActionResult getEquipment([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("GET Equipment", "GET Equipment", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new InterfaceService();
                var Models = JsonConvert.DeserializeObject<equipmentModel>(body.ToString());
                LoggingService.DataLogLines("GET Equipment", "GET Equipment", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.GetEquipment(Models);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("GET Equipment", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("GET Equipment", "GET Equipment", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("getBinbalanceTag")]
        public IActionResult getBinbalanceTag([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("GET BinBalance Tag", "GET BinBalance Tag", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TASK_TBL_IF_WCS_PP_PUTAWAY>(body.ToString());
                LoggingService.DataLogLines("GET BinBalance Tag", "GET BinBalance Tag", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.transferLocation(Models);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("GET BinBalance Tag", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("GET BinBalance Tag", "GET Equipment", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region transferToPartial
        [HttpPost("transferToPartial")]
        public IActionResult transferToPartial([FromBody]JObject body)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("trnasfer to partial", "trnasfer to partial", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var Models = JsonConvert.DeserializeObject<TASK_TBL_IF_WCS_PP_PUTAWAY>(body.ToString());
                LoggingService.DataLogLines("trnasfer to partial", "trnasfer to partial", "Request : " + JsonConvert.SerializeObject(body));
                var result = service.transferLocationPartial(Models);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("trnasfer to partial", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("trnasfer to partial", "trnasfer to partial", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion

        #region DELETE Duplicate RollcageOrder
        [HttpPost("DELETE_DUPLICATE_ROLLCAGE_ORDER")]
        public IActionResult DELETE_DUPLICATE_ROLLCAGE_ORDER()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("DELETE_DUPLICATE_ROLLCAGE_ORDER", "DELETE_DUPLICATE_ROLLCAGE_ORDER", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new WMSService();
                var result = service.DELETE_DUPLICATE_ROLLCAGE_ORDER();
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("DELETE_DUPLICATE_ROLLCAGE_ORDER", "DELETE_DUPLICATE_ROLLCAGE_ORDER", "Response : DELETE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("DELETE_DUPLICATE_ROLLCAGE_ORDER", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("DELETE_DUPLICATE_ROLLCAGE_ORDER", "DELETE_DUPLICATE_ROLLCAGE_ORDER", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion
    }
}