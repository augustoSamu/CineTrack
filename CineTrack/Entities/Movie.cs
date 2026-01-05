namespace CineTrack.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Watched { get; set; }
        public DateTime WatchedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
