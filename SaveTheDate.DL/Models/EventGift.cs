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
        public int? GiftId { get; set; }
        public int EventId { get; set; }
        public int? UserId { get; set; }
        public bool? Status { get; set; }
        public string Blessing { get; set; }
        public string NewGift { get; set; }

        public virtual Event Event { get; set; }
        public virtual Gift Gift { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
