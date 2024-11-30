using InterfaceBusiness;
using InterfaceBusiness.Suggestion;
using InterfaceBusiness.Support;
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

    [Route("api/Suggestion")]
    [ApiController]
    public class SuggestionController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public SuggestionController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("filter")]
        public IActionResult filterSuggestion([FromBody] JObject body)
        {
           
            try
            {
                SuggestionService service = new SuggestionService();
                SuggestionViewModel Models = JsonConvert.DeserializeObject<SuggestionViewModel>(body.ToString());
                var result = service.filter(Models);
               
                return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
        }
        
        [HttpPost("search")]
        public IActionResult searchSuggestion([FromBody] JObject body)
        {
           
            try
            {
                SuggestionService service = new SuggestionService();
                SuggestionViewModel Models = JsonConvert.DeserializeObject<SuggestionViewModel>(body.ToString());
                var result = service.search(Models);
               
                return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
        }
    }
}
