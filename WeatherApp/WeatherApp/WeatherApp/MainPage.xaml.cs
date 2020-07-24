using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Xml.Linq;
using System.Net;
using System.IO;
using Android.Content.Res;

namespace WeatherApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool isBigFont = false;
        bool isTheme = false;
        bool isSound = false;
        public MainPage()
        {
            
            InitializeComponent();
        }

        private void pckPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSound)
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                //AssetManager asset = Android.App.Application.Context.Assets;
                //var fileName = asset.Open("button.wav");
                player.Load("button.wav");
                player.Play();
            }
            getWeatherInfo();
        }

        private void PopulateValues(XDocument xdoc)
        {
            lblCityDisplay.Text = xdoc.Root.Element("city").Attribute("name").Value;
            lblTemperatureDisplay.Text = xdoc.Root.Element("temperature").Attribute("value").Value;
            lblSunriseTimeDisplay.Text = xdoc.Root.Element("city").Element("sun").Attribute("rise").Value;
            lblSunsetTimeDisplay.Text = xdoc.Root.Element("city").Element("sun").Attribute("rise").Value;
            lblWindSpeedDisplay.Text = xdoc.Root.Element("wind").Element("speed").Attribute("value").Value;
            lblHumidityDisplay.Text = xdoc.Root.Element("humidity").Attribute("value").Value;
        }

        private async void getWeatherInfo()
        {
            string query = @"http://api.openweathermap.org/data/2.5/weather?q=" + pckPicker.SelectedItem + ",AU&appid=3c32ee0fa8a2754763caf23bc8ddd0c4&units=metric&mode=xml";
            WebRequest req = WebRequest.Create(query);
            WebResponse res = await req.GetResponseAsync();
            XDocument xdoc = XDocument.Load(res.GetResponseStream());
            PopulateValues(xdoc);
        }

        private void mnuTheme_Clicked(object sender, EventArgs e)
        {
            if (isTheme)
            {
                lblCity.BackgroundColor = Color.LightBlue;
                lblTemperature.BackgroundColor = Color.LightBlue;
                lblSunriseTime.BackgroundColor = Color.LightBlue;
                lblSunsetTime.BackgroundColor = Color.LightBlue;
                lblWindSpeed.BackgroundColor = Color.LightBlue;
                lblHumidity.BackgroundColor = Color.LightBlue;

                lblCityDisplay.BackgroundColor = Color.White;
                lblTemperatureDisplay.BackgroundColor = Color.White;
                lblSunriseTimeDisplay.BackgroundColor = Color.White;
                lblSunsetTimeDisplay.BackgroundColor = Color.White;
                lblWindSpeedDisplay.BackgroundColor = Color.White;
                lblHumidityDisplay.BackgroundColor = Color.White;

                pckPicker.BackgroundColor = Color.White;
                isTheme = false;

            }
            else
            {
                lblCity.BackgroundColor = Color.IndianRed;
                lblTemperature.BackgroundColor = Color.IndianRed;
                lblSunriseTime.BackgroundColor = Color.IndianRed;
                lblSunsetTime.BackgroundColor = Color.IndianRed;
                lblWindSpeed.BackgroundColor = Color.IndianRed;
                lblHumidity.BackgroundColor = Color.IndianRed;

                lblCityDisplay.BackgroundColor = Color.LightGray;
                lblTemperatureDisplay.BackgroundColor = Color.LightGray;
                lblSunriseTimeDisplay.BackgroundColor = Color.LightGray;
                lblSunsetTimeDisplay.BackgroundColor = Color.LightGray;
                lblWindSpeedDisplay.BackgroundColor = Color.LightGray;
                lblHumidityDisplay.BackgroundColor = Color.LightGray;

                pckPicker.BackgroundColor = Color.Gray;
                isTheme = true;
            }
        }

        private void mnuFontSize_Clicked(object sender, EventArgs e)
        {
            if (isBigFont)
            {
                lblCity.FontSize = 30;
                lblTemperature.FontSize = 15;
                lblSunriseTime.FontSize = 15;
                lblSunsetTime.FontSize = 15;
                lblWindSpeed.FontSize = 15;
                lblHumidity.FontSize = 15;

                lblCityDisplay.FontSize = 30;
                lblTemperatureDisplay.FontSize = 15;
                lblSunriseTimeDisplay.FontSize = 15;
                lblSunsetTimeDisplay.FontSize = 15;
                lblWindSpeedDisplay.FontSize = 15;
                lblHumidityDisplay.FontSize = 15;

                pckPicker.FontSize = 50;
                isBigFont = false;
            }
            else
            {
                lblCity.FontSize = 50;
                lblTemperature.FontSize = 25;
                lblSunriseTime.FontSize = 25;
                lblSunsetTime.FontSize = 25;
                lblWindSpeed.FontSize = 25;
                lblHumidity.FontSize = 25;

                lblCityDisplay.FontSize = 50;
                lblTemperatureDisplay.FontSize = 25;
                lblSunriseTimeDisplay.FontSize = 25;
                lblSunsetTimeDisplay.FontSize = 25;
                lblWindSpeedDisplay.FontSize = 25;
                lblHumidityDisplay.FontSize = 25;

                pckPicker.FontSize = 77;
                isBigFont = true;
            }
        }

        private void mnuSound_Clicked(object sender, EventArgs e)
        {
            if(isSound)
            {
                isSound = false;
            }
            else
            {
                isSound = true;
            }
        }
    }
}
