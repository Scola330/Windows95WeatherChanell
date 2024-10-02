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
            string pogoda_stan = string.Empty;
            if(pogoda == "0")
            {
                pogoda_stan = "Bezchmurnie"; 
            }
            else if(pogoda == "1" || pogoda == "2" || pogoda == "3")
            {
                pogoda_stan = "Czêœciowo zachmurzone";
            }
            else if(pogoda == "45" || pogoda == "48")
            {
                pogoda_stan = "Mg³a";
            }
            else if (pogoda == "51" || pogoda == "53" || pogoda == "55")
            {
                pogoda_stan = "Ma³e opady deszczu";
            }
            else if (pogoda == "56" || pogoda == "57")
            {
                pogoda_stan = "ma³e opady deszczu ze œniegiem";
            }
            else if (pogoda == "61" || pogoda == "63" || pogoda == "65")
            {
                pogoda_stan = "Œrednie opady deszczu";
            }
            else if (pogoda == "66" || pogoda == "67")
            {
                pogoda_stan = "Œrednie opady deszczu z œniegiem";
            }
            else if (pogoda == "71")
            {
                pogoda_stan = "Ma³e opady œniegu";
            }
            else if (pogoda == "73")
            {
                pogoda_stan = "Œrednie opady œniegu";
            }
            else if (pogoda == "75")
            {
                pogoda_stan = "Du¿e opady œniegu";
            }
            else if (pogoda == "77")
            {
                pogoda_stan = "Œrednie opady deszczu z œniegiem";
            }
            else if (pogoda == "81")
            {
                pogoda_stan = "Ulewa pierwszego stopnia";
            }
            else if (pogoda == "82")
            {
                pogoda_stan = "Ulewa drugiego stopnia";
            }
            else if (pogoda == "83")
            {
                pogoda_stan = "Ulewa trzeciego stopnia";
            }
            else if (pogoda == "85")
            {
                pogoda_stan = "Sztorm œnie¿ny pierwszego stopnia";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Sztorm œnie¿ny drugiego stopnia";
            }
            else if (pogoda == "95")
            {
                pogoda_stan = "Burza";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Burza z gradem";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Sztorm z gradem";
            }
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
            string pogoda = myDeserializedClass.current.weather_code.ToString();
            string pogoda_stan = string.Empty;
            if (pogoda == "0")
            {
                pogoda_stan = "Bezchmurnie";
            }
            else if (pogoda == "1" || pogoda == "2" || pogoda == "3")
            {
                pogoda_stan = "Czêœciowo zachmurzone";
            }
            else if (pogoda == "45" || pogoda == "48")
            {
                pogoda_stan = "Mg³a";
            }
            else if (pogoda == "51" || pogoda == "53" || pogoda == "55")
            {
                pogoda_stan = "Ma³e opady deszczu";
            }
            else if (pogoda == "56" || pogoda == "57")
            {
                pogoda_stan = "ma³e opady deszczu ze œniegiem";
            }
            else if (pogoda == "61" || pogoda == "63" || pogoda == "65")
            {
                pogoda_stan = "Œrednie opady deszczu";
            }
            else if (pogoda == "66" || pogoda == "67")
            {
                pogoda_stan = "Œrednie opady deszczu z œniegiem";
            }
            else if (pogoda == "71")
            {
                pogoda_stan = "Ma³e opady œniegu";
            }
            else if (pogoda == "73")
            {
                pogoda_stan = "Œrednie opady œniegu";
            }
            else if (pogoda == "75")
            {
                pogoda_stan = "Du¿e opady œniegu";
            }
            else if (pogoda == "77")
            {
                pogoda_stan = "Œrednie opady deszczu z œniegiem";
            }
            else if (pogoda == "81")
            {
                pogoda_stan = "Ulewa pierwszego stopnia";
            }
            else if (pogoda == "82")
            {
                pogoda_stan = "Ulewa drugiego stopnia";
            }
            else if (pogoda == "83")
            {
                pogoda_stan = "Ulewa trzeciego stopnia";
            }
            else if (pogoda == "85")
            {
                pogoda_stan = "Sztorm œnie¿ny pierwszego stopnia";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Sztorm œnie¿ny drugiego stopnia";
            }
            else if (pogoda == "95")
            {
                pogoda_stan = "Burza";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Burza z gradem";
            }
            else if (pogoda == "86")
            {
                pogoda_stan = "Sztorm z gradem";
            }
        }
    }
}
