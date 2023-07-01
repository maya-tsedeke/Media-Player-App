using MediaPlayerApp.Domain.Entities;

namespace MediaPlayerApp.Infrastructure.Persistence
{
    public class PlaylistRepository
    {
        private List<Playlist> playlists;

        public PlaylistRepository()
        {
            playlists = new List<Playlist>();
        }

        public void Add(Playlist playlist)
        {
            playlists.Add(playlist);
            Console.WriteLine($"Added playlist: {playlist.Name}");
        }

        public void Remove(Playlist playlist)
        {
            playlists.Remove(playlist);
            Console.WriteLine($"Removed playlist: {playlist.Name}");
        }

        public List<Playlist> GetAll()
        {
            return playlists;
        }
    }
}
