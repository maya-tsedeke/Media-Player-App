using MediaPlayerApp.Application.Enums;
using MediaPlayerApp.Application.Factories;
using MediaPlayerApp.Application.Interfaces;
using MediaPlayerApp.Domain.Entities;

namespace MediaPlayerApp.Application.Services
{
    public class MediaPlayerService : IMediaPlayerService
    {
        private readonly Dictionary<MediaType, IMediaPlayer> _mediaPlayers;

        public MediaPlayerService(MediaPlayerFactory mediaPlayerFactory)
        {
            _mediaPlayers = mediaPlayerFactory.CreateMediaPlayers();
        }

        public void Play(MediaFile mediaFile)
        {
            if (_mediaPlayers.TryGetValue(mediaFile.MediaType, out var mediaPlayer))
            {
                mediaPlayer.Play();
                // Implement code to display current playback status, position, and duration
            }
            else
            {
                throw new NotSupportedException($"Media type '{mediaFile.MediaType}' is not supported.");
            }
        }

        public void Pause(MediaFile mediaFile)
        {
            if (_mediaPlayers.TryGetValue(mediaFile.MediaType, out var mediaPlayer))
            {
                mediaPlayer.Pause();
            }
            else
            {
                throw new NotSupportedException($"Media type '{mediaFile.MediaType}' is not supported.");
            }
        }

        public void Stop(MediaFile mediaFile)
        {
            if (_mediaPlayers.TryGetValue(mediaFile.MediaType, out var mediaPlayer))
            {
                mediaPlayer.Stop();
            }
            else
            {
                throw new NotSupportedException($"Media type '{mediaFile.MediaType}' is not supported.");
            }
        }

        public void Seek(MediaFile mediaFile, TimeSpan position)
        {
            if (_mediaPlayers.TryGetValue(mediaFile.MediaType, out var mediaPlayer))
            {
                mediaPlayer.Seek(position);
            }
            else
            {
                throw new NotSupportedException($"Media type '{mediaFile.MediaType}' is not supported.");
            }
        }

        // Implement methods for media management, such as adding, removing, and organizing media files
        // Implement methods for managing playlists
    }
}
