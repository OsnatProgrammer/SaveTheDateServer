using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class EventDL : IEventDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();


        // GET
        // שליפה אירוע 
        public  Event GetEventById(int eventID)
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

        //שליפת כל האירועים
        public List<Event> GetAllEvents()
        {
            try
            {
                return SaveTheDateContext.Events.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST
        // הוספת אירוע.
        public bool AddEvent(Event newEvent)
        {
            try
            {
                SaveTheDateContext.Add(newEvent);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //עובד בוליאני
        //public bool Login(string phone,string password)
        //{
        //    try
        //    {
        //        User myUser = new User();
        //        Event myEvent =new Event();

        //        myUser = SaveTheDateContext.Users.SingleOrDefault(x => x.Phone == phone);
        //        if(myUser != null)  
        //        myEvent = SaveTheDateContext.Events.SingleOrDefault(x => x.Password == password);
        //        if (myEvent != null)
        //            if (myUser.Id.Equals(myEvent.UserId))
        //            return true;
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Event Login(string phone, string password)
        {
            try
            {
                User myUser = new User();
                Event myEvent = new Event();

                myUser = SaveTheDateContext.Users.SingleOrDefault(x => x.Phone == phone);
                if (myUser != null)
                    myEvent = SaveTheDateContext.Events.SingleOrDefault(x => x.Password == password);
                if (myEvent != null)
                    if (myUser.Id.Equals(myEvent.UserId))
                        return myEvent;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT
        //עדכון פרטי אירוע
        public bool UpdateEvent(int eventID, Event myEvent)
        {
            try
            {
                Event currentEventToUpdate = SaveTheDateContext.Events.SingleOrDefault(x => x.Id == eventID);
                SaveTheDateContext.Entry(currentEventToUpdate).CurrentValues.SetValues(myEvent);
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
