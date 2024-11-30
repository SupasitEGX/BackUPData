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
    [Route("api/LogArchiveOMS")]
    [ApiController]
    public class LogArchiveOMSController : Controller
    {
        [HttpPost("LogArchive_Data")]
        public IActionResult LogArchive([FromBody] JObject body)
        {
            try
            {
                var service = new LogArchiveOMSService();
                var search = body.ToObject<ListmodelLogArchive_SearchDate>();
                var result = service.LogArchive(search);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }
        /*
        private static ListmodelLogArchive_SearchDate NewMethod(JObject body)
        {
            return body.ToObject<ListmodelLogArchive_SearchDate>();
        }*/
    }
}