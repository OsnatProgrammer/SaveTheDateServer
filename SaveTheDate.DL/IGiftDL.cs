using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IGiftDL
    {

        List<Gift> GetAllGift();
        bool DeleteGift(string giftID);
        bool AddGift(Gift newGift);
        List<Gift> GetGiftsByEventType(int eventType);
        Gift GetGiftById(int v);
    }
}