using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private IBusBL BusBL;

        public BusController(IBusBL BusBL)
        {
            this.BusBL = BusBL;
        }


        [HttpGet]
        [Route("GetSumPersonInBus")]
        public int GetSumPersonInBus(int busNumber)
        {
            try
            {
                return BusBL.GetSumPersonInBus(busNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
