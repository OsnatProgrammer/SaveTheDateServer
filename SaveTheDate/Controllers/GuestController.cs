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
    public class GuestController : ControllerBase
    {
            private IGuestBL _guestBL;

            public GuestController(IGuestBL GuestBL)
            {
                _guestBL = GuestBL;
            }


            [HttpGet]
            [Route("GetAllCash/{id}")]
            public IActionResult GetAllCash(int id)
            {
                try
                {
                    return
                    Ok(_guestBL.GetAllCash(id));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpGet]
            [Route("GetAllConfirmGuests/{id}")]
            public IActionResult GetAllConfirmGuests(int id)
            {
                try
                {
                    return
                    Ok(_guestBL.GetAllConfirmGuests(id));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpGet]
            [Route("GetAllInvitedGuests/{id}")]
            public IActionResult GetAllInvitedGuests(int id)
            {
                try
                {
                    return
                    Ok(_guestBL.GetAllInvitedGuests(id));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpGet]
            [Route("GetAllUnConfirmGuests/{id}")]
            public IActionResult GetAllUnConfirmGuests(int id)
            {
                try
                {
                    return
                    Ok(_guestBL.GetAllUnConfirmGuests(id));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }


            [HttpPost]
            [Route("AddGuest")]
            public bool AddGuest(GuestDTO newGuestDTO)
            {
                try
                {
                    return
                    _guestBL.AddGuest(newGuestDTO);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        [HttpDelete]
            [Route("DeleteGuest")]
            public bool DeleteGuest(int GuestID)
            {
                try
                {
                    return
                    _guestBL.DeleteGuest(GuestID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        [HttpGet]
        [Route("GetGuestByPhone")]
        public ActionResult<Guest> GetGuestByPhone(string phone, int eventId)
        {
            try
            {
                return _guestBL.GetGuestByPhone(phone, eventId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
