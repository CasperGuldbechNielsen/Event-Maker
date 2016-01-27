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

        public Event(int id, string name, string description, string place, DateTime dateTime)
        {
            Id = id;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1} Description: {2} Place: {3} Date: {4}", Id, Name,
                Description, Place, DateTime);
        }
    }
}