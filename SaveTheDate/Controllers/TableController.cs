using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DTO;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {

        private ITableBL _tableBL;

        public TableController(ITableBL TableBL)
        {
            _tableBL = TableBL;
        }

        [HttpGet]
        [Route("GetAllTablesOfEvent/{eventId}")]
        public IActionResult  GetAllTablesOfEvent(int eventId)
        {
            try
            {
                return Ok(_tableBL.GetAllTablesOfEvent(eventId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetNotTakePlaceGuests/{eventId}")]
        public IActionResult GetNotTakePlaceGuests(int eventId)
        {
            try
            {
                return Ok(_tableBL.GetNotTakePlaceGuests(eventId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetTakePlaceGuests/{eventId}")]
        public IActionResult GetTakePlaceGuests(int eventId)
        {
            try
            {
                return Ok(_tableBL.GetTakePlaceGuests(eventId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GuestsInTable/{tableNum}")]
        public IActionResult GuestsInTable(int tableNum)
        {
            try
            {
                return Ok(_tableBL.GuestsInTable(tableNum));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddTable")]
        public bool AddTable([FromBody]TableDTO newTable)
        {
            try
            {
                return _tableBL.AddTable(newTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateGuestToTable/{guestId},{tableNum}")]
        public bool UpdateGuestToTable(int guestId, int tableNum)
        {
            try
            {
                return _tableBL.UpdateGuestToTable(guestId, tableNum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("DeleteTable/{id}")]
        public bool DeleteTable(int id)
        {
            try
            {
                return _tableBL.DeleteTable(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
