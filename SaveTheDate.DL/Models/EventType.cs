using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Event>();
            Gifts = new HashSet<Gift>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Gift> Gifts { get; set; }
    }
}
