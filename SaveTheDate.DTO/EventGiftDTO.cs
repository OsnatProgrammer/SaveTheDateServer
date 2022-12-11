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

    }
}
