using MediaPlayerApp.Application.Enums;
using MediaPlayerApp.Domain.Interfaces;

namespace MediaPlayerApp.Application.Factories
{
    public class MediaPlayerFactory
    {
        private readonly IAudioPlayer _audioPlayer;
        private readonly IVideoPlayer _videoPlayer;

        public MediaPlayerFactory(IAudioPlayer audioPlayer, IVideoPlayer videoPlayer)
        {
            _audioPlayer = audioPlayer;
            _videoPlayer = videoPlayer;
        }

        public Dictionary<MediaType, IMediaPlayer> CreateMediaPlayers()
        {
            var mediaPlayers = new Dictionary<MediaType, IMediaPlayer>();
            mediaPlayers.Add(MediaType.Audio, _audioPlayer);
            mediaPlayers.Add(MediaType.Video, _videoPlayer);
            // Add any additional media player types as needed
            return mediaPlayers;
        }
    }
}
