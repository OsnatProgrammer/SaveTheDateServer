using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IGiftBL
    {
        List<Gift> GetAllGift();
        List<Gift> GetGiftsByEventType(int eventType);
    }


}