using TestApplication.ViewModel;

namespace TestApplication.View;

public partial class TimeTrackerPage : ContentPage
{
	public TimeTrackerPage()
	{
		InitializeComponent();
		BindingContext = new TimeTrackerViewModel();
	}

    private void NumericValidation(object sender, TextChangedEventArgs e)
    {
        if (String.IsNullOrEmpty(e.NewTextValue) || !Int32.TryParse(e.NewTextValue, out int result))
        {
            //display error message or not.
            if (!String.IsNullOrEmpty(e.NewTextValue))
            {
                DisplayAlert("Error", "Invalid entry, please enter an integer.", "OK");
            }
        }
    }


}