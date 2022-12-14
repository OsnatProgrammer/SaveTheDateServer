using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IGiftDL
    {

        List<Gift> GetAllGift();
        List<Gift> GetGiftsByEventType(int eventType);
    }
}