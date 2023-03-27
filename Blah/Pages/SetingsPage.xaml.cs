namespace Blah.Pages;

public partial class SetingsPage : ContentPage
{
	public SetingsPage()
	{
		InitializeComponent();
	}

	private void ChangeColor(object sender, CheckedChangedEventArgs e)
	{
		RadioButton selected = (sender as RadioButton);
		Color textColor;
		Color backgroundColor;

		if (selected.Content.ToString() == "Red")
		{
			backgroundColor = Color.Parse("#552222");
			textColor = Color.Parse("#AA7777");
		}
		else if (selected.Content.ToString() == "Green")
		{
			backgroundColor = Color.Parse("#225522");
			textColor = Color.Parse("#77AA77");
		}
		else if (selected.Content.ToString() == "Blue")
		{
			backgroundColor = Color.Parse("#222255");
			textColor = Color.Parse("#7777AA");
		}
		else
		{
			backgroundColor = Color.Parse("#222222");
			textColor = Color.Parse("#AAAAAA");
		}

		BackgroundColor= backgroundColor;
		lblTitle.TextColor = textColor;
		rdoSelectRed.TextColor = textColor;
		rdoSelectGreen.TextColor = textColor;
		rdoSelectBlue.TextColor = textColor;
	}
}