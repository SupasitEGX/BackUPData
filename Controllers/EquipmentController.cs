using System;
using InterfaceBusiness;
using InterfaceBusiness.PalletInspection;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterfaceAPI.Controllers
{
    [Route("api/Equipment")]
    [ApiController]
    public class EquipmentController : Controller
    {

        #region TBL_IF_WCS_EQUIPMENT_STATUS

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_EQUIPMENT_STATUS")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_EQUIPMENT_STATUS()
        {
            Loging LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_EQUIPMENT_STATUS", "TBL_IF_WCS_EQUIPMENT_STATUS", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                EquipmentService service = new EquipmentService();
                string result = service.UPDATE_WMS_TBL_IF_WCS_EQUIPMENT_STATUS();
                LoggingService.DataLogLines("TBL_IF_WCS_EQUIPMENT_STATUS", "TBL_IF_WCS_EQUIPMENT_STATUS", "Response : UPDATE SUCCESS ");
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_EQUIPMENT_STATUS", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_EQUIPMENT_STATUS", "TBL_IF_WCS_EQUIPMENT_STATUS", "-- UPDATE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }
        #endregion
        
    }
}
