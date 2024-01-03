using SpotifyProjectClassLibrary.Data;
using SpotifyProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProjectClassLibrary.Repositories
{
    public class PlaylistRepository
    {
        private readonly CSVContext _csvContext;
        private readonly string _filePath;

        public PlaylistRepository(CSVContext csvContext, string filePath)
        {
            _csvContext = csvContext;
            _filePath = filePath;
        }

        public List<Playlist> GetAllPlaylists()
        {
            return _csvContext.ReadCSVFile<Playlist>(_filePath);
        }

        // Metodi aggiuntivi se necessario
    }

}
