using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DL.Models;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        private IGiftBL _giftBL;

        public GiftController(IGiftBL GiftBL)
        {
            _giftBL = GiftBL;
        }


        [HttpGet]
        [Route("GetGiftsByEventType/{type}")]
        public IActionResult GetGiftsByEventType(int type)
        {
            try
            {
                return Ok(_giftBL.GetGiftsByEventType(type));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllGift")]
        public IActionResult GetAllGift()
        {
            try
            {
                return Ok(_giftBL.GetAllGift());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
