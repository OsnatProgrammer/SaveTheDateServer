using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class Gift
    {
        public Gift()
        {
            EventGifts = new HashSet<EventGift>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int EventTypeId { get; set; }

        public virtual GiftCategory Category { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual ICollection<EventGift> EventGifts { get; set; }
    }
}
