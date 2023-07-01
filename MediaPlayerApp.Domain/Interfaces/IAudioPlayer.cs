namespace MediaPlayerApp.Domain.Interfaces
{
    public interface IAudioPlayer : IMediaPlayer
    {
        // Add any additional methods specific to audio playback
        void SetVolume(float volume);
        float GetVolume();
    }
}
