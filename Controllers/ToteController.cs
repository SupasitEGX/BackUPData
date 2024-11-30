using System;
using InterfaceBusiness.CarouselPutAway;
using InterfaceBusiness.Tote;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace InterfaceAPI.Controllers
{
    [Route("api/ToteController")]
    [ApiController]
    public class ToteController : Controller
    {
        #region Check Inspection Tote

        [HttpPost("Check_Tote")]
        public IActionResult Check_Tote()
        {
            try
            {
                var service = new CheckToteService();
                var result = service.Check_Tote();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        #endregion
    }
}