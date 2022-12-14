using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IBusBL
    {
        bool AddBus(BusDTO newBusDTO);
        bool deleteBus(int id);
        int EmptySeatsOnTheBus(int busNumber);
        List<Bus> GetAllBus();
        List<Bus> GetAllBusesOfEvent(int eventId);
        int GetSumPersonInBus(int busNumber);
        bool UpdateGuestToBus(int guestId, int busId);
        bool UpdateRoute(int busId, string RouteToUpdate);
    }
}