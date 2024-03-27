using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("WinFormsApp1")]

namespace API
{
    internal class WeatherData
    {
        public int Id { get; set; }
        public required string City { get; set; } 
        public string Temperature { get; set; } 
        public string Wind_speed { get; set; } 
        public string Description { get; set; }
    }
}
