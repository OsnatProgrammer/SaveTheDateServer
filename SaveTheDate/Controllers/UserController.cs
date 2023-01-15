using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DTO;
using System;

namespace SaveTheDate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
            private IUserBL _UserBL;

            public UserController(IUserBL UserBL)
            {
                _UserBL = UserBL;
            }
            [HttpPost]
            [Route("AddUser")]
            public int AddUser(UserDTO newUser)
            {
                try
                {
                    return _UserBL.AddUser(newUser);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
}
