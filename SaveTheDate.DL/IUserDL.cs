using SaveTheDate.DL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveTheDate.DL
{
    public interface IUserDL
    {
        List<User> GetAllUsers();
       Task<int> AddUser(User newUser);
    }
}