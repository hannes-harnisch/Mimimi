using Android.App;
using Android.Runtime;

namespace Mimimi.Android {

    [Application]
    public class MainApplication : MauiApplication {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership) {
        }

        protected override MauiApp CreateMauiApp() {
            return Program.CreateMauiApp();
        }
    }

}
