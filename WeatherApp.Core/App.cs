using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //CreatableTypes()
            //    .EndingWith("Client")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();


            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}
