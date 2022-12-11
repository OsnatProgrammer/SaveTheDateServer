using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class TableDL : ITableDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //GET
        // שליפת כל השולחנות בארוע
        public List<Table> GetAllTablesOfEvent(int eventId)
        {
            try
            {
                List<Table> allTablesOfEvent = SaveTheDateContext.Tables.Where(x => x.EventId.Equals(eventId)).ToList();
                return allTablesOfEvent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // שליפת השולחן ישיבה לפי מספר טלפון 
        public int GetTableByPhone(string phone, int eventId)
        {
            try
            {
                User myUser = SaveTheDateContext.Users.SingleOrDefault(x => x.Phone.Equals(phone));
                Guest myGuest = SaveTheDateContext.Guests.SingleOrDefault(x => x.UserId.Equals(myUser.Id) && x.EventId == eventId);
                return (int)myGuest.TableNum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //שליפת המוזמנים ששובצו
        public List<Guest> GetTakePlaceGuests(int eventId)
        {
            try
            {
                List<Guest> guestList = SaveTheDateContext.Guests.Where(x => x.TableNum != null && x.EventId == eventId).ToList();
                return guestList;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        //שליפת המוזמנים שלא שובצו 

        public List<Guest> GetNotTakePlaceGuests(int eventId)
        {
            try
            {
                List<Guest> guestList = SaveTheDateContext.Guests.Where(x => x.TableNum == null && x.ArrivalConf == true && x.EventId == eventId).ToList();
                return guestList;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }




        //שליפת כל שולחן עם שמות המוזמנים היושבים בו 

        public List<Guest> GuestsInTable(int tableNum)
        {
            try
            {
                List<Guest> guestList = SaveTheDateContext.Guests.Where(x => x.TableNum == tableNum).ToList();
                return guestList;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        //שליפת מספר השולחן ומקומות פנויים בכל אחד
        //באנגולר לקרוא לפונקציה שמחזירה את מספרי השולחנות עם מספר המקומות שמכילים
        //ואז לקרוא לפונקציה ששולפת את את רשימת האנשים בכל שולחן
        //לסכום אותם
        //ולחסר את התוצאה של כמות האנשים לשולחן מהכמות שהשולחן יכול להכיל 

        //POST
        //הוספת שולחן
        public bool AddTable(Table newTable)
        {
            try
            {
                SaveTheDateContext.Add(newTable);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT
        //עידכון אדם לשולחן
        public bool UpdateGuestToTable(int guestId, int tableNum)
        {
            try
            {
                Guest guestToUpdate = SaveTheDateContext.Guests.SingleOrDefault(x => x.UserId.Equals(guestId));
                guestToUpdate.TableNum = tableNum;
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE
        //מחיקת שולחן
        public bool DeleteTable(int id)
        {
            try
            {
                Table currentTableToDelete = SaveTheDateContext.Tables.SingleOrDefault(x => x.Id == id);
                SaveTheDateContext.Remove(currentTableToDelete);
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
