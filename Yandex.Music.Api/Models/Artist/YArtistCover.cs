using Newtonsoft.Json;

namespace Yandex.Music.Api.Models.Artist;

public class YArtistCover
{
    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("prefix")] public string Prefix { get; set; }

    [JsonProperty("uri")] public string Uri { get; set; }

    internal static YArtistCover FromJson(string json)
    {
        return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject<YArtistCover>(json);
    }
}