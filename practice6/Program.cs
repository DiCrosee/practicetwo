using System;
using System.Net;
using Newtonsoft.Json.Linq;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string apiKey = "ad971f17c6e72eb64d0500af4cd45169";
        string city = "Tomsk";

        using (WebClient webClient = new WebClient())
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
            string response = await webClient.DownloadStringTaskAsync(url);

            var json = JObject.Parse(response);

            Console.WriteLine($"Описание погоды: {json["weather"]?[0]?["description"]?.Value<string>()}");
            Console.WriteLine($"Температура: {json["main"]?["temp"]?.Value<double>()} C*");
            Console.WriteLine($"Скорость ветра: {json["wind"]?["speed"]?.Value<double>()} m/s");
            
        }
    }
}
// Описание погоды: overcast clouds
// Температура: -7,14 C*
// Скорость ветра: 4,98 m/s