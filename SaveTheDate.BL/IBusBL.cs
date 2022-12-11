using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IBusBL
    {
        bool AddBus(Bus newBus);
        bool UpdateGuestToBus(int guestId, int busId);
        bool deleteBus(int id);
        int EmptySeatsOnTheBus(int busNumber);
        List<Bus> GetAllBus();
        List<Bus> GetAllBusesOfEvent(int eventId);
        int GetSumPersonInBus(int busNumber);
        bool UpdateRoute(int busId, string RouteToUpdate);
    }
}