using Foundation;

namespace Mimimi
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => Program.CreateMauiApp();
    }
}
