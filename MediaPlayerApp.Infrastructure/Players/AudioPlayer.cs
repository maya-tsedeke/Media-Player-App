namespace MediaPlayerApp.Infrastructure.Players
{
    public class AudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("Audio player: Play");
            // Implementation code for audio playback
        }

        public void Pause()
        {
            Console.WriteLine("Audio player: Pause");
            // Implementation code for pausing audio playback
        }

        public void Stop()
        {
            Console.WriteLine("Audio player: Stop");
            // Implementation code for stopping audio playback
        }

        public void Seek(TimeSpan position)
        {
            Console.WriteLine($"Audio player: Seek to {position}");
            // Implementation code for seeking audio playback
        }
    }
}
