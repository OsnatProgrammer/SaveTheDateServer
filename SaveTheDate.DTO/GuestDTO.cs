using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class GuestDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public bool ArrivalConf { get; set; }
        public int? TableNum { get; set; }
        public int? BusId { get; set; }
        public int? GiftId { get; set; }

        public virtual BusDTO Bus { get; set; }
        public virtual EventDTO Event { get; set; }
        public virtual EventGiftDTO Gift { get; set; }
        public virtual TableDTO TableNumNavigation { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
