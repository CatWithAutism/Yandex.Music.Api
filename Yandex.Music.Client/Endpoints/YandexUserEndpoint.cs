using System;
using System.Threading.Tasks;
using Yandex.Music.Api;

namespace Yandex.Music.Client.Endpoints;

public class YandexUserEndpoint
{
    private readonly IYandexMusicApi _api;

    public YandexUserEndpoint(IYandexMusicApi api)
    {
        _api = api;
    }

    public async Task SearchAsync(string searchText, int page = 0)
    {
        var response = await _api.SearchUsersAsync(searchText, page);

        Console.WriteLine("123");
    }
}