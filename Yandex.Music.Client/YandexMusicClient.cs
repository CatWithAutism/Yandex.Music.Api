using System.Threading.Tasks;
using Yandex.Music.Api;
using Yandex.Music.Client.Endpints;
using Yandex.Music.Client.Models;

namespace Yandex.Music.Client
{
    public class YandexMusicClient
    {
        public YandexMusicClient()
        {
            Api = new YandexMusicApi();

            Track = new YandexTrackEndpoint(Api);
            Playlist = new YandexPlaylistEndpoint(Api);
            Artist = new YandexArtistEndpoint(Api);
            Album = new YandexAlbumEndpoint(Api);
            User = new YandexUserEndpoint(Api);
        }

        public YandexTrackEndpoint Track { get; set; }
        public YandexPlaylistEndpoint Playlist { get; set; }
        public YandexArtistEndpoint Artist { get; set; }
        public YandexAlbumEndpoint Album { get; set; }
        public YandexUserEndpoint User { get; set; }
        public IYandexMusicApi Api { get; set; }
        public YandexAuthUser AuthUser { get; set; }

        public async Task<bool> AuthorizeAsync(string login, string password)
        {
            var response = await Api.AuthorizeAsync(login, password);
            var user = response.User;

            if (!response.IsAuthorized) return false;

            AuthUser = new YandexAuthUser
            {
                Uid = user.Uid,
                DeviceId = user.DeviceId,
                Experiments = user.Experiments,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Lang = user.Lang,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                Sign = user.Sign,
                YandexId = user.YandexId,
                Timestamp = user.Timestamp
            };

            return true;
        }
    }
}