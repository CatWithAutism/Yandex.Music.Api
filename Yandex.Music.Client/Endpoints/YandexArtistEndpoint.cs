using System;
using System.Threading.Tasks;
using Yandex.Music.Api;

namespace Yandex.Music.Client.Endpoints;

public class YandexArtistEndpoint
{
    private readonly IYandexMusicApi _api;

    public YandexArtistEndpoint(IYandexMusicApi api)
    {
        _api = api;
    }

    public async Task SearchAsync(string text, int page = 0)
    {
        var response = await _api.SearchArtistAsync(text, page);

        Console.WriteLine("123");
    }
}