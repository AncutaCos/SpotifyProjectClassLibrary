using SpotifyProjectClassLibrary.Services;
using SpotifyProjectClassLibrary.Data;
using SpotifyProjectClassLibrary.Repositories;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Configurazione iniziale: percorsi dei file CSV, creazione dei repository e dei servizi
        string songsCsvFilePath = "Data/songs.csv";
        var csvContext = new CSVContext();
        var songRepository = new SongRepository(csvContext, songsCsvFilePath);
        var musicService = new MusicService(songRepository);

        while (true)
        {
            Console.WriteLine("Scegli un'opzione:");
            Console.WriteLine("1. Visualizza Artisti");
            Console.WriteLine("2. Visualizza Canzoni");
            Console.WriteLine("3. Visualizza Playlist");
            Console.WriteLine("4. Visualizza Album");
            Console.WriteLine("Q. Esci");
            Console.Write("Inserisci la tua scelta: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Implementa la logica per visualizzare gli artisti
                    break;
                case "2":
                    DisplaySongs(musicService);
                    break;
                case "3":
                    // Implementa la logica per visualizzare le playlist
                    break;
                case "4":
                    // Implementa la logica per visualizzare gli album
                    break;
                case "Q":
                case "q":
                    return;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }

    static void DisplaySongs(MusicService musicService)
    {
        var songs = musicService.GetAllSongs();
        foreach (var song in songs)
        {
            Console.WriteLine($"ID: {song.Id}, Titolo: {song.Title}, Artista: {song.Artist}, Genere: {song.Genre}");
        }
    }

    // Aggiungi metodi simili per artisti, playlist e album
}
