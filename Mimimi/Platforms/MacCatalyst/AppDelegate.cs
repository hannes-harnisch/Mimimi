using Foundation;

namespace Mimimi.Mac {

    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate {
        protected override MauiApp CreateMauiApp() {
            return Mimimi.Program.CreateMauiApp();
        }
    }

}
