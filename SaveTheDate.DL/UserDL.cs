using Microsoft.EntityFrameworkCore;
using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheDate.DL
{
    public class UserDL : IUserDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //GET
        // שליפת כל המשתמשים
        public List<User> GetAllUsers()
        {
            try
            {
                return SaveTheDateContext.Users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST
        // הוספת משתמש
        public async Task<int> AddUser(User newUser)
        {
            var u = await SaveTheDateContext.Users.FirstOrDefaultAsync(u => u.Phone == newUser.Phone);
            if (u!=null)
            {
                return u.Id;
            }
            try
            {
                SaveTheDateContext.Add(newUser);
                SaveTheDateContext.SaveChanges();
                return newUser.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
