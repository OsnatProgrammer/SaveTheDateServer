using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class TableDTO
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int SeatsNum { get; set; }
        public string Description { get; set; }

        //public virtual Event Event { get; set; }
    }
}
