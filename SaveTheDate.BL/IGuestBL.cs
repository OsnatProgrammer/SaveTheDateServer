using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IGuestBL
    {
        bool AddGuest(GuestDTO newGuestDTO);
        bool DeleteGuest(int GuestID);
    //    List<EventGiftDTO> GetAllCash(int id);
        List<Guest> GetAllConfirmGuests(int id);
        List<Guest> GetAllInvitedGuests(int id);
        List<Guest> GetAllUnConfirmGuests(int id);
        Guest GetGuestByPhone(string phone, int eventId);
    }
}