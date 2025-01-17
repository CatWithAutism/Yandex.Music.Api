using System;
using System.Threading.Tasks;
using Yandex.Music.Api;

namespace Yandex.Music.Client.Endpoints;

public class YandexTrackEndpoint
{
    private readonly IYandexMusicApi _api;

    public YandexTrackEndpoint(IYandexMusicApi api)
    {
        _api = api;
    }

    public async Task SearchTrackAsync(string searchText, int page = 0)
    {
        var response = await _api.SearchTrackAsync(searchText, page);

        Console.WriteLine("123");
    }
}