using InterfaceBusiness;
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

    [Route("api/Support")]
    [ApiController]
    public class SupportController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public SupportController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("filter")]
        public IActionResult filterCuttingFilm([FromBody] JObject body)
        {
           
            try
            {
                CuttingFilmService service = new CuttingFilmService();
                CuttingFilmViewModel Models = JsonConvert.DeserializeObject<CuttingFilmViewModel>(body.ToString());
                var result = service.filter(Models);
               
                return Ok(result);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
        }

        [HttpPost("update")]
        public IActionResult updateCuttingFilm([FromBody] JObject body)
        {

            try
            {
                CuttingFilmService service = new CuttingFilmService();
                CuttingFilmViewModel Models = JsonConvert.DeserializeObject<CuttingFilmViewModel>(body.ToString());
                var result = service.update(Models);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
