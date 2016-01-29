using System;
using Event_Maker.Converter;
using Event_Maker.ViewModel;

namespace Event_Maker.Handler
{
    public class EventHandler
    {

        private DateTime _dateTime;

        public EventViewModel EventViewModel { get; set; }

        public EventHandler(EventViewModel eventViewModel)
        {
            EventViewModel = eventViewModel;
        }

        public void CreateEvent()
        {
            _dateTime = DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel.Date, EventViewModel.Time);

            EventViewModel.MyCatalogSingleton.AddEvent(EventViewModel.Id, EventViewModel.Name, EventViewModel.Description, EventViewModel.Place, _dateTime);
        } 
    }
}