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

        IGiftDL GiftDL;
        IMapper mapper;

        public GiftBL(IGiftDL GiftDL)
        {
            this.GiftDL = GiftDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<GiftDTO> GetAllGift()
        {
            List<Gift> Gift = GiftDL.GetAllGift();
            return mapper.Map<List<Gift>, List<GiftDTO>>(Gift);
        }


        public List<GiftDTO> GetGiftsByEventType(int eventType)
        {
            List<Gift> Gift = GiftDL.GetGiftsByEventType(eventType);
            return mapper.Map<List<Gift>, List<GiftDTO>>(Gift);
        }

        public bool AddGift(GiftDTO newGiftDTO)
        {
            Gift Gift = mapper.Map<GiftDTO, Gift>(newGiftDTO);
            return GiftDL.AddGift(Gift);
        }

        public bool DeleteGift(string giftID)
        {
            return GiftDL.DeleteGift(giftID);
        }

        public Gift GetGiftById(int v)
        {
            return GiftDL.GetGiftById(v);
        }
    }
}
