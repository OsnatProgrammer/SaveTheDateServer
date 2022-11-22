using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IGiftDL
    {
        List<Gift> GetAllGift();
        public bool DeleteGift(string giftID);
        public bool AddGift(Gift newGift);
        public List<Gift> GetGiftsByEventType(int eventType);

    }
}