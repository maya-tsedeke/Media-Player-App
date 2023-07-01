using MediaPlayerApp.Domain.Entities;

namespace MediaPlayerApp.Infrastructure.Persistence
{
    public class MediaFileRepository
    {
        private List<MediaFile> mediaFiles;

        public MediaFileRepository()
        {
            mediaFiles = new List<MediaFile>();
        }

        public void Add(MediaFile mediaFile)
        {
            mediaFiles.Add(mediaFile);
            Console.WriteLine($"Added media file: {mediaFile}");
        }

        public void Remove(MediaFile mediaFile)
        {
            mediaFiles.Remove(mediaFile);
            Console.WriteLine($"Removed media file: {mediaFile.FileName}");
        }

        public List<MediaFile> GetAll()
        {
            return mediaFiles;
        }
    }
}
