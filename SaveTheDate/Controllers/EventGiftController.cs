using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventGiftController : ControllerBase
    {
        private IEventGiftBL _eventGiftBL;

        public EventGiftController(IEventGiftBL EventGiftBL)
        {
           _eventGiftBL = EventGiftBL;
        }


        [HttpGet]
        [Route("GetAllGivenGifts/{id}")]
        public IActionResult GetAllGivenGifts(int id)
        {

            try
            {

                return 
                    Ok(_eventGiftBL.GetAllGivenGifts(id));
            }


            catch (Exception ex)
            {
               return StatusCode(500, ex.Message);
            }
        }

        //GET
        //שליפת כל המתנות שלא התקבלו

        [HttpGet]
        [Route("GetAllUnGivenGifts/{id}")]
        public IActionResult GetAllUnGivenGifts(int id)
        {
            try
            {
                return Ok(_eventGiftBL.GetAllUnGivenGifts(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        //PUT
        //הכנסת ברכה ועדכון שהמתנה תפוסה
        //מקבל את ה מזהה של המתנה מתוך רשימת המתנות שהמזמין בחר
        //וכן מקבל את שם האורח שהביא את המתנה במקרה זה היוזר הוא מביא המתנה
        //ומכניס את הברכה המצורפת לטבלה

        [HttpPut]
        [Route("GetAGiftFromGuest/{EventID}")]
        public bool GetAGiftFromGuest(int EventGiftID, int userId, string blessing)
        {
            try
            {
                return _eventGiftBL.GetAGiftFromGuest(EventGiftID, userId, blessing);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //  public ActionResult<EventGift> GetEventGiftById(int EventGiftID)
        //  {
        //      try
        //      {
        //          return EventGiftBL.GetEventGiftById(EventGiftID);
        //      }
        //      catch (Exception ex)
        //      {
        //          throw ex;
        //      }
        //  }
        //
        //
        //  [HttpPost]
        //  [Route("AddEventGift")]
        //  public bool AddEventGift([FromBody] EventGiftDTO myEventGift)
        //  {
        //      try
        //      {
        //          return EventGiftBL.AddEventGift(myEventGift);
        //      }
        //      catch (Exception ex)
        //      {
        //          throw ex;
        //      }
        //  }
        //
        //
        //  [HttpPut]
        //  [Route("UpdateEventGift/{EventGiftID}")]
        //  public bool UpdateEventGift(int EventGiftID, [FromBody] EventGiftDTO myEventGift)
        //  {
        //      try
        //      {
        //          return EventGiftBL.UpdateEventGift(EventGiftID, myEventGift);
        //      }
        //      catch (Exception ex)
        //      {
        //          throw ex;
        //      }
        //  }
    }
}
