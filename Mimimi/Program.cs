using CommunityToolkit.Maui;

namespace Mimimi {

    public static class Program {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement();

            return builder.Build();
        }
    }

}
