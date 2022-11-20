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
