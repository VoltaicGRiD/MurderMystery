using System.Collections.ObjectModel;

namespace MurderMystery;

public partial class NewGamePage : ContentPage
{
	private ObservableCollection<string> _TimePeriods = new ObservableCollection<string>();
	public ObservableCollection<string> TimePeriods { get { return _TimePeriods; } }

	private ObservableCollection<string> _Settings = new ObservableCollection<string>();
	public ObservableCollection<string> Settings { get { return _Settings; } }

    public NewGamePage()
	{
		_TimePeriods = GetTimePeriods();
		BindingContext = this;
		InitializeComponent();
	}

	private ObservableCollection<string> GetTimePeriods()
	{
        ObservableCollection<string> options = new ObservableCollection<string>();
		options.Add("Medieval Times");
		options.Add("The Golden Age");
		options.Add("Modern Day");
		options.Add("Near Future");
		options.Add("Sci-fi");
		return options;
	}

    private void PlayerCountChanged(object sender, ValueChangedEventArgs e)
    {
		PlayerCount.Text = Math.Round(e.NewValue).ToString() + " Players";
    }

    private void TimePeriodPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        _Settings.Clear();

		Picker origin = (Picker)sender;
		switch (origin.SelectedItem)
		{
			case "Medieval Times":
				_Settings.Add("The Royal Court");
				_Settings.Add("The Abbey");
                _Settings.Add("The Witch Hunt");
                _Settings.Add("The Jousting Tournament");
                _Settings.Add("The Treasure Hunt");
                break;
			case "The Golden Age":
                _Settings.Add("The Pirate's Life");
                _Settings.Add("The Wild West");
                _Settings.Add("The Renaissance");
                _Settings.Add("The Age of Exploration");
                _Settings.Add("The Arabian Nights");
                break;
			case "Modern Day":
                _Settings.Add("The Heist");
                _Settings.Add("The Serial Killer");
                _Settings.Add("The Political Conspiracy");
                _Settings.Add("The Reality TV Show");
                _Settings.Add("The Art Forgery");
                break;
			case "Near Future":
                _Settings.Add("The Biological Attack");
                _Settings.Add("The Cyber Attack");
                _Settings.Add("The Asteroid Impact");
                _Settings.Add("The Alien INvasion");
                _Settings.Add("The Time Travel Paradox");
                break;
			case "Sci-fi":
                _Settings.Add("The Hidden Planet");
                _Settings.Add("The Rogue AI");
                _Settings.Add("The Alien Visitation");
                _Settings.Add("The Moon Crash");
                _Settings.Add("The Federation Defense");
                break;
		}

        StackLayout layout = new StackLayout();
        Grid.Children.Add(layout);

        Picker settingsPicker = new Picker();
        settingsPicker.ItemsSource = Settings;
        settingsPicker.TextColor = Color.Parse("White");
        settingsPicker.SelectedIndexChanged += SettingsPicker_SelectedIndexChanged;
        layout.Children.Add(settingsPicker);

        Label settingsLabel = new Label();
        settingsLabel.Text = "What Setting or Theme?";
        settingsLabel.TextColor = Color.Parse("White");
        settingsLabel.VerticalOptions = LayoutOptions.Center;
        settingsLabel.HorizontalOptions = LayoutOptions.Center;
        layout.Children.Add(settingsLabel);
	}

    private void SettingsPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        StackLayout layout = new StackLayout();
        Grid.Children.Add(layout);

        Picker solutionPicker = new Picker();
        solutionPicker.Items.Add("One Initiator, No Accomplices (Simplist)");
        solutionPicker.Items.Add("One Initiator, One Accomplice (Easiest)");
        solutionPicker.Items.Add("One Initiator, Multiple Accomplices (Intricate)");
        solutionPicker.Items.Add("No Initiator, One Accomplice (Hardest)");
        solutionPicker.TextColor = Color.Parse("White");
        layout.Children.Add(solutionPicker);

        Label settingsLabel = new Label();
        settingsLabel.Text = "What Solution / Difficulty?";
        settingsLabel.TextColor = Color.Parse("White");
        settingsLabel.VerticalOptions = LayoutOptions.Center;
        settingsLabel.HorizontalOptions = LayoutOptions.Center;
        layout.Children.Add(settingsLabel);

        Button infoBtn = new Button();
        infoBtn.Text = "What are my options?";
        infoBtn.Margin = new Thickness(0, 10, 0, 0);
        infoBtn.Clicked += InfoBtn_Clicked;
        layout.Children.Add(infoBtn);
    }

    private async void InfoBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.microsoft.com");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to open your browser. Please visit this link manually: {"https://www.microsoft.com"}", "OK");
        }
    }
}