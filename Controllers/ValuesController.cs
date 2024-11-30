using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceBusiness.Test;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //string[] arr = { "bi", "Fr", "rA", "cc" };
            ////string[] arrIn = { "bi", "Fr","111" };
            //string[] arrIn = { "b", "F", "111" };
            //var matches = from name in arr
            //              where arrIn.ToList().Any(str => name.ToLowerInvariant().StartsWith(str.ToLowerInvariant()))
            //              select name;
            //var lst = matches.ToList();
            //var service = new TestService();
            //var result = service.CREATE_TBL_IF_WMS_PALLET_INSPECTION();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
