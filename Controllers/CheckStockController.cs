using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness;
using InterfaceBusiness.Interface;
using InterfaceBusiness.Tote;
using InterfaceBusiness.Wave;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using InterfaceBusiness.Suggestion;
using InterfaceBusiness.Support;
using Microsoft.AspNetCore.Hosting;

namespace InterfaceAPI.Controllers
{
    [Route("api/CheckStock")]
    [ApiController]
    public class CheckStockController : Controller
    {
        [HttpPost("CheckStock")]
        public IActionResult CheckStock([FromBody] JObject body)
        {
            try
            {
                var service = new CheckStockService();
                var Gi_no = body.ToObject<Listmodelserch_GI>();
                var result = service.CheckStock(Gi_no);
                return Ok(result);
            }
            catch (Exception e)
            {
            
                throw e;
            }
           
        }

    }
}