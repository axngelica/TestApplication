using TestApplication.View;

namespace TestApplication;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TimeTrackerPage();
	}
}
