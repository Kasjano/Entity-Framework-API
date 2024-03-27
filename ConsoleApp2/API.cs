using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static API.WeatherInfo;
using static System.Net.WebRequestMethods;

namespace API
{
    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            Console.WriteLine("Program sprawdzający pogodę w podanym mieście. Aby zakończyć wpisz \"Exit\"");
            string miasto = "";
            while (miasto != "Exit")
            {
                Console.Write("Wprowadź miasto: ");
                miasto = Console.ReadLine();
   
                string call = "https://api.openweathermap.org/data/2.5/weather?q=" + miasto + "&appid=47ba3e0df814ceb2d36bc7fbed5392cd&units=metric&lang=pl";
                try
                {
                    string response = await client.GetStringAsync(call);
                    WeatherInfo.root weather = JsonSerializer.Deserialize<WeatherInfo.root>(response);
                    Console.WriteLine(weather.ToString());
                }
                catch
                {
                    if (miasto == "Exit")
                        ;
                    else
                        Console.WriteLine("Podano złą nazwę miasta!!!");
                }
            }
        }
    }
}
