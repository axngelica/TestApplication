using TestApplication.ViewModel;

namespace TestApplication.View;

public partial class TimeTrackerPage : ContentPage
{
	public TimeTrackerPage()
	{
		InitializeComponent();
		BindingContext = new TimeTrackerViewModel();
	}

    private void DateTimePicker_SelectedDateTimeChanged(object sender, EventArgs e)
    {
        var viewModel = BindingContext as TimeTrackerViewModel;
        viewModel.FirstArrival = firstArrival.SelectedDateTime;
    }
}