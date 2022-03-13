using System.IO;
using Newtonsoft.Json.Linq;

namespace Yandex.Music.Client.Tests
{
    public class YandexTests
    {
        public YandexTests()
        {
            Client = new YandexMusicClient();
            AppSettings = GetAppSettings();
        }

        public AppSettings AppSettings { get; set; }
        public YandexMusicClient Client { get; set; }

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
}