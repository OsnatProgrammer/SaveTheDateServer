﻿using Microsoft.AspNetCore.Http;
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

        private IEventBL _eventBL;

        public EventController(IEventBL EventBL)
        {
            _eventBL = EventBL;
        }


        [HttpGet]
        [Route("GetEventById/{id}")]
        public ActionResult<Event> GetEventById(string id)
        {
            try
            {
                return _eventBL.GetEventById(int.Parse(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetAllEvents")]
        public IActionResult GetAllEvents()
        {
            try
            {
                return Ok(_eventBL.GetAllEvents());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddEvent")]
        public bool AddEvent([FromBody] EventDTO myEvent)
        {
            try
            {
                return _eventBL.AddEvent(myEvent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[HttpPost]
        //[Route("Login")]
        //public bool Login(string phone, string password)
        //{
        //    try
        //    {
        //        return _eventBL.Login(phone,password);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        [HttpPost]
        [Route("Login")]
        public Event Login(string phone, string password)
        {
            try
            {
                return _eventBL.Login(phone, password);

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
                return _eventBL.UpdateEvent(int.Parse(eventID), myEvent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
