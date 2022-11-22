using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IGiftBL
    {
        List<GiftDTO> GetAllGift();
        public bool AddGift(GiftDTO NewGiftDTO);
        public bool DeleteGift(string CoronaCode);

        public List<GiftDTO> GetGiftsByEventType(int eventType);

    }


}