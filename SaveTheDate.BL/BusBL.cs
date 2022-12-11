
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

        //GET
        public List<Bus> GetAllBusesOfEvent(int eventId)
        {
            return _busDL.GetAllBusesOfEvent(eventId);
        }
        public List<Bus> GetAllBus()
        {
            return _busDL.GetAllBus();
        }

        public int GetSumPersonInBus(int busNumber)
        {
            return _busDL.GetSumPersonInBus(busNumber);
        }

        public int EmptySeatsOnTheBus(int busNumber)
        {
            return _busDL.EmptySeatsOnTheBus(busNumber);
        }

        //PUT
        public bool UpdateRoute(int busId, string RouteToUpdate)
        {
            return _busDL.UpdateRoute(busId, RouteToUpdate);
        }

        public bool UpdateGuestToBus(int guestId, int busId)
        {
            return _busDL.UpdateGuestToBus(guestId, busId);
        }

        //POST
        public bool AddBus(Bus newBus)
        {
            return _busDL.AddBus(newBus);
        }

        //DELETE
        public bool deleteBus(int id)
        {
            return _busDL.deleteBus(id);
        }
    }
}
