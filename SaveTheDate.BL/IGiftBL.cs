using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IGiftBL
    {
        List<GiftDTO> GetAllGift();
        bool AddGift(GiftDTO NewGiftDTO);
        bool DeleteGift(string CoronaCode);

        List<GiftDTO> GetGiftsByEventType(int eventType);
        Gift GetGiftById(int v);
    }


}