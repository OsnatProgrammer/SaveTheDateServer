using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GiftController : ControllerBase
    {
        private IGiftBL _giftBL;

        public GiftController(IGiftBL giftBL)
        {
            this._giftBL = giftBL;
        }


        [HttpGet]
        [Route("GetAllGift")]
        public IActionResult GetAllGift()
        {
            try
            {
                return Ok(this._giftBL.GetAllGift());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetGiftById/{id}")]
        public ActionResult<Gift> GetGiftById(string id)
        {
            try
            {
                return _giftBL.GetGiftById(int.Parse(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpGet]
        [Route("GetGiftsByEventType/{eventType}")]
        public IActionResult GetGiftsByEventType(int eventType)
        {
            try
            {
                return Ok(this._giftBL.GetGiftsByEventType(eventType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

  
     [HttpPost]
     [Route("AddGift")]
     public bool AddGift([FromBody] GiftDTO Gift)
     {
         try
         {
            return _giftBL.AddGift(Gift);
         }
         catch (Exception ex)
         {
             throw ex;
         }
     } 
    
    
    
   

    [HttpDelete]
        [Route("DeleteGift/{giftID}")]
        public bool DeleteGift(string giftID)
        {
            try
            {
                return _giftBL.DeleteGift(giftID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     }

 }