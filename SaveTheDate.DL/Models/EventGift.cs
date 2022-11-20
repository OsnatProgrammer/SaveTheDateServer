using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class EventGift
    {
        public EventGift()
        {
            Guests = new HashSet<Guest>();
        }

        public int Id { get; set; }
        public int GiftsId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public string Blessing { get; set; }

        public virtual Event Event { get; set; }
        public virtual Gift Gifts { get; set; }
        public virtual Guest User { get; set; }
        public virtual User UserNavigation { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
