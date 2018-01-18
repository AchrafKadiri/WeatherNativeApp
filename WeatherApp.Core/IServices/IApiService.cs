using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Core.Constants;

namespace WeatherApp.Core.IServices
{
   public  interface IApiService
    {
        Task<T> GetApi<T>(ApiUris apiUris, string city);
    }
}
