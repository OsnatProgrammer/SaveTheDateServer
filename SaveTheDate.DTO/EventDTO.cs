using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string EventType { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
    }
}
