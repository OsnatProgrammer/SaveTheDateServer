using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DTO;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GiftController : ControllerBase
    {
        private IGiftBL GiftBL;

        public GiftController(IGiftBL GiftBL)
        {
            this.GiftBL = GiftBL;
        }


        [HttpGet]
        [Route("GetAllGift")]
        public IActionResult GetAllGift()
        {
            try
            {
                return Ok(GiftBL.GetAllGift());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [HttpGet]
        [Route("GetGiftsByEventType/{eventType}")]
        public IActionResult GetGiftsByEventType(int eventType)
        {
            try
            {
                return Ok(GiftBL.GetGiftsByEventType(eventType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
    // [HttpPost]
    // [Route("AddGift")]
    // public bool AddGift([FromBody] GiftDTO Gift)
    // {
    //     try
    //     {
    //         return GiftBL.AddGift(Gift);
    //     }
    //     catch (Exception ex)
    //     {
    //         throw ex;
    //     }
    // }

    //[HttpDelete]
    //    [Route("DeleteGift/{CoronaCode}")]
    //    public bool DeleteGift(string CoronaCode)
    //    {
    //        try
    //        {
    //            return GiftBL.DeleteGift(CoronaCode);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    // }
}
