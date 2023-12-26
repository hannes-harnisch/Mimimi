using AVFoundation;

using Foundation;

namespace Mimimi.iOS {

    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate {
        protected override MauiApp CreateMauiApp() {
            var audioSession = AVAudioSession.SharedInstance();
            _ = audioSession.SetActive(true);
            _ = audioSession.SetCategory(AVAudioSessionCategory.Playback);
            return Mimimi.Program.CreateMauiApp();
        }
    }

}
