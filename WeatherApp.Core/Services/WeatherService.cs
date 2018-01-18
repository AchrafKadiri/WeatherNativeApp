using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Constants;
using WeatherApp.Core.IServices;
using WeatherApp.Core.Models;

namespace WeatherApp.Core.Services
{
   public class WeatherService : IWeatherService
    {
        private ApiService _apiService;

        public WeatherService()
        {
            _apiService = new ApiService();
        }

        async Task<WeatherObject> IWeatherService.GetWeatherByLocation(string city)
        {
            try
            {

                return await _apiService.GetApi<WeatherObject>(ApiUris.WeatherByCity_GET, city);
            }
            catch (Exception cex)
            {

                throw cex;
            }
        }
    }
}
