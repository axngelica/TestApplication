namespace TestApplication.View;

public partial class DateTimePicker : ContentView
{
	public DateTimePicker()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty SelectedDateTimeProperty =
    BindableProperty.Create(nameof(SelectedDateTime), typeof(DateTime), typeof(DateTimePicker), default(DateTime));

    public DateTime SelectedDateTime
    {
        get => (DateTime)GetValue(SelectedDateTimeProperty);
        set => SetValue(SelectedDateTimeProperty, value);
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        SelectedDateTime = new DateTime(e.NewDate.Year, e.NewDate.Month, e.NewDate.Day);
    }

    private void TimePicker_Unfocused(object sender, FocusEventArgs e)
    {
        SelectedDateTime = new DateTime(SelectedDateTime.Year, SelectedDateTime.Month, SelectedDateTime.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
    }


}