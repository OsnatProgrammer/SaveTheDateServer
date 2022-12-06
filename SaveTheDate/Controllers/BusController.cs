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
    }
}
