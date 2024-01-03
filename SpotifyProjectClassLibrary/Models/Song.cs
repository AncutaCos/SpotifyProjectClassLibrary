namespace SpotifyProjectClassLibrary.Models
{
    public class Song
    {
        public int Id { get; set; } // Assumi che l'ID sia un intero
        public int Rating { get; set; } // Assumi che il Rating sia un intero
        public string Title { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Playlist { get; set; }

        public int? PlaylistId { get; set; }
        

        // Aggiungi altri costruttori e metodi se necessario
    }
}
