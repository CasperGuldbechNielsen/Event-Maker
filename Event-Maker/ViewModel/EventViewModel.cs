using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        public EventViewModel()
        {
            MyCatalogSingleton = EventCatalogSingleton.GetInstance();
            DateTime dateTime = System.DateTime.Now;
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


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}