using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IEventGiftDL
    {
        bool GetAGiftFromGuest(int eventGiftID, int userId, string blessing);
        List<EventGift> GetAllGivenGifts(int id);
        List<EventGift> GetAllUnGivenGifts(int id);
    }
}