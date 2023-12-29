using CommunityToolkit.Maui.Views;

namespace Mimimi {

    enum Media {
        Feelings,
        MimimiNoMusic
    }

    public partial class MainPage : ContentPage {
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
                    LoudMimimiButton.IsEnabled = false;
                    VeryLoudMimimiButton.IsEnabled = false;
                    break;

                case Media.MimimiNoMusic:
                    MediaPlayer.Source = MediaSource.FromResource("Feelings.mp4");
                    CurrentMedia = Media.Feelings;
                    ToggleMediaButton.Text = "Ohne Musik";
                    LoudMimimiButton.IsEnabled = true;
                    VeryLoudMimimiButton.IsEnabled = true;
                    break;
            }
            OnReset();
        }

        public void OnLoudMimimiButton(object sender, EventArgs e) {
            if (CurrentMedia == Media.Feelings) {
                _ = MediaPlayer.SeekTo(TimeSpan.FromSeconds(42));
                MediaPlayer.Play();
            }
        }

        public void OnVeryLoudMimimiButton(object sender, EventArgs e) {
            if (CurrentMedia == Media.Feelings) {
                _ = MediaPlayer.SeekTo(TimeSpan.FromSeconds(59));
                MediaPlayer.Play();
            }
        }

        public void OnMediaOpened(object sender, EventArgs e) {
            OnReset();
        }

        public void OnReset() {
            switch (CurrentMedia) {
                case Media.Feelings:
                    _ = MediaPlayer.SeekTo(TimeSpan.FromSeconds(9));
                    break;

                case Media.MimimiNoMusic:
                    _ = MediaPlayer.SeekTo(TimeSpan.Zero);
                    break;
            }
            MediaPlayer.Play();
        }
    }

}
