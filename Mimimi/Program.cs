using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Mimimi
{
	public static class Program
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseMauiCommunityToolkitMediaElement();

#if DEBUG
			builder.Logging.AddDebug();
#endif
			return builder.Build();
		}
	}
}
