using Microsoft.Maui.Handlers;

namespace MauiApp2
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			var window = base.CreateWindow(activationState);
			window.Title = typeof(App).Namespace;
			return window;
		}
	}
}
