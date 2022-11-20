using SaveTheDate.DL.Models;

namespace SaveTheDate.DL
{
    public interface IEventDL
    {
        bool AddEvent(Event newEvent);
        bool UpdateEvent(int eventID, Event myEvent);

        public Event GetEventById(int eventID);
    }
}