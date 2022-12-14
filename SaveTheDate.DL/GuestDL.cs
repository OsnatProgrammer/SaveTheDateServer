using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class GuestDL : IGuestDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //GET

        //שליפת כל המוזמנים לאירוע הזה
        public List<Guest> GetAllInvitedGuests(int id)
        {
            try
            {
                return SaveTheDateContext.Guests.Where(x => x.EventId == id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET
        //שליפת כל המוזמנים שאישרו הגעה
        public List<Guest> GetAllConfirmGuests(int id)
        {
            try
            {
                return SaveTheDateContext.Guests.Where(x => x.EventId == id && x.ArrivalConf == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET
        //שליפת כל המוזמנים שלא אישרו הגעה
        public List<Guest> GetAllUnConfirmGuests(int id)
        {
            try
            {
                return SaveTheDateContext.Guests.Where(x => x.EventId == id && x.ArrivalConf == false).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET
        //שליפת כל המזומנים שהתקבלו עד כה מהאורחים
        //לא קשור לכאן!!!
        //זה אמור להיות באוונט גיפט ואמור לעשות קישור לגיפט ובדוק את כל המתנות שהקטגוריה שלהן היא כסף
        public int GetAllCash(int eventId)
        {
            try
            {
                EventGift cash= SaveTheDateContext.EventGifts.SingleOrDefault(x => x.Id == eventId);
                Gift gift= cash.Gift;
       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // שליפת אורח לפי מספר טלפון -- יש אפשרות לשלוף פרטים על האורח כגון שולחן ישיבה ואוטובוס 
        public Guest GetGuestByPhone(string phone, int eventId)
        {
            try
            {
                Guest myGuest;
                User myUser = SaveTheDateContext.Users.SingleOrDefault(x => x.Phone.Equals(phone));
                return myGuest = SaveTheDateContext.Guests.SingleOrDefault(x => x.UserId.Equals(myUser.Id) && x.EventId == eventId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Event GetEventById(int eventID)
        {
            try
            {
                return SaveTheDateContext.Events.SingleOrDefault(x => x.Id == eventID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //POST
        //הוספת מוזמן בודד לרשימת מוזמנים בדטה בייס

        public bool AddGuest(Guest newGuest)
        {
            try
            {
                SaveTheDateContext.Add(newGuest);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //פונקציה נוספת
        //העלאת קובץ אקסל של רשימת מוזמנים שתכנס אוטומטית לדטה בייס


        //DELETE
        public bool DeleteGuest(int GuestID)
        {
            try
            {
                Guest currentGuestToDelete = SaveTheDateContext.Guests.SingleOrDefault(x => x.Id == GuestID);
                SaveTheDateContext.Remove(currentGuestToDelete);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
