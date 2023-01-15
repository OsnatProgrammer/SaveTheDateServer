using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DL
{
    public class UserDL : IUserDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();


        //POST
        // הוספת משתמש
        public int AddUser(User newUser)
        {
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
