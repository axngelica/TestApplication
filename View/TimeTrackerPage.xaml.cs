using TestApplication.ViewModel;

namespace TestApplication.View;

public partial class TimeTrackerPage : ContentPage
{
	public TimeTrackerPage()
	{
		InitializeComponent();
		BindingContext = new TimeTrackerViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var selectedDateTime = dateTimePicker.SelectedDateTime;
        System.Diagnostics.Debug.WriteLine("Selected Date Time: " + selectedDateTime);
    }
}