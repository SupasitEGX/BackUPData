using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness.Dropdown;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAPI.Controllers
{
    [Route("api/Dropdown")]
    //[ApiController]
    public class DropdownController : Controller
    {
        [HttpPost("dropdownLocationZoneputaway")]
        public IActionResult dropdownLocationZoneputaway([FromBody]JObject body)
        {
            try
            {
                var service = new DropdownService();
                var Models = new LocationZoneputawayViewModel();
                Models = JsonConvert.DeserializeObject<LocationZoneputawayViewModel>(body.ToString());
                var result = service.dropdownLocationZoneputaway(Models);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        

    }
}