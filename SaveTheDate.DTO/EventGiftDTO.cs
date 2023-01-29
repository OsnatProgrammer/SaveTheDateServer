using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class EventGiftDTO
    {
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

    }
}
