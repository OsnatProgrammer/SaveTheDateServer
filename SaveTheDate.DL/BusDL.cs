using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class BusDL : IBusDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //  GET
        //שליפת רשימת הסעות 
        public List<Bus> GetAllBus()
        {
            try
            {
                return SaveTheDateContext.buses.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //שליפת כמות נוסעים לפי מספר אטובוס

        public int GetSumPersonInBus(int busNumber)
        {
            try
            {
                int personNumber = SaveTheDateContext.Guests.Where(x => x.Id.Equals(busNumber)).Count();
                return personNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST
        // הוספת הסעה לאירוע .
        public bool AddBus(Bus newBus)
        {
            try
            {
                SaveTheDateContext.Add(newBus);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // מחיקת הסעה 

    }
}
