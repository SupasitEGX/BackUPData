using InterfaceBusiness;
using InterfaceBusiness.Support;
using InterfaceBusiness.SupportRollcage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAPI.Controllers
{

    [Route("api/SupportRollcage")]
    [ApiController]
    public class SupportRollcageController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public SupportRollcageController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("filterRollcage")]
        public IActionResult filterRollcage([FromBody] JObject body)
        {
            try
            {
                SupportRollcageService service = new SupportRollcageService();
                SupportRollcageViewModel Models = JsonConvert.DeserializeObject<SupportRollcageViewModel>(body.ToString());
                var result = service.filterRollcage(Models);

                return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
        }

        [HttpPost("updateRollcage_BUFCH")]
        public IActionResult updateRollcage([FromBody] JObject body)
        {
            try
            {
                SupportRollcageService service = new SupportRollcageService();
                SupportRollcageViewModel Models = JsonConvert.DeserializeObject<SupportRollcageViewModel>(body.ToString());
                var result = service.updateRollcage_BUFCH(Models);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
