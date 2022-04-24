﻿using System.IO;
using Newtonsoft.Json.Linq;
using Serilog;
using Xunit;
using Xunit.Abstractions;

namespace Yandex.Music.Api.Tests;

[CollectionDefinition("Yandex Test Harness")]
public class YandexTestCollection : ICollectionFixture<YandexTestHarness>
{
}

public class YandexTest
{
    public YandexTest(YandexTestHarness fixture, ITestOutputHelper output = null)
    {
        Fixture = fixture;

        Api = new YandexMusicApi();

        if (output != null)
            Log.Logger = new LoggerConfiguration()
                .WriteTo
                .TestOutput(output)
                .CreateLogger();

        AppSettings = GetAppSettings();
    }

    public AppSettings AppSettings { get; set; }
    public IYandexMusicApi Api { get; set; }
    public YandexTestHarness Fixture { get; set; }

    private AppSettings GetAppSettings()
    {
        var fileSource = string.Empty;

        using (var stream = new FileStream("appsettings.json", FileMode.Open))
        {
            using (var reader = new StreamReader(stream))
            {
                fileSource = reader.ReadToEnd();
            }
        }

        var json = JToken.Parse(fileSource);

        return new AppSettings
        {
            Login = json["login"].ToObject<string>(),
            Password = json["password"].ToObject<string>()
        };
    }
}