using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using SaveTheDate.DL.Models;



namespace SaveTheDate.BL
{
    public class EventBL : IEventBL
    {
        IEventDL EventDL;
        IMapper mapper;

        public EventBL(IEventDL eventDL)
        {
            this.EventDL = eventDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public Event GetEventById(int eventID)
        {
;
            return EventDL.GetEventById(eventID);
        }


        public bool AddEvent(EventDTO newEventDTO)
        {
            Event myEvent = mapper.Map<EventDTO, Event>(newEventDTO);
            return EventDL.AddEvent(myEvent);
        }

        public bool UpdateEvent(int eventID, EventDTO updateDetailsDTO)
        {
            Event Event = mapper.Map<EventDTO, Event>(updateDetailsDTO);
            return EventDL.UpdateEvent(eventID, Event);
        }




    }
}
