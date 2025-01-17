using FluentAssertions;
using Xunit;
using Xunit.Abstractions;
using Yandex.Music.Api.Tests.Traits;

namespace Yandex.Music.Api.Tests.Tests.Album;

[Collection("Yandex Test Harness")]
public class AlbumTests : YandexTest
{
    public AlbumTests(YandexTestHarness fixture, ITestOutputHelper output = null) : base(fixture, output)
    {
    }

    [Fact]
    [YandexTrait(TraitGroup.Authorize)]
    public void Account_ValidData_GenerateTrue()
    {
        var isAuthorized = Api.Authorize(AppSettings.Login, AppSettings.Password);
        var accounts = Api.GetAccounts();

        isAuthorized.IsAuthorized.Should().BeTrue();

        var d = Api.GetAlbum("9086864");
    }
}