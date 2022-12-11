using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IEventGiftBL
    {
        bool GetAGiftFromGuest(int EventGiftID, int userId, string blessing);
        List<EventGift> GetAllGivenGifts(int id);
        List<EventGift> GetAllUnGivenGifts(int id);
    }
}