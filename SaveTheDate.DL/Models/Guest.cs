using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class Guest
    {
        public Guest()
        {
            EventGifts = new HashSet<EventGift>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public bool ArrivalConf { get; set; }
        public int? TableNum { get; set; }
        public int? BusId { get; set; }
        public int? GiftId { get; set; }

        public virtual Bus Bus { get; set; }
        public virtual Event Event { get; set; }
        public virtual EventGift Gift { get; set; }
        public virtual Table TableNumNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<EventGift> EventGifts { get; set; }
    }
}
