using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IGiftDL
    {

        List<Gift> GetAllGift();
        Gift GetGiftById(int v);
        public List<Gift> GetGiftsByEventType(int eventType);
    }
}