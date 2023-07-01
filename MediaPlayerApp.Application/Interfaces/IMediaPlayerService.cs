using MediaPlayerApp.Domain.Entities;

namespace MediaPlayerApp.Application.Interfaces
{
    public interface IMediaPlayerService
    {
        void Play(MediaFile mediaFile);
        void Pause(MediaFile mediaFile);
        void Stop(MediaFile mediaFile);
        void Seek(MediaFile mediaFile, TimeSpan position);
        // Add any additional methods for media management and playlist management
    }
}
