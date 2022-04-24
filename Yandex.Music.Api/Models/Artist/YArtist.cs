using System.Collections.Generic;
using Newtonsoft.Json;

namespace Yandex.Music.Api.Models.Artist;

public class YArtist
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("various")] public bool Various { get; set; }

    [JsonProperty("composer")] public bool Composer { get; set; }

    [JsonProperty("cover")] public YArtistCover Cover { get; set; }

    [JsonProperty("genres")] public List<string> Genres { get; set; }

    internal static YArtist FromJson(string json)
    {
        return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject<YArtist>(json);
    }
}