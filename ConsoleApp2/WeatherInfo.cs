using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static API.WeatherInfo;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("WinFormsApp1")]
namespace API
{
    internal class WeatherInfo {
        public int Id { get; set; }
        public required string name { get; set; }

        public class sys
        {
            public string country { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
        }

        public class weather
        { 
            public string description { get; set; }
        }

        public class wind 
        { 
            public double speed { get; set; }
        }

        public class root
        {
            public sys sys { get; set; }
            public wind wind { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public required string name { get; set; }
            public int Id { get; set; }

            public override string ToString()
            {
                return $"Country: {sys?.country}    Name: {name} \nTemp: {main?.temp} \u00B0C    Wiatr: {wind?.speed} m/s\nOpis: {weather[0]?.description}";
            }
        }
        

    }
}
