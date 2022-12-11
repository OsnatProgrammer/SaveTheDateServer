using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class TableDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //GET
        // שליפת כל השולחנות בארוע
        public List<Table> GetAllTableesOfEvent(int eventId)
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
        public int GetTableOfPhone(string phone)
        {
            try
            {
                User userFind = SaveTheDateContext.Users.SingleOrDefault(x => x.Phone.Equals(phone));
                Guest guestFind = SaveTheDateContext.Guests.SingleOrDefault(x => x.UserId.Equals(userFind.Id));
                return (int)guestFind.TableNum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //שליפת המוזמנים ששובצו
        public List<string> GetGuest()
        {
            List<Guest> guestList = (List<Guest>)SaveTheDateContext.Guests.Where(x => x.TableNum!=null));

        }


        //שליפת המוזמנים שלא שובצו 
        //שליפת מספר השולחן ומקומות פנויים בכל אחד
        //שליפת כל שולחן עם שמות המוזמנים היושבים בו 


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
        public bool deleteTable(int id)
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
