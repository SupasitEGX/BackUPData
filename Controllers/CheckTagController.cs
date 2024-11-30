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
    [Route("api/CheckTag")]
    [ApiController]
    public class CheckTagController : Controller
    {
        [HttpPost("CheckTag_TagItem")]
        public IActionResult CheckTag_TagItem([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                //ListmodelSendTag tag_no = JsonConvert.DeserializeObject<ListmodelSendTag>(body.ToString());
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_TagItem(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        [HttpPost("CheckTag_BinBalance")]
        public IActionResult CheckTag_BinBalance([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                //ListmodelSendTag tag_no = JsonConvert.DeserializeObject<ListmodelSendTag>(body.ToString());
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_BinBalance(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_GoodsReceiveItemLocation")]
        public IActionResult CheckTag_GoodsReceiveItemLocation([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_GoodsReceiveItemLocation(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_GoodsIssueItemLocation")]
        public IActionResult CheckTag_GoodsIssueItemLocation([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_GoodsIssueItemLocation(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_GoodsIssueItemLocationSQTY")]
        public IActionResult CheckTag_GoodsIssueItemLocationSQTY([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_GoodsIssueItemLocationSQTY(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_TaskItem")]
        public IActionResult CheckTag_TaskItem([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_TaskItem(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_TagOutItem")]
        public IActionResult CheckTag_TagOutItem([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_TagOutItem(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_BinCardReserve_GINOTCOMFIRM")]
        public IActionResult CheckTag_BinCardReserve_GINOTCOMFIRM([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_BinCardReserve_GINOTCOMFIRM(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_BinCardReserve")]
        public IActionResult CheckTag_BinCardReserve([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_BinCardReserve(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_BinBalanceGI")]
        public IActionResult CheckTag_BinBalanceGI([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_BinBalanceGI(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_BinBalanceGR")]
        public IActionResult CheckTag_BinBalanceGR([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_BinBalanceGR(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_GoodsTransferItemWT")]
        public IActionResult CheckTag_GoodsTransferItemWT([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_GoodsTransferItemWT(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        
        [HttpPost("CheckTag_GoodsTransferItemWGITL")]
        public IActionResult CheckTag_GoodsTransferItemWGITL([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var tag_no = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_GoodsTransferItemWGITL(tag_no);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        [HttpPost("CheckTag_CutStock")]
        public IActionResult CheckTag_CutStock([FromBody] JObject body)
        {
            try
            {
                var service = new CheckTagService();
                var data = body.ToObject<ListmodelSendTag>();
                var result = service.CheckTag_CutStock(data);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
