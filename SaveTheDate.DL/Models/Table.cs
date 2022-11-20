using System;
using System.Collections.Generic;

#nullable disable

namespace SaveTheDate.DL.Models
{
    public partial class Table
    {
        public Table()
        {
            Guests = new HashSet<Guest>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int SeatsNum { get; set; }
        public string Description { get; set; }

        public virtual Event Event { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
