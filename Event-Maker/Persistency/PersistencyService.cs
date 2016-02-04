using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Event_Maker.Model;
using Newtonsoft.Json;

namespace Event_Maker.Persistency
{
    public class PersistencyService
    {
        private static string jsonFileName = "EventAsJason1.dat";

        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {
            var eventsAsJsonString = JsonConvert.SerializeObject(events);
            SerializeEventsFileAsync(eventsAsJsonString, jsonFileName);
        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            string eventsJsonString = await DeSerializeEventsFileAsync(jsonFileName);
            if (eventsJsonString != null)
                return (List<Event>)JsonConvert.DeserializeObject(eventsJsonString, typeof(List<Event>));
            return null;
        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, eventsString);
        }

        public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {

                MessageDialogHelper.Show("Loading for the first time? Try Adding and Save some events before you are trying to Load events!", "File not found!");
                return null;
            }
        }

        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }

    }
}