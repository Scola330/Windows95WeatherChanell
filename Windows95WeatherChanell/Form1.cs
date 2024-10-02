using Newtonsoft.Json;
using System.Security.Policy;

namespace Windows95WeatherChanell
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void butttonTest(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress =
               new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,weather_code");
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            test.Text = result;
        }
        void pogodaDisplay(object sender, EventArgs e)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data);
            string temperatura_wartosc = myDeserializedClass.current.temperature_2m.ToString();
            string temperatura_jednostka = myDeserializedClass.current_units.temperature_2m.ToString();
            string temperatura = temperatura_wartosc + " " + temperatura_jednostka;
            temp.Text = temperatura;
            string wilgotnosc_wartosc = myDeserializedClass.current.relative_humidity_2m.ToString();
            string wilgotnosc_jednostka = myDeserializedClass.current_units.relative_humidity_2m.ToString();
            string wilgotnosc = wilgotnosc_wartosc + " " + wilgotnosc_jednostka;
            wil.Text = wilgotnosc;
            string pogoda = myDeserializedClass.current.weather_code.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress =
               new Uri("https://api.open-meteo.com/v1/forecast?latitude=54.36&longitude=18.64&current=temperature_2m,relative_humidity_2m,weather_code");
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            data = result;
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data);
            string temperatura_wartosc = myDeserializedClass.current.temperature_2m.ToString();
            string temperatura_jednostka = myDeserializedClass.current_units.temperature_2m.ToString();
            string temperatura = temperatura_wartosc + " " + temperatura_jednostka;
            temp.Text = temperatura;
            string wilgotnosc_wartosc = myDeserializedClass.current.relative_humidity_2m.ToString();
            string wilgotnosc_jednostka = myDeserializedClass.current_units.relative_humidity_2m.ToString();
            string wilgotnosc = wilgotnosc_wartosc + " " + wilgotnosc_jednostka;
            wil.Text = wilgotnosc;
        }
    }
}
