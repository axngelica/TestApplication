using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Model;

namespace TestApplication.ViewModel
{
    public class TimeTrackerViewModel : INotifyPropertyChanged
    {
        private TimeTracker _model;
        public event PropertyChangedEventHandler PropertyChanged;

        public TimeTrackerViewModel()
        {
            _model = new TimeTracker();
        }
        public DateTime FirstArrival
        {
            get { return _model.FirstArrival; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentNullException("First Arrival is a required field");
                }
                _model.FirstArrival = value;
                OnPropertyChanged("FirstArrival");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime FirstDeparture
        {
            get { return _model.FirstDeparture; }
            set
            {
                _model.FirstDeparture = value;
                OnPropertyChanged("FirstDeparture");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime SecondArrival
        {
            get { return (DateTime)_model.SecondArrival; }
            set
            {
                _model.SecondArrival = value;
                OnPropertyChanged("SecondArrival");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime SecondDeparture
        {
            get { return (DateTime)_model.SecondDeparture; }
            set
            {
                _model.SecondDeparture = value;
                OnPropertyChanged("SecondDeparture");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime ThirdArrival
        {
            get { return (DateTime)_model.ThirdArrival; }
            set
            {
                _model.ThirdArrival = value;
                OnPropertyChanged("ThirdArrival");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime ThirdDeparture
        {
            get { return (DateTime)_model.ThirdDeparture; }
            set
            {
                _model.ThirdDeparture = value;
                OnPropertyChanged("ThirdDeparture");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime FourthArrival
        {
            get { return (DateTime)_model.FourthArrival; }
            set
            {
                _model.FourthArrival = value;
                OnPropertyChanged("FourthArrival");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        public DateTime FourthDeparture
        {
            get { return (DateTime)_model.FourthDeparture; }
            set
            {
                _model.FourthDeparture = value;
                OnPropertyChanged("FourthDeparture");
                OnPropertyChanged(nameof(TotalHours));
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public TimeSpan TotalHours
        {
            get
            {
                var earliestArrival = new[] { FirstArrival, SecondArrival, ThirdArrival, FourthArrival }.Min();
                var latestDeparture = new[] { FirstDeparture, SecondDeparture, ThirdDeparture, FourthDeparture }.Max();

                return latestDeparture - earliestArrival;
            }
        }
    }   
}
