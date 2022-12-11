using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IGuestDL
    {
        bool AddGuest(Guest newGuest);
        bool DeleteGuest(int GuestID);
        List<EventGift> GetAllCash(int id);
        List<Guest> GetAllConfirmGuests(int id);
        List<Guest> GetAllInvitedGuests(int id);
        List<Guest> GetAllUnConfirmGuests(int id);
    }
}