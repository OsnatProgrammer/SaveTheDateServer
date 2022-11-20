using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class User
    {
        public User()
        {
            EventGifts = new HashSet<EventGift>();
            Events = new HashSet<Event>();
            Guests = new HashSet<Guest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<EventGift> EventGifts { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
