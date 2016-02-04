using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Event_Maker.Persistency;

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

        public async void LoadEventAsync()
        {
            var loadedEvents = await PersistencyService.LoadEventsFromJsonAsync();

            if (loadedEvents != null)
            {
                foreach (var item in loadedEvents)
                {
                    Events.Add(item);
                }
            }
        }

        public void AddEvent(int id, string name, string description, string place, DateTime dateTime)
        {
            Events.Add(new Event(id, name, description, place, dateTime));
            PersistencyService.SaveEventsAsJsonAsync(Events);
        }

        public void DeleteEvent(Event myEvent)
        {
            Events.Remove(myEvent);
            PersistencyService.SaveEventsAsJsonAsync(Events);
        }

        public void EditEvent()
        {
            
        }
    }
}