using CommunityToolkit.Maui.Views;

namespace Mimimi {

    enum Media {
        Feelings,
        MimimiNoMusic
    }

    public partial class MainPage : ContentPage {
        static readonly TimeSpan FeelingsBegin = TimeSpan.FromSeconds(9);

        private Media CurrentMedia = Media.Feelings;

        public MainPage() {
            InitializeComponent();
        }

        public void OnResetButton(object sender, EventArgs e) {
            OnReset();
        }

        public void OnToggleMediaButton(object sender, EventArgs e) {
            switch (CurrentMedia) {
                case Media.Feelings:
                    MediaPlayer.Source = MediaSource.FromResource("Mimimi.mp3");
                    CurrentMedia = Media.MimimiNoMusic;
                    ToggleMediaButton.Text = "Mit Musik";
                    break;

                case Media.MimimiNoMusic:
                    MediaPlayer.Source = MediaSource.FromResource("Feelings.mp4");
                    CurrentMedia = Media.Feelings;
                    ToggleMediaButton.Text = "Ohne Musik";
                    break;
            }
            OnReset();
        }

        public void OnMediaOpened(object sender, EventArgs e) {
            OnReset();
        }

        public void OnReset() {
            switch (CurrentMedia) {
                case Media.Feelings:
                    _ = MediaPlayer.SeekTo(FeelingsBegin);
                    break;

                case Media.MimimiNoMusic:
                    _ = MediaPlayer.SeekTo(TimeSpan.Zero);
                    break;
            }
            MediaPlayer.Play();
        }
    }

}
