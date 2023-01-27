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
            _model.FirstArrival = DateTime.Today;
            _model.FirstDeparture = DateTime.Today;
        }
        public DateTime FirstArrival
        {
            get { return _model.FirstArrival; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.FirstArrival = value;
                    OnPropertyChanged("FirstArrival");
                    OnPropertyChanged(nameof(TotalHours));
                    ErrorMessage = string.Empty;
                }
                else
                {
                    ErrorMessage = "First Arrival is a required field.";
                }
            }
        }

        public DateTime FirstDeparture
        {
            get { return _model.FirstDeparture; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.FirstDeparture = value;
                    OnPropertyChanged("FirstDeparture");
                    OnPropertyChanged(nameof(TotalHours));
                    ErrorMessage = string.Empty;
                }
                else
                {
                    ErrorMessage = "First Departure is a required field.";
                }
            }
        }
        public DateTime? SecondArrival
        {
            get { return _model.SecondArrival; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.SecondArrival = value;
                    OnPropertyChanged("SecondArrival");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.SecondArrival = null;
                }
            }
        }
        public DateTime? SecondDeparture
        {
            get { return _model.SecondDeparture; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.SecondDeparture = value;
                    OnPropertyChanged("SecondDeparture");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.SecondDeparture = null;
                }
            }
        }
        public DateTime? ThirdArrival
        {
            get { return _model.ThirdArrival; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.ThirdArrival = value;
                    OnPropertyChanged("ThirdArrival");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.ThirdArrival = null;
                }
            }
        }
        public DateTime? ThirdDeparture
        {
            get { return _model.ThirdDeparture; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.ThirdDeparture = value;
                    OnPropertyChanged("ThirdDeparture");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.ThirdDeparture = null;
                }
            }
        }
        public DateTime? FourthArrival
        {
            get { return _model.FourthArrival; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.FourthArrival = value;
                    OnPropertyChanged("FourthArrival");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.FourthArrival = null;
                }
            }
        }
        public DateTime? FourthDeparture
        {
            get { return _model.FourthDeparture; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _model.FourthDeparture = value;
                    OnPropertyChanged("FourthDeparture");
                    OnPropertyChanged(nameof(TotalHours));
                }
                else
                {
                    _model.FourthDeparture = null;
                }
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
                var arrivals = new[] { FirstArrival, SecondArrival, ThirdArrival, FourthArrival }
                    .Where(a => a != null)
                    .Select(a => (DateTime)a);
                var departures = new[] { FirstDeparture, SecondDeparture, ThirdDeparture, FourthDeparture }
                    .Where(d => d != null)
                    .Select(d => (DateTime)d);

                var earliestArrival = arrivals.Min();
                var latestDeparture = departures.Max();

                return latestDeparture - earliestArrival;
            }
        }
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public int _totalMileage;
        public int TotalMileage
        {
            get { return _totalMileage; }
            set
            {
                _totalMileage = value;
                OnPropertyChanged("TotalMileage");
            }
        }
    }
}
