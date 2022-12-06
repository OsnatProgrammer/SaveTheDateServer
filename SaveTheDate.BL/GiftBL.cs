using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using SaveTheDate.DL.Models;

namespace SaveTheDate.BL
{
    public class GiftBL : IGiftBL
    {

        IGiftDL _giftDL;
        IMapper mapper;

        public GiftBL(IGiftDL GiftDL)
        {
            this._giftDL = GiftDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<GiftDTO> GetAllGift()
        {
            List<Gift> Gift = _giftDL.GetAllGift();
            return mapper.Map<List<Gift>, List<GiftDTO>>(Gift);
        }


        public List<GiftDTO> GetGiftsByEventType(int eventType)
        {
            List<Gift> Gift = _giftDL.GetGiftsByEventType(eventType);
            return mapper.Map<List<Gift>, List<GiftDTO>>(Gift);
        }

        public bool AddGift(GiftDTO newGiftDTO)
        {
            Gift Gift = mapper.Map<GiftDTO, Gift>(NewGiftDTO);
            return _giftDL.AddGift(Gift);
        }

        public bool DeleteGift(string giftID)
        {
            return _giftDL.DeleteGift(giftID);
        }

        public Gift GetGiftById(int v)
        {
            return GiftDL.GetGiftById(v);
        }
    }
}
