namespace MediaPlayerApp.Domain.Interfaces
{
    public interface IVideoPlayer : IMediaPlayer
    {
        // Add any additional methods specific to video playback
        void SetPlaybackSpeed(float speed);
        float GetPlaybackSpeed();
        void SetSubtitleTrack(string track);
        string GetSubtitleTrack();
    }
}
