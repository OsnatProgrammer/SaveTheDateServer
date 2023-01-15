using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IEventBL
    {
        bool AddEvent(EventDTO newEventDTO);
        bool UpdateEvent(int EventID, EventDTO updaeteDetailsDTO);
        Event GetEventById(int eventID);
        List<Event> GetAllEvents();
        //bool Login(string phone, string password);
        Event Login(string phone, string password);

    }
}