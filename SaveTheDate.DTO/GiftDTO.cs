﻿using System;
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
    }
}
