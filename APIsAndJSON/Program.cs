using Newtonsoft.Json.Linq;
namespace APIsAndJSON
    
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Ron and Kanye Convo
            // RonVSKanyeAPI.CarelessWhispers();

            //WeatherMap Exercise
            var client = new HttpClient();

            var key = "94684d2050fd2691b4eed34a07a2679c";
            var city = "Birmingham";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
            var response = client.GetStringAsync(weatherURL).Result;

            var formattedResponse= JObject.Parse(response).GetValue("main");
            Console.WriteLine(formattedResponse);
            
        }
    }
}
