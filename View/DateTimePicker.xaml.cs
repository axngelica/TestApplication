using System.ComponentModel;

namespace TestApplication.View;

public partial class DateTimePicker : ContentView, INotifyPropertyChanged
{
	public DateTimePicker()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty SelectedDateTimeProperty =
    BindableProperty.Create(nameof(SelectedDateTime), typeof(DateTime), typeof(DateTimePicker), default(DateTime), BindingMode.TwoWay);

    public event EventHandler SelectedDateTimeChanged;

    public DateTime SelectedDateTime
    {
        get => (DateTime)GetValue(SelectedDateTimeProperty);
        set
        {
            SetValue(SelectedDateTimeProperty, value);
            OnPropertyChanged("SelectedDateTime");
            SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        SelectedDateTime = new DateTime(e.NewDate.Year, e.NewDate.Month, e.NewDate.Day);
        SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
    }

    private void TimePicker_Unfocused(object sender, FocusEventArgs e)
    {
        SelectedDateTime = new DateTime(SelectedDateTime.Year, SelectedDateTime.Month, SelectedDateTime.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
        SelectedDateTimeChanged?.Invoke(this, EventArgs.Empty);
    }

}