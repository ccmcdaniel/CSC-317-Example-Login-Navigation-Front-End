namespace Blah.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

	}

	private void GoToHome(object sender, EventArgs e)
	{
		//Change the current main page to the AppShell, which
		//in turn displays the tab menu.
		App.Current.MainPage = new AppShell();
	}
}