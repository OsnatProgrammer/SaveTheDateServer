using System;
using System.Collections.Generic;
using System.Text;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;

namespace SaveTheDate.DTO
{
    public class AutoMapperProfile:AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap <BusDTO, Bus> ();
            CreateMap<Bus, BusDTO>();

            CreateMap<EventDTO, Event>();
            CreateMap<Event, EventDTO>();

            CreateMap<EventGiftDTO, EventGift>();
            CreateMap<EventGift, EventGiftDTO>();

            CreateMap<EventTypeDTO, EventType>();
            CreateMap<EventType, EventTypeDTO>();

            CreateMap<GiftCategoryDTO, GiftCategory>();
            CreateMap<GiftCategory, GiftCategoryDTO>();

            CreateMap<GiftDTO, Gift>();
            CreateMap<Gift, GiftDTO>();

            CreateMap<GuestDTO, Guest>();
            CreateMap<Guest, GuestDTO>();

            CreateMap<TableDTO, Table>();
            CreateMap<Table, TableDTO>();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

        }
    } 
}
