using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class Event
    {
        public Event()
        {
            Bus = new HashSet<Bus>();
            EventGifts = new HashSet<EventGift>();
            Guests = new HashSet<Guest>();
            Tables = new HashSet<Table>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string EventType { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Bus> Bus { get; set; }
        public virtual ICollection<EventGift> EventGifts { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
