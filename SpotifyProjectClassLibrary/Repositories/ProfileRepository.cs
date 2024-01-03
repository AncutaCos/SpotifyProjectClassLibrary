using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Data;
using System.Collections.Generic;

namespace SpotifyProjectClassLibrary.Repositories
{
    public class ProfileRepository
    {
        private readonly CSVContext _csvContext;
        private readonly string _filePath;

        public ProfileRepository(CSVContext csvContext, string filePath)
        {
            _csvContext = csvContext;
            _filePath = filePath;
        }

        public List<Profile> GetAllProfiles()
        {
            // Assumi che i profili siano memorizzati in un file CSV e utilizza il CSVContext per leggerli
            return _csvContext.ReadCSVFile<Profile>(_filePath);
        }

        // Qui puoi aggiungere altri metodi per manipolare i dati dei profili, se necessario
    }
}
