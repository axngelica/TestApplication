using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.ViewModel
{
    public class TimeTrackerViewModel : INotifyPropertyChanged
    {
        private DateTime selectedDateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public TimeTrackerViewModel()
        {
            selectedDateTime = DateTime.Now;
        }
        public DateTime SelectedDateTime
        {
            get { return selectedDateTime; }
            set
            {
                selectedDateTime = value;
                OnPropertyChanged("SelectedDateTime");
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }   
}
