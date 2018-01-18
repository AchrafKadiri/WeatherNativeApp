using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Models;

namespace WeatherApp.Core.IServices
{
    public interface IWeatherService
    {
        Task<WeatherObject> GetWeatherByLocation(string city);
    }
}
