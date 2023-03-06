using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void KanyeQuote()
        {
            var kanye = new HttpClient();
            var kanyeResponseURL = "https://api.kanye.rest/";
            var kanyeResponse = kanye.GetStringAsync(kanyeResponseURL).Result;
            var kanyeResponseObject = JObject.Parse(kanyeResponse);
            Console.WriteLine($"Kanye Said: {kanyeResponseObject["quote"]}");
            Console.WriteLine();
        }
        public static void RoniQuote()
        {
            var roni = new HttpClient(); //client
            var roniResponseURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //endpoint
            var roniResponse = roni.GetStringAsync(roniResponseURL).Result; //GET request
            var roniResponseObject = JArray.Parse(roniResponse); //parse to string
            Console.WriteLine($"Roni Said: {roniResponseObject[0]}");
            Console.WriteLine();
        }
        public static void CarelessWhispers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------------------------------");
                RonVSKanyeAPI.KanyeQuote();
                RonVSKanyeAPI.RoniQuote();
                Console.WriteLine();

            }
        }
        
    }
}
