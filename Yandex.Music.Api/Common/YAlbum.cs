using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Yandex.Music.Api.Models.Artist;

namespace Yandex.Music.Api.Common;

public class YAlbum
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("title")] public string Title { get; set; }

    [JsonProperty("metaType")] public string MetaType { get; set; }

    [JsonProperty("contentWarning")] public string ContentWarning { get; set; }

    [JsonProperty("year")] public int Year { get; set; }

    [JsonProperty("releaseDate")] public DateTime ReleaseDate { get; set; }

    [JsonProperty("coverUri")] public string CoverUri { get; set; }

    [JsonProperty("ogImage")] public string OgImage { get; set; }

    [JsonProperty("genre")] public string Genre { get; set; }

    [JsonProperty("buy")] public List<string> Buy { get; set; }

    [JsonProperty("trackCount")] public int TrackCount { get; set; }

    [JsonProperty("likesCount")] public int LikesCount { get; set; }

    [JsonProperty("recent")] public bool Recent { get; set; }

    [JsonProperty("veryImportant")] public bool VeryImportant { get; set; }

    [JsonProperty("artists")] public List<YArtist> Artists { get; set; }

    [JsonProperty("labels")] public List<YLabel> Labels { get; set; }

    [JsonProperty("available")] public bool Available { get; set; }

    [JsonProperty("availableForPremiumUsers")]
    public bool AvailableForPremiumUsers { get; set; }

    [JsonProperty("availableForMobile")] public bool AvailableForMobile { get; set; }

    [JsonProperty("availablePartially")] public bool AvailablePartially { get; set; }

    [JsonProperty("bests")] public List<string> Bests { get; set; }

    internal static YAlbum FromJson(string json)
    {
        return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject<YAlbum>(json);
    }
}