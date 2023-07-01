using Microsoft.AspNetCore.Mvc.Formatters;

namespace MediaPlayerApp.Domain.Entities
{
    public class MediaFile
    {
        public string? FilePath { get; set; }
        public MediaType MediaType { get; set; }
        public TimeSpan Duration { get; set; }
        public string? FileName { get; set; }
    }
}