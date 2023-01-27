using System.ComponentModel;

namespace TestApplication.View;

public partial class DateTimePicker : ContentView, INotifyPropertyChanged
{
	public DateTimePicker()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty DateTimeProperty =
     BindableProperty.Create(nameof(DateTime), typeof(DateTime), typeof(DateTimePicker), DateTime.Now, BindingMode.TwoWay);


    public event EventHandler DateTimeUpdated;

    public DateTime DateTime
    {
        get => (DateTime)GetValue(DateTimeProperty);
        set
        {
            SetValue(DateTimeProperty, value);
            OnPropertyChanged("DateTime");
            DateTimeUpdated?.Invoke(this, EventArgs.Empty);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        DateTimeUpdated?.Invoke(this, EventArgs.Empty);
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime = new DateTime(e.NewDate.Year, e.NewDate.Month, e.NewDate.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
        DateTimeUpdated?.Invoke(this, EventArgs.Empty);
    }

    private void TimePicker_Unfocused(object sender, FocusEventArgs e)
    {
        DateTime = new DateTime(DateTime.Year, DateTime.Month, DateTime.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
        DateTimeUpdated?.Invoke(this, EventArgs.Empty);
    }

}