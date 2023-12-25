using AVFoundation;
using Foundation;

namespace Mimimi.iOS
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp()
		{
			AVAudioSession.SharedInstance().SetActive(true);
			AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.Playback);
			return Mimimi.Program.CreateMauiApp();
		}
	}
}
