using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Current temperature in Kyiv: " + ShowCurrentTemp("Kyiv"));
                Console.WriteLine("Current temperature in Odesa: " + ShowCurrentTemp("Odesa"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        class Weather
        {
            public string Temperature { get; set; }
        }
        static string ShowCurrentTemp (string city)
        {

            string response = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://goweather.herokuapp.com/weather/" + city);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Weather temperature = JsonConvert.DeserializeObject<Weather>(response);
            return temperature.Temperature;
        }

    }
}
