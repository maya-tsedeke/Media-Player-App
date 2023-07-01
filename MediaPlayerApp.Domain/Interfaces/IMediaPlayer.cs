namespace MediaPlayerApp.Domain.Interfaces
{
    public interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void Seek(TimeSpan position);
        // Add any additional methods as needed
        TimeSpan GetCurrentPosition();
        TimeSpan GetDuration();
    }
}
