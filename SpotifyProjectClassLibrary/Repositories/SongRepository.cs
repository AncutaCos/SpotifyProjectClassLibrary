using SpotifyProjectClassLibrary.Data;
using SpotifyProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Repositories
{
    public class SongRepository
    {
        private readonly CSVContext _csvContext;
        private readonly string _filePath;

        public SongRepository(CSVContext csvContext, string filePath)
        {
            _csvContext = csvContext;
            _filePath = filePath;
        }

        public List<Song> GetAllSongs()
        {
            return _csvContext.ReadCSVFile<Song>(_filePath);
        }

        // Altri metodi specifici per le operazioni relative alle canzoni
    }
}
