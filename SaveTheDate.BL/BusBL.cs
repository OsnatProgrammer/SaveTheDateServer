using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.BL
{
    public class BusBL : IBusBL
    {
        IBusDL BusDL;
        IMapper mapper;

        public BusBL(IBusDL BusDL)
        {
            this.BusDL = BusDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public int GetSumPersonInBus(int busNumber)
        {
            return BusDL.GetSumPersonInBus(busNumber);
        }


    }
}
