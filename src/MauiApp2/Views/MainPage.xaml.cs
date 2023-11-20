using System.Reflection;

namespace MauiApp2.Views
{
	public partial class MainPage : ContentPage
	{
		private int _count = 0;

		public MainPage()
		{
			InitializeComponent();
			var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
			VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			_count++;
			CounterLabel.Text = $"Current count: {_count}";

			SemanticScreenReader.Announce(CounterLabel.Text);
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			if (sender is MenuFlyoutItem menu)
			{
				if (menu.ClassId == "exit")
				{
					if (await DisplayAlert(typeof(App).Namespace, "Are you sure?", "Yes", "No"))
					{
						Application.Current?.Quit();
					}
				}
				else if (menu.ClassId == "about")
				{
					await DisplayAlert(string.Empty, $"{typeof(App).Namespace} v{typeof(App).Assembly.GetName().Version}", "OK");
				}
			}
		}
	}
}
