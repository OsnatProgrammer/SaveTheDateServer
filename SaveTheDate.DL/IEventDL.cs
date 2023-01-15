using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IEventDL
    {
        bool AddEvent(Event newEvent);
        bool UpdateEvent(int eventID, Event myEvent);
        Event GetEventById(int eventID);
        List<Event> GetAllEvents();
        //bool Login(string phone, string password);
        Event Login(string phone, string password);

    }
}