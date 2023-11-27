using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace MauiApp2
{
	public static partial class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiApp<App>()
				   .UseMauiCommunityToolkit()
				   .UseMauiCommunityToolkitMarkup()
				   .ConfigureFonts(fonts =>
				   {
					   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					   fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				   });

#if DEBUG
			builder.Logging.AddDebug();
#endif

			MapCustomHandlers();
			return builder.Build();
		}

		private static void MapCustomHandlers()
		{
			MenuBarItemHandler.Mapper.ReplaceMapping(nameof(ICustomMenuBarItem.AccessKey), (IMenuBarItemHandler h, ICustomMenuBarItem v) =>
			{
#if WINDOWS
				h.PlatformView.AccessKey = v.AccessKey;
#endif
			});

			MenuFlyoutItemHandler.Mapper.ReplaceMapping(nameof(ICustomMenuFlyoutItem.AccessKey), (IMenuFlyoutItemHandler h, ICustomMenuFlyoutItem v) =>
			{
#if WINDOWS
				h.PlatformView.AccessKey = v.AccessKey;
#endif
			});

			EntryHandler.Mapper.ReplaceMapping(nameof(ICustomEntry.AccessKey), (IEntryHandler h, ICustomEntry v) =>
			{
#if WINDOWS
				h.PlatformView.AccessKey = v.AccessKey;
#endif
			});

			ButtonHandler.Mapper.ReplaceMapping(nameof(ICustomButton.AccessKey), (IButtonHandler h, ICustomButton v) =>
			{
#if WINDOWS
				h.PlatformView.AccessKey = v.AccessKey;
#endif
			});

			CheckBoxHandler.Mapper.ReplaceMapping(nameof(ICustomCheckBox.AccessKey), (ICheckBoxHandler h, ICustomCheckBox v) =>
			{
#if WINDOWS
				h.PlatformView.AccessKey = v.AccessKey;
#endif
			});
		}
	}
}
