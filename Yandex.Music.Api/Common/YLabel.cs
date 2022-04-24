using Newtonsoft.Json;

namespace Yandex.Music.Api.Common;

public class YLabel
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    internal static YLabel FromJson(string json)
    {
        return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject<YLabel>(json);
    }
}