using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveTheDate.BL
{
    public interface IUserBL
    {
        List<User> GetAllUsers();
        Task<int> AddUser(UserDTO newUserDTO);
    }
}