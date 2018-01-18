using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Excepctions;
using WeatherApp.Core.Extensions;
using WeatherApp.Core.IServices;
using WeatherApp.Core.Models;

namespace WeatherApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private IWeatherService _weatherService;

        public MainViewModel(IMvxNavigationService navigationService, IWeatherService weatherService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;



        }

        public override Task Initialize()
        {
            return base.Initialize();
        }



        private WeatherObject _weatherObj;

        private Main _mainInfo;

        private Sys _sysInfo;

        public Sys SysInfo

        {
            get { return _sysInfo; }
            set { SetProperty(ref _sysInfo, value); }
        }


        public Main MainInfo
        {
            get { return _mainInfo; }
            set { SetProperty(ref _mainInfo, value); }
        }


        public WeatherObject WeatherObj
        {
            get
            {
                return _weatherObj;
            }
            set { SetProperty(ref _weatherObj, value); }
        }
        private Weather _weatherInfo;

        public Weather WeatherInfo
        {
            get { return _weatherInfo; }
            set { SetProperty(ref _weatherInfo, value); }
        }

        public async Task Load()
        {
            try
            {
                var weatherTask = _weatherService.GetWeatherByLocation("Madrid");
                await Task.WhenAll(weatherTask);

                var currentWeather = weatherTask.Result;

                Set(currentWeather);

            }
            catch (Exception ex)
            {

                ProcessException(ex);

            }
        }

        private void Set(WeatherObject CurrentWeather)
        {
            WeatherObj = CurrentWeather;

            WeatherInfo = WeatherObj.Weather.FirstOrDefault();
            MainInfo = WeatherObj.Main;
            SysInfo = WeatherObj.Sys;

            Text = MainInfo.Humidity.ToString();


        }
        protected string ProcessException(Exception ex)
        {

            return
                ex is ApiException ? ex.Message : "Can not connect to the Server. Please try again later";


        }

        public IMvxCommand ResetTextCommand => new MvxCommand(RessetText);

        private async void RessetText()
        {

            await Load().ToTaskRun();

        }


        private string _text = "Hola";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

    }
}
