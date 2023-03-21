using Microsoft.Maui.Controls;

namespace MurderMystery;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void NewGame(object sender, EventArgs e)
	{
		NewGamePage page = new NewGamePage();
		Navigation.PushAsync(page);
	}

	private void LoadGame(object sender, EventArgs e)
	{
		return;
	}
}

