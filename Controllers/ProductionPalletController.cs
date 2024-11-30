using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.ProductionPallet;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/ProductionPallet")]
    [ApiController]
    public class ProductionPalletController : Controller
    {

        #region TBL_IF_WCS_PRODUCTION_PALLET

        [HttpPost("DELETE_TBL_IF_WCS_PRODUCTION_PALLET")]
        public IActionResult DELETE_TBL_IF_WCS_PRODUCTION_PALLET()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
                var result = service.DELETE_TBL_IF_WCS_PRODUCTION_PALLET();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_PRODUCTION_PALLET_V2")]
        public IActionResult DELETE_TBL_IF_WCS_PRODUCTION_PALLET_V2()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
                var result = service.DELETE_TBL_IF_WCS_PRODUCTION_PALLET_V2();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        [HttpPost("DELETE_TBL_IF_WCS_PRODUCTION_PALLET_TaskManual")]
        public IActionResult DELETE_TBL_IF_WCS_PRODUCTION_PALLET_TaskManual()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET_TaskManual", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
                var result = service.DELETE_TBL_IF_WCS_PRODUCTION_PALLET_TaskManual();
                var jsonResult = JsonConvert.SerializeObject(result);
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET_TaskManual", "Response : DELETE SUCCESS = " + jsonResult.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "ERROR", "-- " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine + ex.ToString());
                return BadRequest(ex);
            }
            finally
            {
                LoggingService.DataLogLines("TBL_IF_WCS_PRODUCTION_PALLET", "TBL_IF_WCS_PRODUCTION_PALLET_TaskManual", "-- DELETE END : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --" + Environment.NewLine);
            }
        }

        #endregion

        #region TBL_IF_WCS_ASRS_SI

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_ASRS_SI")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_ASRS_SI()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
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

        [HttpPost("UPDATE_WMS_TBL_IF_WCS_ASRS_SI_V2")]
        public IActionResult UPDATE_WMS_TBL_IF_WCS_ASRS_SI_V2()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "TBL_IF_WCS_ASRS_SI", "-- UPDATE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
                var result = service.UPDATE_WMS_TBL_IF_WCS_ASRS_SI_V2();
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
                var service = new ProductionPalletService();
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

        [HttpPost("DELETE_TBL_IF_WCS_ASRS_SI_REPAIR")]
        public IActionResult DELETE_TBL_IF_WCS_ASRS_SI_REPAIR()
        {
            var LoggingService = new Loging();
            LoggingService.DataLogLines("TBL_IF_WCS_ASRS_SI", "Repair_PutawayAuto", "-- DELETE START : " + DateTime.Now.ToString("yyyy-MM-dd-HHmm ") + " --");
            try
            {
                var service = new ProductionPalletService();
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