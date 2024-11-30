using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ScanPick;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/ScanPick")]
    [ApiController]
    public class ScanPickController : Controller
    {
        #region TBL_IF_WMS_SCAN_PICK_TOTE

        [HttpPost("CREATE_WMS_TBL_IF_WMS_SCAN_PICK_TOTE")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_SCAN_PICK_TOTE(List<TBL_IF_WMS_SCAN_PICK_TOTE_MODEL> Models)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_TOTE", "TBL_IF_WMS_SCAN_PICK_TOTE", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ScanPickService();
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_TOTE", "TBL_IF_WMS_SCAN_PICK_TOTE", "Request : " + JsonConvert.SerializeObject(Models));
                var result = service.CREATE_WMS_TBL_IF_WMS_SCAN_PICK_TOTE(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_TOTE", "TBL_IF_WMS_SCAN_PICK_TOTE", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_TOTE", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_TOTE", "TBL_IF_WMS_SCAN_PICK_TOTE", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion

        #region TBL_IF_WMS_SCAN_PICK_LABELING

        [HttpPost("CREATE_WMS_TBL_IF_WMS_SCAN_PICK_LABELING")]
        public IActionResult CREATE_WMS_TBL_IF_WMS_SCAN_PICK_LABELING(List<TBL_IF_WMS_SCAN_PICK_LABELING_MODEL> Models)
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_LABELING", "TBL_IF_WMS_SCAN_PICK_LABELING", "-- CREATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ScanPickService();
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_LABELING", "TBL_IF_WMS_SCAN_PICK_LABELING", "Request : " + JsonConvert.SerializeObject(Models));
                var result = service.CREATE_WMS_TBL_IF_WMS_SCAN_PICK_LABELING(Models);
                var response = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_LABELING", "TBL_IF_WMS_SCAN_PICK_LABELING", "Response : CREATE SUCCESS = " + response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_LABELING", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WMS_SCAN_PICK_LABELING", "TBL_IF_WMS_SCAN_PICK_LABELING", "-- CREATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion
    }
}