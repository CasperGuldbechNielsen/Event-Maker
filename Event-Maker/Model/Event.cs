using System;

namespace Event_Maker.Model
{
    public class Event
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Place { get; set; }
        DateTime DateTime { get; set; }

        public Event()
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}