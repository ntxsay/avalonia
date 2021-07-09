using System;
using LibVLCSharp.Shared;

namespace NotWorkigVideoView.ViewModels
{
    public class VideoViewUserControlViewModel : ViewModelBase, IDisposable
    {
        private readonly LibVLC _libVlc = new LibVLC();
        public VideoViewUserControlViewModel()
        {
            MediaPlayer = new MediaPlayer(_libVlc);
        }
        
        public void Play()
        {
            using var media = new Media(_libVlc, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            MediaPlayer.Play(media);
        }

        public MediaPlayer MediaPlayer { get; }

        public void Dispose()
        {
            MediaPlayer?.Dispose();
            _libVlc?.Dispose();
        }
    }
}