using SpotifyProjectClassLibrary.Models;
using SpotifyProjectClassLibrary.Repositories;
using System.Collections.Generic;

namespace SpotifyProjectClassLibrary.Services
{
    public class ProfileService
    {
        private readonly ProfileRepository _profileRepository;

        public ProfileService(ProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public List<Profile> GetAllProfiles()
        {
            return _profileRepository.GetAllProfiles();
        }

        // Qui puoi aggiungere altri metodi per la logica del profilo, come aggiornare, eliminare o cercare profili
    }
}
