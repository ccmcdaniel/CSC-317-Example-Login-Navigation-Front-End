namespace Blah;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//Change the startup page to be the LoginPage.
		MainPage = new Pages.LoginPage();
	}
}
