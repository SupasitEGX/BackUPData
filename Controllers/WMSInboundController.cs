using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.Interface;
using InterfaceBusiness.Wave;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/WMSInbound")]
    [ApiController]
    public class WMSInboundController : Controller
    {
        //#region AFTER_WAVE

        //[HttpPost("CallEPStack")]
        //public IActionResult WMS_WAVE([FromBody]JObject body)
        //{
        //    var LoggingService = new Loging();
        //    LoggingService.DataLogLines("CallEPStack", "CallEPStack", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
        //    try
        //    {
        //        //var service = new WaveService();
        //        //var Models = JsonConvert.DeserializeObject<TBL_IF_WMS_WAVE_MODEL>(body.ToString());
        //        //LoggingService.DataLogLines("CallEPStack", "CallEPStack", "Request : " + JsonConvert.SerializeObject(body));

        //        //var response_WAVE = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_WAVE"), JsonConvert.SerializeObject(Models));
        //        //var response_ASRS_SO = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_ASRS_SO"), JsonConvert.SerializeObject(Models));
        //        //var response_PTL_PICKING = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PTL_PICKING"), JsonConvert.SerializeObject(Models));
        //        //var response_PALLET_SORT_DESTINAT = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PALLET_SORT_DESTINAT"), JsonConvert.SerializeObject(Models));
        //        //var response_PP_RETRIEVAL = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_PP_RETRIEVAL"), JsonConvert.SerializeObject(Models));
        //        //var response_SORT_PLAN = utils.SendDataApi<dynamic>(new AppSettingConfig().GetUrl("create_SORT_PLAN"), JsonConvert.SerializeObject(Models));

        //        //var result = service.CREATE_WMS_WMS_WAVE(Models);
        //        //var response = JsonConvert.SerializeObject(result);
        //        //LoggingService.DataLogLines("CallEPStack", "CallEPStack", "Response : CREATE SUCCESS = " + response);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggingService.DataLogLines("CallEPStack", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
        //        return BadRequest(ex);
        //    }
        //    finally
        //    {
        //        LoggingService.DataLogLines("CallEPStack", "CallEPStack", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
        //    }
        //}
        //#endregion


    }
}