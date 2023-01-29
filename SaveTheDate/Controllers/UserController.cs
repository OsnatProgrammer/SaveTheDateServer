using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveTheDate.BL;
using SaveTheDate.DTO;
using System;
using System.Threading.Tasks;

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

         [HttpGet]
         [Route("GetAllUsers")]
         public IActionResult GetAllUsers()
         {
             try
             {
                 return
                 Ok(_UserBL.GetAllUsers());
             }
             catch (Exception ex)
             {
                 return StatusCode(500, ex.Message);
             }
         }


        [HttpPost]
            [Route("AddUser")]
            public async Task<int> AddUser(UserDTO newUser)
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
