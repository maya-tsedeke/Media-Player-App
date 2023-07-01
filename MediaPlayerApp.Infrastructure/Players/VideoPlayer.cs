namespace MediaPlayerApp.Infrastructure.Players
{
    public class VideoPlayer
    {
        public void Play()
        {
            Console.WriteLine("Video player: Play");
            // Implementation code for video playback
        }

        public void Pause()
        {
            Console.WriteLine("Video player: Pause");
            // Implementation code for pausing video playback
        }

        public void Stop()
        {
            Console.WriteLine("Video player: Stop");
            // Implementation code for stopping video playback
        }

        public void Seek(TimeSpan position)
        {
            Console.WriteLine($"Video player: Seek to {position}");
            // Implementation code for seeking video playback
        }
    }
}
