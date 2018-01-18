using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
namespace WeatherApp.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxActivity<WeatherApp.Core.ViewModels.MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);           

            TextView text = FindViewById<TextView>(Resource.Id.weatherText);

            text.Text = ViewModel.Text;


        }

    }
}
