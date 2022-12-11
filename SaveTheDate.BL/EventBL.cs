
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
;
            return _eventDL.GetEventById(eventID);
        }


        public bool AddEvent(EventDTO newEventDTO)
        {
            Event myEvent = mapper.Map<EventDTO, Event>(newEventDTO);
            return _eventDL.AddEvent(myEvent);
        }

        public bool UpdateEvent(int eventID, EventDTO updateDetailsDTO)
        {
            Event Event = mapper.Map<EventDTO, Event>(updateDetailsDTO);
            return _eventDL.UpdateEvent(eventID, Event);
        }
    }
}
