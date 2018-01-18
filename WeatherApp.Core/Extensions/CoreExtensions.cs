using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.Extensions
{
    public static class CoreExtensions
    {

        public static Task ToTaskRun(this Task me)
        {
            return Task.Run(async () => { await me; });
        }

    }
}
