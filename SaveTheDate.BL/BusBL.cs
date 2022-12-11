
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
        IBusDL _busDL;
        IMapper mapper;

        public BusBL(IBusDL BusDL)
        {
            _busDL = BusDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<Bus> GetAllBus()
        {
            return _busDL.GetAllBus();
        }

        public int GetSumPersonInBus(int busNumber)
        {
            return _busDL.GetSumPersonInBus(busNumber);
        }

    }
}
