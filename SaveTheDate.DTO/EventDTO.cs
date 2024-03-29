﻿using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventType { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }

        public virtual EventType EventTypeNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
