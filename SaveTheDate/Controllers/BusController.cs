using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;

namespace SaveTheDate.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private IBusBL _busBL;

        public BusController(IBusBL BusBL)
        {
            _busBL = BusBL;
        }

        [HttpGet]
        [Route("GetAllBus")]
        public IActionResult GetAllBus()
        {
            try
            {
                return
                 Ok(_busBL.GetAllBus());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllBusesOfEvent")]
        public IActionResult GetAllBusesOfEvent(int eventId)
        {
            try
            {
                return Ok(_busBL.GetAllBusesOfEvent(eventId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetSumPersonInBus")]
        public IActionResult GetSumPersonInBus(int busNumber)
        {
            try
            {
                return Ok(_busBL.GetSumPersonInBus(busNumber));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("EmptySeatsOnTheBus")]
        public IActionResult EmptySeatsOnTheBus(int busNumber)
        {
            try
            {
                return Ok(_busBL.EmptySeatsOnTheBus(busNumber));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddBus")]
        public bool AddBus(BusDTO newBus)
        {
            try
            {
                return _busBL.AddBus(newBus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateRoute/{busId},{RouteToUpdate}")]
        public bool UpdateRoute(int busId, string RouteToUpdate)
        {
            try
            {
                return _busBL.UpdateRoute(busId, RouteToUpdate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateGuestToBus/{guestId},{busId}")]
        public bool UpdateGuestToBus(int guestId, int busId)
        {
            try
            {
                return _busBL.UpdateGuestToBus(guestId, busId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpDelete]
        [Route("DeleteBus")]
        public bool DeleteBus(int id)
        {
            try
            {
                return _busBL.deleteBus(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
