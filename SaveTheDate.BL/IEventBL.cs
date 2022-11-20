using SaveTheDate.DL.Models;
using SaveTheDate.DTO;


namespace SaveTheDate.BL
{
    public interface IEventBL
    {
        bool AddEvent(EventDTO newEventDTO);
        bool UpdateEvent(int EventID, EventDTO updaeteDetailsDTO);
        Event GetEventById(int eventID);
    }
}