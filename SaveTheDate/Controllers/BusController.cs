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
    public class BusController : ControllerBase
    {
        private IBusBL _busBL;

        public BusController(IBusBL BusBL)
        {
            _busBL = BusBL;
        }


        [HttpGet]
        [Route("GetAllBus")]
        public List<Bus> GetAllBus() 
        {
            try
            {
                return _busBL.GetAllBus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetAllBusesOfEvent")]
        public List<Bus> GetAllBusesOfEvent(int eventId)
        {
            try
            {
                return _busBL.GetAllBusesOfEvent(eventId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetSumPersonInBus")]
        public int GetSumPersonInBus(int busNumber)
        {
            try
            {
                return _busBL.GetSumPersonInBus(busNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("EmptySeatsOnTheBus")]
        public int EmptySeatsOnTheBus(int busNumber)
        {
            try
            {
                return _busBL.EmptySeatsOnTheBus(busNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("AddBus")]
        public bool AddBus(Bus newBus)
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
        public bool UpdateRoute(int guestId, int busId)
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
        [Route("deleteBus")]
        public bool deleteBus(int id)
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
