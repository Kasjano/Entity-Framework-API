using API;
using System.Net;
using System.Text.Json;
using static API.WeatherInfo;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BazaPogody bazaPogody;
        public Form1()
        {
            InitializeComponent();
            bazaPogody = new BazaPogody();
        }

        private async void button_Click(object sender, EventArgs e)
        {
            getWeather();
            bazaPogody.Weather_Datas.Add(new WeatherData() { City = Miasto.Text, Temperature = temperature.Text,
                Wind_speed = wind.Text, Description = description.Text});
            bazaPogody.SaveChanges();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=47ba3e0df814ceb2d36bc7fbed5392cd&units=metric&lang=pl", Miasto.Text);
                try
                {
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    double predkosc = Info.wind.speed * 3.6;
                    label5.Text = "";
                    wind.Text = predkosc.ToString("0.0") + " km/h";
                    temperature.Text = Info.main.temp.ToString("0.0") + " °C";
                    description.Text = Info.weather[0].description.ToString();
                    if (Info.weather[0].description == "bezchmurnie")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\bezchmurnie.jpg");
                    }
                    if (Info.weather[0].description == "zachmurzenie du¿e" || Info.weather[0].description == "pochmurnie")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\zachmurzenie_du¿e.png");
                    }
                    if (Info.weather[0].description == "zachmurzenie ma³e")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\zachmurzenie_ma³e.png");
                    }
                    if (Info.weather[0].description == "zamglenia")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\zamglenia.png");
                    }
                    if (Info.weather[0].description == "zachmurzenie umiarkowane")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\zachmurzenie_umiarkowane.png");
                    }
                    if (Info.weather[0].description == "s³abe opady deszczu" || Info.weather[0].description == "s³aba m¿awka")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\s³aby_deszcz.jpg");
                    }
                    if (Info.weather[0].description == "opady œniegu")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\œnieg.jpg");
                    }
                    if (Info.weather[0].description == "intensywne opady deszczu")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\du¿y_deszcz.png");
                    }
                    if (Info.weather[0].description == "burze z piorunami")
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Downloads\\burza.png");
                    }
                }
                catch
                {
                    label5.Text="Podano z³¹ nazwê miasta!!!";
                    wind.Text = "N/A";
                    description.Text = "N/A";
                    temperature.Text = "N/A";
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
