using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using InterfaceBusiness.SupportAutocomplete;

namespace InterfaceAPI.Controllers
{
    [Route("api/SupportAutocomplete")]
    public class SupportAutocompleteController : Controller
    {
        #region autoRuleputawayCondition
        [HttpPost("autoRuleputawayCondition")]
        public IActionResult autoRuleputawayCondition([FromBody] JObject body)
        {
            try
            {
                var service = new SupportAutocompleteService();
                var Models = new SupportAutocompleteViewModel();
                Models = JsonConvert.DeserializeObject<SupportAutocompleteViewModel>(body.ToString());
                var result = service.autoRuleputawayCondition(Models);
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