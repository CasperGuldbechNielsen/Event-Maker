using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Event_Maker.Common;
using Event_Maker.Model;

namespace Event_Maker.ViewModel
{
    public class EventViewModel : INotifyPropertyChanged
    {

        private int _id;
        private string _name;
        private string _description;
        private string _place;
        private DateTimeOffset _date;
        private TimeSpan _time;

        public EventCatalogSingleton MyCatalogSingleton { get; set; }

        private ICommand _createEventCommand;

        public Handler.EventHandler EventHandler { get; set; }

        public EventViewModel()
        {
            MyCatalogSingleton = EventCatalogSingleton.GetInstance();
            DateTime dateTime = DateTime.Now;
            _date = new DateTimeOffset(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dateTime.Hour, dateTime.Minute, dateTime.Second);

            EventHandler = new Handler.EventHandler(this);

            _createEventCommand = new RelayCommand(EventHandler.CreateEvent);

        }

        public int Id
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged();
                }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged();
                }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value;
                OnPropertyChanged();
                }
        }

        public string Place
        {
            get { return _place; }
            set { _place = value;
                OnPropertyChanged();
                }
        }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value;
                OnPropertyChanged();
                }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value;
                OnPropertyChanged();
                }
        }

        public ICommand CreateEventCommand
        {
            get {
                    if (_createEventCommand == null)
                    {
                        _createEventCommand = new RelayCommand(EventHandler.CreateEvent);
                    } return _createEventCommand;
                }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}