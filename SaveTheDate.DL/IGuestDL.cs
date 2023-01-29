using SaveTheDate.DL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveTheDate.DL
{
    public interface IGuestDL
    {
        Task<bool> AddGuest(Guest newGuest);
        bool DeleteGuest(int GuestID);
      //  List<EventGift> GetAllCash(int id);
        List<Guest> GetAllConfirmGuests(int id);
        List<Guest> GetAllInvitedGuests(int id);
        List<Guest> GetAllUnConfirmGuests(int id);
        int GetAllConfirmGuestsCount(int id);
        Guest GetGuestByPhone(string phone, int eventId);
    }
}