using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Event_Maker.Model
{
    public class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance = null;

        public ObservableCollection<Event> Events { get; set; }

        private EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();
            LoadEventAsync();
        }

        public static EventCatalogSingleton GetInstance()
        {
            if (_instance != null)
                return _instance;
            else
            {
                _instance = new EventCatalogSingleton();
                return _instance;
            }
        }

        public void LoadEventAsync()
        {
            Events.Add(new Event(1, "Shrink", "Need to see the shrink", "Køge", new DateTime(2016, 01, 29)));
        }

        public void AddEvent()
        {
            
        }

        public void DeleteEvent()
        {
            
        }

        public void EditEvent()
        {
            
        }
    }
}