using SaveTheDate.DL.Models;

namespace SaveTheDate.DL
{
    public interface IEventDL
    {
        bool AddEvent(Event newEvent);
        bool UpdateEvent(int eventID, Event myEvent);
        Event GetEventById(int eventID);
        bool Login(string phone, string password);
    }
}