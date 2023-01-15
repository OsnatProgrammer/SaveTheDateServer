
using SaveTheDate.DL;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using SaveTheDate.DL.Models;
using AutoMapper;

namespace SaveTheDate.BL
{
    public class EventBL : IEventBL
    {
        IEventDL _eventDL;
        IMapper mapper;

        public EventBL(IEventDL eventDL)
        {
            _eventDL = eventDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public Event GetEventById(int eventID)
        {
            return _eventDL.GetEventById(eventID);
        }

        public List<Event> GetAllEvents()
        {
            return _eventDL.GetAllEvents();
            
        }


        public bool AddEvent(EventDTO newEventDTO)
        {
            Event myEvent = mapper.Map<EventDTO, Event>(newEventDTO);
            myEvent.Id =0;
            myEvent.EventType = 1;
            myEvent.Date = DateTime.Now;
            //myEvent.Link = "hhh";
            //myEvent.Text = "hhh";
            //myEvent.Picture = "hhh";
            return _eventDL.AddEvent(myEvent);
        }
        //עובד בצורה בוליאנית
        //public bool Login(string phone, string password) 
        //{
        //    return _eventDL.Login(phone, password);
        //}

        public Event Login(string phone, string password)
        {
            return _eventDL.Login(phone, password);
        }
        public bool UpdateEvent(int eventID, EventDTO updateDetailsDTO)
        {
            Event Event = mapper.Map<EventDTO, Event>(updateDetailsDTO);
            return _eventDL.UpdateEvent(eventID, Event);
        }
    }
}
