using System.Threading.Tasks;
using Yandex.Music.Api;
using Yandex.Music.Client.Endpoints;
using Yandex.Music.Client.Models;

namespace Yandex.Music.Client;

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

    public YandexTrackEndpoint Track { get; }
    public YandexPlaylistEndpoint Playlist { get; }
    public YandexArtistEndpoint Artist { get; }
    public YandexAlbumEndpoint Album { get; }
    public YandexUserEndpoint User { get; }
    public IYandexMusicApi Api { get; }
    public YandexAuthUser AuthUser { get; private set; }

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