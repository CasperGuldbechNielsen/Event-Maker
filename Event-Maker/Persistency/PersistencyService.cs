using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Event_Maker.Model;

namespace Event_Maker.Persistency
{
    public class PersistencyService
    {
        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {
            
        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            
        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            
        }

        public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        {
            
        }

    }
}