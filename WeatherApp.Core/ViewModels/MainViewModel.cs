using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

           
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(RessetText);

        private void RessetText()
        {
            Text = "Soy el viewModel";
        }


        private string  _text= "Hola";

        public string  Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

    }
}
