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
    public class EventController : ControllerBase
    {

        private IEventBL EventBL;

        public EventController(IEventBL EventBL)
        {
            this.EventBL = EventBL;
        }


        [HttpGet]
        [Route("GetEventById/{id}")]
        public ActionResult<Event> GetEventById(string id)
        {
            try
            {
                return EventBL.GetEventById(int.Parse(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("AddEvent")]
        public bool AddEvent([FromBody] EventDTO myEvent)
        {
            try
            {
                return EventBL.AddEvent(myEvent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPut]
        [Route("UpdateEvent/{eventID}")]
        public bool UpdateEvent(string eventID, [FromBody] EventDTO myEvent)
        {
            try
            {
                return EventBL.UpdateEvent(int.Parse(eventID), myEvent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
