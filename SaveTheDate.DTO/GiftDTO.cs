﻿using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class GiftDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int EventTypeId { get; set; }

        public virtual GiftCategory Category { get; set; }
        public virtual EventType EventType { get; set; }
    }
}
