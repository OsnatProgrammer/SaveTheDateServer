using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
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
            _giftDL = GiftDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        public List<Gift> GetAllGift()
        {
            return _giftDL.GetAllGift();
        }

        public List<Gift> GetGiftsByEventType(int eventType)
        {
            return _giftDL.GetGiftsByEventType(eventType);
        }


    }
}
