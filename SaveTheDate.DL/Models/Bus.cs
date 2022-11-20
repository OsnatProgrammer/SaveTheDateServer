using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class Bus
    {
        public Bus()
        {
            Guests = new HashSet<Guest>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int SeatsNum { get; set; }
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }

        public virtual Event Event { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
